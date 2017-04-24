using ShapeReport.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace ShapeReport
{
    class Workspace
    {
        private static Workspace instance;
        public static Workspace Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = Create("Workspace");
                }
                return instance;
            }
        }
        public string SaveDir { get; set; }

        public static Workspace SetWorkspace(string dir)
        {
            instance = Create(dir);
            return instance;
        }

        private static Workspace Create(string dir)
        {
            var space = new Workspace();
            space.SaveDir = Environment.CurrentDirectory + @"\" + dir + @"\";
            Directory.CreateDirectory(space.SaveDir);
            var uncategorized = new WorkspaceItemGroup(0, space.SaveDir, "Uncategorized");
            return space;
        }

        public List<WorkspaceItemGroup> GetItemGroups()
        {
            var groups = new List<WorkspaceItemGroup>();
            foreach (var directory in Directory.EnumerateDirectories(SaveDir))
            {
                groups.Add(new WorkspaceItemGroup(groups.Count, new DirectoryInfo(directory).Name));
            }
            return groups;
        }

        public void SaveImage(Bitmap image, string name, string group = "Uncategorized")
        {
            var dir = Path.Combine(SaveDir, group);
            Directory.CreateDirectory(dir);
            TrimBitmap(image).Save(dir + "\\" + name + (name.EndsWith(".png") ? "" : ".png"));
        }

        public void SaveDataset(DataTable data, string name, string group = "Uncategorized")
        {
            foreach (DataColumn col in data.Columns)
            {
                //col.ColumnName;
            }
            foreach (DataRow row in data.Rows)
            {
                //row.ItemArray
            }
            var json = JsonConvert.SerializeObject(data);
            var dir = Path.Combine(SaveDir, group);
            Directory.CreateDirectory(dir);
            File.WriteAllText($"{dir}\\{name}.json", json);
        }

        private Bitmap TrimBitmap(Bitmap source)
        {
            Rectangle srcRect = default(Rectangle);
            BitmapData data = null;
            try
            {
                data = source.LockBits(new Rectangle(0, 0, source.Width, source.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
                byte[] buffer = new byte[data.Height * data.Stride];
                Marshal.Copy(data.Scan0, buffer, 0, buffer.Length);
                int xMin = int.MaxValue;
                int xMax = 0;
                int yMin = int.MaxValue;
                int yMax = 0;
                for (int y = 0; y < data.Height; y++)
                {
                    for (int x = 0; x < data.Width; x++)
                    {
                        byte alpha = buffer[y * data.Stride + 4 * x + 3];
                        if (alpha != 0)
                        {
                            if (x < xMin) xMin = x;
                            if (x > xMax) xMax = x;
                            if (y < yMin) yMin = y;
                            if (y > yMax) yMax = y;
                        }
                    }
                }
                if (xMax < xMin || yMax < yMin)
                {
                    // Image is empty...
                    return null;
                }
                srcRect = Rectangle.FromLTRB(xMin, yMin, xMax, yMax);
            }
            finally
            {
                if (data != null)
                    source.UnlockBits(data);
            }

            Bitmap dest = new Bitmap(srcRect.Width, srcRect.Height);
            Rectangle destRect = new Rectangle(0, 0, srcRect.Width, srcRect.Height);
            using (Graphics graphics = Graphics.FromImage(dest))
            {
                graphics.DrawImage(source, destRect, srcRect, GraphicsUnit.Pixel);
            }
            return dest;
        }
    }
}
