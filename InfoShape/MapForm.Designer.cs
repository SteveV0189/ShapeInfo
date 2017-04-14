using DotSpatial.Controls;

namespace InfoShape
{
    partial class MapForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapForm));
            this.MapToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnClearMap = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btnInfo = new System.Windows.Forms.ToolStripButton();
            this.btnSelect = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.btnPan = new System.Windows.Forms.ToolStripButton();
            this.btnZoomOut = new System.Windows.Forms.ToolStripButton();
            this.btnZoomIn = new System.Windows.Forms.ToolStripButton();
            this.btnZoomExtent = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnShowAttributes = new System.Windows.Forms.ToolStripButton();
            this.grpSnapshots = new System.Windows.Forms.GroupBox();
            this.btnAttributeSnapshop = new System.Windows.Forms.Button();
            this.btnExitMap = new System.Windows.Forms.Button();
            this.btnMapTableSnapshot = new System.Windows.Forms.Button();
            this.btnMapSnapshot = new System.Windows.Forms.Button();
            this.spatialDockManager1 = new DotSpatial.Controls.SpatialDockManager();
            this.Legend = new DotSpatial.Controls.Legend();
            this.Map = new DotSpatial.Controls.Map();
            this.MapToolStrip.SuspendLayout();
            this.grpSnapshots.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spatialDockManager1)).BeginInit();
            this.spatialDockManager1.Panel1.SuspendLayout();
            this.spatialDockManager1.Panel2.SuspendLayout();
            this.spatialDockManager1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MapToolStrip
            // 
            this.MapToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.MapToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MapToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnOpen,
            this.btnClearMap,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.btnInfo,
            this.btnSelect,
            this.btnCancel,
            this.toolStripSeparator2,
            this.toolStripLabel3,
            this.btnPan,
            this.btnZoomOut,
            this.btnZoomIn,
            this.btnZoomExtent,
            this.toolStripSeparator3,
            this.btnShowAttributes});
            this.MapToolStrip.Location = new System.Drawing.Point(12, 9);
            this.MapToolStrip.Name = "MapToolStrip";
            this.MapToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MapToolStrip.Size = new System.Drawing.Size(410, 25);
            this.MapToolStrip.Stretch = true;
            this.MapToolStrip.TabIndex = 3;
            this.MapToolStrip.Text = "Map Tool Strip";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(40, 22);
            this.toolStripLabel1.Text = "Layers";
            // 
            // btnOpen
            // 
            this.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(23, 22);
            this.btnOpen.Text = "Add Layers";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClearMap
            // 
            this.btnClearMap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClearMap.Image = ((System.Drawing.Image)(resources.GetObject("btnClearMap.Image")));
            this.btnClearMap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClearMap.Name = "btnClearMap";
            this.btnClearMap.Size = new System.Drawing.Size(23, 22);
            this.btnClearMap.Text = "Clear Map";
            this.btnClearMap.Click += new System.EventHandler(this.btnClearMap_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(55, 22);
            this.toolStripLabel2.Text = "Selection";
            // 
            // btnInfo
            // 
            this.btnInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(23, 22);
            this.btnInfo.Text = "Info";
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
            this.btnSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(23, 22);
            this.btnSelect.Text = "Select";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(23, 22);
            this.btnCancel.Text = "Cancel Select";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(64, 22);
            this.toolStripLabel3.Text = "Move Map";
            // 
            // btnPan
            // 
            this.btnPan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPan.Image = ((System.Drawing.Image)(resources.GetObject("btnPan.Image")));
            this.btnPan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPan.Name = "btnPan";
            this.btnPan.Size = new System.Drawing.Size(23, 22);
            this.btnPan.Text = "Pan";
            this.btnPan.Click += new System.EventHandler(this.btnPan_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomOut.Image")));
            this.btnZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(23, 22);
            this.btnZoomOut.Text = "Zoom Out";
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomIn.Image")));
            this.btnZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(23, 22);
            this.btnZoomIn.Text = "Zoom In";
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomExtent
            // 
            this.btnZoomExtent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoomExtent.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomExtent.Image")));
            this.btnZoomExtent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomExtent.Name = "btnZoomExtent";
            this.btnZoomExtent.Size = new System.Drawing.Size(23, 22);
            this.btnZoomExtent.Text = "Zoom to Extent";
            this.btnZoomExtent.Click += new System.EventHandler(this.btnZoomExtent_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnShowAttributes
            // 
            this.btnShowAttributes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnShowAttributes.Image = ((System.Drawing.Image)(resources.GetObject("btnShowAttributes.Image")));
            this.btnShowAttributes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowAttributes.Name = "btnShowAttributes";
            this.btnShowAttributes.Size = new System.Drawing.Size(23, 22);
            this.btnShowAttributes.Text = "Show Attributes";
            this.btnShowAttributes.Click += new System.EventHandler(this.btnShowAttributes_Click);
            // 
            // grpSnapshots
            // 
            this.grpSnapshots.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.grpSnapshots.Controls.Add(this.btnAttributeSnapshop);
            this.grpSnapshots.Controls.Add(this.btnExitMap);
            this.grpSnapshots.Controls.Add(this.btnMapTableSnapshot);
            this.grpSnapshots.Controls.Add(this.btnMapSnapshot);
            this.grpSnapshots.Location = new System.Drawing.Point(12, 478);
            this.grpSnapshots.Name = "grpSnapshots";
            this.grpSnapshots.Size = new System.Drawing.Size(875, 98);
            this.grpSnapshots.TabIndex = 4;
            this.grpSnapshots.TabStop = false;
            this.grpSnapshots.Text = "Snapshot Operations";
            // 
            // btnAttributeSnapshop
            // 
            this.btnAttributeSnapshop.BackColor = System.Drawing.Color.SandyBrown;
            this.btnAttributeSnapshop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAttributeSnapshop.FlatAppearance.BorderSize = 2;
            this.btnAttributeSnapshop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.btnAttributeSnapshop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttributeSnapshop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttributeSnapshop.Location = new System.Drawing.Point(426, 19);
            this.btnAttributeSnapshop.Name = "btnAttributeSnapshop";
            this.btnAttributeSnapshop.Size = new System.Drawing.Size(204, 70);
            this.btnAttributeSnapshop.TabIndex = 3;
            this.btnAttributeSnapshop.Text = "Take Snapshot\r\n(attribute table alone)";
            this.btnAttributeSnapshop.UseVisualStyleBackColor = false;
            this.btnAttributeSnapshop.Click += new System.EventHandler(this.btnAttributeSnapshop_Click);
            // 
            // btnExitMap
            // 
            this.btnExitMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitMap.Location = new System.Drawing.Point(794, 19);
            this.btnExitMap.Name = "btnExitMap";
            this.btnExitMap.Size = new System.Drawing.Size(75, 70);
            this.btnExitMap.TabIndex = 2;
            this.btnExitMap.Text = "Done";
            this.btnExitMap.UseVisualStyleBackColor = true;
            this.btnExitMap.Click += new System.EventHandler(this.btnExitMap_Click);
            // 
            // btnMapTableSnapshot
            // 
            this.btnMapTableSnapshot.BackColor = System.Drawing.Color.SkyBlue;
            this.btnMapTableSnapshot.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMapTableSnapshot.FlatAppearance.BorderSize = 2;
            this.btnMapTableSnapshot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMapTableSnapshot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMapTableSnapshot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMapTableSnapshot.Location = new System.Drawing.Point(216, 19);
            this.btnMapTableSnapshot.Name = "btnMapTableSnapshot";
            this.btnMapTableSnapshot.Size = new System.Drawing.Size(204, 70);
            this.btnMapTableSnapshot.TabIndex = 1;
            this.btnMapTableSnapshot.Text = "Take Snapshot\r\n(map + attribute table)";
            this.btnMapTableSnapshot.UseVisualStyleBackColor = false;
            // 
            // btnMapSnapshot
            // 
            this.btnMapSnapshot.BackColor = System.Drawing.Color.LimeGreen;
            this.btnMapSnapshot.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMapSnapshot.FlatAppearance.BorderSize = 2;
            this.btnMapSnapshot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnMapSnapshot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMapSnapshot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMapSnapshot.Location = new System.Drawing.Point(6, 19);
            this.btnMapSnapshot.Name = "btnMapSnapshot";
            this.btnMapSnapshot.Size = new System.Drawing.Size(204, 70);
            this.btnMapSnapshot.TabIndex = 0;
            this.btnMapSnapshot.Text = "Take Snapshot\r\n(map alone)";
            this.btnMapSnapshot.UseVisualStyleBackColor = false;
            this.btnMapSnapshot.Click += new System.EventHandler(this.btnMapSnapshot_Click);
            // 
            // spatialDockManager1
            // 
            this.spatialDockManager1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spatialDockManager1.BackColor = System.Drawing.Color.Transparent;
            this.spatialDockManager1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spatialDockManager1.Location = new System.Drawing.Point(12, 40);
            this.spatialDockManager1.Name = "spatialDockManager1";
            // 
            // spatialDockManager1.Panel1
            // 
            this.spatialDockManager1.Panel1.Controls.Add(this.Legend);
            // 
            // spatialDockManager1.Panel2
            // 
            this.spatialDockManager1.Panel2.Controls.Add(this.Map);
            this.spatialDockManager1.Size = new System.Drawing.Size(877, 428);
            this.spatialDockManager1.SplitterDistance = 291;
            this.spatialDockManager1.TabControl1 = null;
            this.spatialDockManager1.TabControl2 = null;
            this.spatialDockManager1.TabIndex = 0;
            // 
            // Legend
            // 
            this.Legend.BackColor = System.Drawing.Color.White;
            this.Legend.ControlRectangle = new System.Drawing.Rectangle(0, 0, 287, 424);
            this.Legend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Legend.DocumentRectangle = new System.Drawing.Rectangle(0, 0, 187, 428);
            this.Legend.HorizontalScrollEnabled = true;
            this.Legend.Indentation = 30;
            this.Legend.IsInitialized = false;
            this.Legend.Location = new System.Drawing.Point(0, 0);
            this.Legend.MinimumSize = new System.Drawing.Size(5, 5);
            this.Legend.Name = "Legend";
            this.Legend.ProgressHandler = null;
            this.Legend.ResetOnResize = false;
            this.Legend.SelectionFontColor = System.Drawing.Color.Black;
            this.Legend.SelectionHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.Legend.Size = new System.Drawing.Size(287, 424);
            this.Legend.TabIndex = 0;
            this.Legend.Text = "legend1";
            this.Legend.VerticalScrollEnabled = true;
            // 
            // Map
            // 
            this.Map.AllowDrop = true;
            this.Map.BackColor = System.Drawing.Color.White;
            this.Map.CollectAfterDraw = false;
            this.Map.CollisionDetection = false;
            this.Map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Map.ExtendBuffer = false;
            this.Map.FunctionMode = DotSpatial.Controls.FunctionMode.None;
            this.Map.IsBusy = false;
            this.Map.IsZoomedToMaxExtent = false;
            this.Map.Legend = null;
            this.Map.Location = new System.Drawing.Point(0, 0);
            this.Map.Name = "Map";
            this.Map.ProgressHandler = null;
            this.Map.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt;
            this.Map.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt;
            this.Map.RedrawLayersWhileResizing = false;
            this.Map.SelectionEnabled = true;
            this.Map.Size = new System.Drawing.Size(578, 424);
            this.Map.TabIndex = 0;
            this.Map.ZoomOutFartherThanMaxExtent = false;
            this.Map.SelectionChanged += new System.EventHandler(this.Map_SelectionChanged);
            // 
            // MapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(901, 588);
            this.Controls.Add(this.grpSnapshots);
            this.Controls.Add(this.MapToolStrip);
            this.Controls.Add(this.spatialDockManager1);
            this.DoubleBuffered = true;
            this.Name = "MapForm";
            this.Text = "MapForm";
            this.Load += new System.EventHandler(this.MapForm_Load);
            this.MapToolStrip.ResumeLayout(false);
            this.MapToolStrip.PerformLayout();
            this.grpSnapshots.ResumeLayout(false);
            this.spatialDockManager1.Panel1.ResumeLayout(false);
            this.spatialDockManager1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spatialDockManager1)).EndInit();
            this.spatialDockManager1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DotSpatial.Controls.SpatialDockManager spatialDockManager1;
        private DotSpatial.Controls.Legend Legend;
        private DotSpatial.Controls.Map Map;
        private System.Windows.Forms.ToolStrip MapToolStrip;
        private System.Windows.Forms.ToolStripButton btnClearMap;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnPan;
        private System.Windows.Forms.ToolStripButton btnZoomOut;
        private System.Windows.Forms.ToolStripButton btnZoomIn;
        private System.Windows.Forms.ToolStripButton btnZoomExtent;
        private System.Windows.Forms.ToolStripButton btnInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnSelect;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnShowAttributes;
        private System.Windows.Forms.GroupBox grpSnapshots;
        private System.Windows.Forms.Button btnExitMap;
        private System.Windows.Forms.Button btnMapTableSnapshot;
        private System.Windows.Forms.Button btnMapSnapshot;
        private System.Windows.Forms.Button btnAttributeSnapshop;
    }
}