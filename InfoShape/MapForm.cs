using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using RazorEngine;
using RazorEngine.Templating;
using System.IO;
using DotSpatial.Controls;
using DotSpatial.Symbology;

namespace InfoShape
{
    public partial class MapForm : Form
    {
        public static Map MapInstance { get; set; }

        public MapForm()
        {
            InitializeComponent();
            Legend.AddMapFrame(Map.MapFrame);
            Map.AddLayer(Program.INFILE);
            MapInstance = this.Map;
        }

        private void MapForm_Load(object sender, EventArgs e)
        {
        }

        private void btnClearMap_Click(object sender, EventArgs e)
        {
            Map.ClearLayers();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Map.AddLayers();
        }

        private void btnPan_Click(object sender, EventArgs e)
        {
            Map.FunctionMode = DotSpatial.Controls.FunctionMode.Pan;
        }

        private void btnZoomExtent_Click(object sender, EventArgs e)
        {
            Map.ZoomToMaxExtent();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Map.FunctionMode = DotSpatial.Controls.FunctionMode.Info;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Map.FunctionMode = DotSpatial.Controls.FunctionMode.Select;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Map.FunctionMode = DotSpatial.Controls.FunctionMode.None;
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            Map.FunctionMode = DotSpatial.Controls.FunctionMode.ZoomIn;
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            Map.FunctionMode = DotSpatial.Controls.FunctionMode.ZoomOut;
        }

        private void Map_SelectionChanged(object sender, EventArgs e)
        {
            var layer = (MapPolygonLayer)Map.Layers[0];
            var dt = layer.Selection;
            foreach (var sel in dt.ToFeatureList())
            {
                var data = sel.DataRow;
            }
        }

        private void btnShowAttributes_Click(object sender, EventArgs e)
        {
            IMapLayer selected = null;
            try
            {
                selected = Map.Layers.Where(l => l.IsSelected).Single();
            } catch (Exception)
            {
                MessageBox.Show("Must have a layer selected in Table of Contents.");
                return;
            }
            if (!(selected is IFeatureLayer))
            {
                MessageBox.Show("Not a valid Layer.");
                return;
            }
            ((IFeatureLayer)selected).ShowAttributes();
            var table = ((IFeatureLayer)selected).DataSet;
        }

        private void btnExitMap_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm.Instance.Show();
        }

        private void btnAttributeSnapshop_Click(object sender, EventArgs e)
        {
            new SnapshotAttributeTable().Show();
        }

        private void btnMapSnapshot_Click(object sender, EventArgs e)
        {
            var frm = new LayoutForm()
            {
                MapControl = Map
            };
            frm.Show();
            frm.OnSnapshotTaken += Frm_OnSnapshotTaken;
        }


        private void Frm_OnSnapshotTaken(object sender, LayoutForm.SnapShotArgs e)
        {
            e.Image.Save(Program.OUTIMAGE);
        }
    }
}
