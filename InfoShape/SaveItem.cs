using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeReport
{
    public partial class SaveItem : Form
    {
        public string SaveName { get; set; }
        public string GroupName { get; set; }

        public SaveItem()
        {
            InitializeComponent();
            GroupName = "Uncategorized";
        }

        private void btnCancelSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void txtSaveName_TextChanged(object sender, EventArgs e)
        {
            SaveName = txtSaveName.Text;
        }

        private void SaveItem_Load(object sender, EventArgs e)
        {
            cboGroups.Items.Clear();
            cboGroups.Items.AddRange(Workspace.Instance.GetItemGroups().Select(g => g.Name).ToArray());
        }

        private void cboGroups_TextChanged(object sender, EventArgs e)
        {
            GroupName = cboGroups.Text;
        }
    }
}
