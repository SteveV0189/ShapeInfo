using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeReport.Models
{
    public class WorkspaceItemGroup
    {
        public int Order { get; set; }
        public string Name { get; set; }

        public List<WorkspaceItem> GetItems()
        {
            List<WorkspaceItem> items = new List<WorkspaceItem>();
            var dir = Path.Combine(Workspace.Instance.SaveDir, Name);
            foreach (var file in Directory.EnumerateFiles(dir))
            {
                items.Add(new WorkspaceItem(items.Count, file));
            }
            return items;
        }

        public WorkspaceItemGroup(int order, string name) : this(order, Workspace.Instance.SaveDir, name) { }

        public WorkspaceItemGroup(int order, string dir, string name)
        {
            this.Name = name;
            this.Order = order;
            Directory.CreateDirectory(Path.Combine(dir, Name));
        }
    }
}
