using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoShape
{
    class ItemManager
    {
        private static ItemManager instance;
        public static ItemManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ItemManager();
                    SaveDir = Environment.CurrentDirectory + @"\Workspace\";
                    Directory.CreateDirectory(SaveDir);
                }
                return instance;
            }
        }
        public static string SaveDir { get; set; }

        public ItemManager() {}

        public void SaveImage(Bitmap image, string name)
        {
            image.Save(SaveDir + name);
        }

        public void SaveDataset(DataTable data, string name)
        {
            var json = JsonConvert.SerializeObject(data);
            File.WriteAllText($"{SaveDir}{name}.json", json);
        }
    }
}
