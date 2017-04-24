using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeReport.Models
{
    public class WorkspaceItem
    {
        public int Order { get; set; }
        public string Name
        {
            get
            {
                return new FileInfo(FilePath).Name;
            }
        }
        public string FilePath { get; set; }
        public string Type
        {
            get
            {
                return GetItemType().ToString().ToLower();
            }
        }
        public WorkspaceItem(int order, string file)
        {
            this.Order = order;
            this.FilePath = file;
        }

        public ItemType GetItemType()
        {
            switch (FilePath.Split('.').Last())
            {
                case "png":
                    {
                        return ItemType.Image;
                    }
                case "json":
                    {
                        return ItemType.Table;
                    }
                case "txt":
                    {
                        return ItemType.Text;
                    }
                default:
                    {
                        return ItemType.Unknown;
                    }
            }
        }

        public enum ItemType
        {
            Unknown,
            Text,
            Image,
            Table
        }
    }
}
