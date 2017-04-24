using DotSpatial.Controls;
using DotSpatial.Data;
using DotSpatial.Symbology;
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
    public partial class SnapshotAttributeTable : Form
    {
        public static IFeatureLayer DataLayer { get; set; }
        List<string> DeselectedColumns = new List<string>();

        public SnapshotAttributeTable()
        {
            InitializeComponent();
        }

        private void SnapshotAttributeTable_Load(object sender, EventArgs e)
        {
            var layerTitles = MapForm.MapInstance.Layers.Where(l => l is IFeatureLayer).Select(l => l.LegendText).ToArray();
            cboLayers.Items.AddRange(layerTitles);
        }

        private void cboLayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var layerTitle = cboLayers.SelectedItem.ToString();
            IFeatureLayer layer;
            try
            {
                layer = MapForm.MapInstance.Layers.Where(l => l.LegendText == layerTitle).Single() as IFeatureLayer;
            } catch (Exception exce)
            {
                MessageBox.Show("Error: " + exce + "\n\nCan't select this Layer. Is it a duplicate name of another?");
                return;
            }
            if (layer == null) {
                MessageBox.Show("Error: Selected layer is null somehow.");
                return;
            }
            DataLayer = layer;
            btnEditSelectedRows.Enabled = true;
            btnEditColumns.Enabled = true;
        }

        private void btnEditSelectedRows_Click(object sender, EventArgs e)
        {
            DataLayer.SelectionChanged += DataLayer_SelectionChanged;
            DataLayer.ShowAttributes();
        }

        private void DataLayer_SelectionChanged(object sender, EventArgs e)
        {
            UpdateSelectedColumns();
        }

        private void btnEditColumns_Click(object sender, EventArgs e)
        {
            var selectedColumns = new List<string>();
            foreach (DataGridViewTextBoxColumn c in dataSelection.Columns)
            {
                selectedColumns.Add(c.Name);
            }
            var availableColumns = new List<string>();
            foreach (DataColumn c in DataLayer.DataSet.DataTable.Columns)
            {
                availableColumns.Add(c.ColumnName);
            }
            availableColumns = availableColumns.Where(s => !(selectedColumns.Contains(s))).ToList(); ;
            using (var form = new ColumnEditor(availableColumns, selectedColumns))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    DeselectedColumns = form.GetUnselectedColumnNames().ToList();
                    UpdateSelectedColumns();
                }
            }
        }

        private void UpdateSelectedColumns()
        {
            var data = DataLayer.Selection.ToFeatureSet().DataTable;
            if (data != null && data.Rows.Count > 0)
            {
                foreach (var str in DeselectedColumns)
                {
                    if (data.Columns.Contains(str)) 
                        data.Columns.Remove(str);
                }
                dataSelection.DataSource = data.Copy();
            }
        }

        private void btnCancelAttributeSnapshot_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnTakeAttributeSnapshot_Click(object sender, EventArgs e)
        {
            using (var frm = new SaveItem())
            {
                var result = frm.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    Workspace.Instance.SaveDataset((DataTable)dataSelection.DataSource, frm.SaveName, frm.GroupName);
                }
            }
        }
    }
}
