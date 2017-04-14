using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoShape
{
    public partial class ColumnEditor : Form
    {

        public ColumnEditor(List<string> available, List<string> selected)
        {
            InitializeComponent();
            lstSelectedColumns.Items.AddRange(selected.ToArray());
            lstAvailableColumns.Items.AddRange(available.ToArray());
        }

        public string[] GetSelectedColumnNames()
        {
            string[] items = new string[lstSelectedColumns.Items.Count];
            lstSelectedColumns.Items.CopyTo(items, 0);
            return items;
        }

        public string[] GetUnselectedColumnNames()
        {
            string[] items = new string[lstAvailableColumns.Items.Count];
            lstAvailableColumns.Items.CopyTo(items, 0);
            return items;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var selected = lstAvailableColumns.SelectedItems;
            var toRemove = new List<string>();
            foreach (string sel in selected)
            {
                lstSelectedColumns.Items.Add(sel);
                toRemove.Add(sel);
            }
            foreach (var str in toRemove)
            {
                lstAvailableColumns.Items.Remove(str);
            }
        }

        private void btnDeselect_Click(object sender, EventArgs e)
        {
            var selected = lstSelectedColumns.SelectedItems;
            var toRemove = new List<string>();
            foreach (string sel in selected)
            {
                lstAvailableColumns.Items.Add(sel);
                toRemove.Add(sel);
            }
            foreach (var str in toRemove)
            {
                lstSelectedColumns.Items.Remove(str);
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            string[] items = new string[lstAvailableColumns.Items.Count];
            lstAvailableColumns.Items.CopyTo(items, 0);
            lstAvailableColumns.Items.Clear();
            lstSelectedColumns.Items.AddRange(items);
        }

        private void btnDeselectAll_Click(object sender, EventArgs e)
        {
            string[] items = new string[lstSelectedColumns.Items.Count];
            lstSelectedColumns.Items.CopyTo(items, 0);
            lstSelectedColumns.Items.Clear();
            lstAvailableColumns.Items.AddRange(items);
        }

        private void btnFinishColumns_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;   
        }

        private void lstAvailableColumns_DoubleClick(object sender, EventArgs e)
        {

        }

        private void lstSelectedColumns_DoubleClick(object sender, EventArgs e)
        {

        }

        private void ColumnEditor_Load(object sender, EventArgs e)
        {
        }
    }
}
