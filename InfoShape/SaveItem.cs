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
    public partial class SaveItem : Form
    {
        public string SaveName { get; set; }
        public SaveItem()
        {
            InitializeComponent();
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
    }
}
