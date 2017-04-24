namespace ShapeReport
{
    partial class SnapshotAttributeTable
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
            this.grpAttributeTableSelection = new System.Windows.Forms.GroupBox();
            this.btnEditSelectedRows = new System.Windows.Forms.Button();
            this.btnEditColumns = new System.Windows.Forms.Button();
            this.lblSelectLayer = new System.Windows.Forms.Label();
            this.cboLayers = new System.Windows.Forms.ComboBox();
            this.dataSelection = new System.Windows.Forms.DataGridView();
            this.btnTakeAttributeSnapshot = new System.Windows.Forms.Button();
            this.btnCancelAttributeSnapshot = new System.Windows.Forms.Button();
            this.grpAttributeTableSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSelection)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAttributeTableSelection
            // 
            this.grpAttributeTableSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAttributeTableSelection.Controls.Add(this.btnEditSelectedRows);
            this.grpAttributeTableSelection.Controls.Add(this.btnEditColumns);
            this.grpAttributeTableSelection.Controls.Add(this.lblSelectLayer);
            this.grpAttributeTableSelection.Controls.Add(this.cboLayers);
            this.grpAttributeTableSelection.Location = new System.Drawing.Point(12, 12);
            this.grpAttributeTableSelection.Name = "grpAttributeTableSelection";
            this.grpAttributeTableSelection.Size = new System.Drawing.Size(490, 82);
            this.grpAttributeTableSelection.TabIndex = 0;
            this.grpAttributeTableSelection.TabStop = false;
            this.grpAttributeTableSelection.Text = "Attribute Table Selection";
            // 
            // btnEditSelectedRows
            // 
            this.btnEditSelectedRows.Enabled = false;
            this.btnEditSelectedRows.Location = new System.Drawing.Point(218, 53);
            this.btnEditSelectedRows.Name = "btnEditSelectedRows";
            this.btnEditSelectedRows.Size = new System.Drawing.Size(130, 23);
            this.btnEditSelectedRows.TabIndex = 5;
            this.btnEditSelectedRows.Text = "Edit Selected Rows";
            this.btnEditSelectedRows.UseVisualStyleBackColor = true;
            this.btnEditSelectedRows.Click += new System.EventHandler(this.btnEditSelectedRows_Click);
            // 
            // btnEditColumns
            // 
            this.btnEditColumns.Enabled = false;
            this.btnEditColumns.Location = new System.Drawing.Point(354, 53);
            this.btnEditColumns.Name = "btnEditColumns";
            this.btnEditColumns.Size = new System.Drawing.Size(130, 23);
            this.btnEditColumns.TabIndex = 4;
            this.btnEditColumns.Text = "Edit Columns";
            this.btnEditColumns.UseVisualStyleBackColor = true;
            this.btnEditColumns.Click += new System.EventHandler(this.btnEditColumns_Click);
            // 
            // lblSelectLayer
            // 
            this.lblSelectLayer.AutoSize = true;
            this.lblSelectLayer.Location = new System.Drawing.Point(9, 38);
            this.lblSelectLayer.Name = "lblSelectLayer";
            this.lblSelectLayer.Size = new System.Drawing.Size(66, 13);
            this.lblSelectLayer.TabIndex = 1;
            this.lblSelectLayer.Text = "Select Layer";
            // 
            // cboLayers
            // 
            this.cboLayers.FormattingEnabled = true;
            this.cboLayers.Location = new System.Drawing.Point(9, 55);
            this.cboLayers.Name = "cboLayers";
            this.cboLayers.Size = new System.Drawing.Size(203, 21);
            this.cboLayers.TabIndex = 0;
            this.cboLayers.SelectedIndexChanged += new System.EventHandler(this.cboLayers_SelectedIndexChanged);
            // 
            // dataSelection
            // 
            this.dataSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataSelection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSelection.Location = new System.Drawing.Point(12, 100);
            this.dataSelection.Name = "dataSelection";
            this.dataSelection.Size = new System.Drawing.Size(490, 275);
            this.dataSelection.TabIndex = 1;
            // 
            // btnTakeAttributeSnapshot
            // 
            this.btnTakeAttributeSnapshot.BackColor = System.Drawing.Color.ForestGreen;
            this.btnTakeAttributeSnapshot.FlatAppearance.BorderSize = 2;
            this.btnTakeAttributeSnapshot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnTakeAttributeSnapshot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakeAttributeSnapshot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeAttributeSnapshot.Location = new System.Drawing.Point(148, 381);
            this.btnTakeAttributeSnapshot.Name = "btnTakeAttributeSnapshot";
            this.btnTakeAttributeSnapshot.Size = new System.Drawing.Size(354, 55);
            this.btnTakeAttributeSnapshot.TabIndex = 2;
            this.btnTakeAttributeSnapshot.Text = "Save Snapshot";
            this.btnTakeAttributeSnapshot.UseVisualStyleBackColor = false;
            this.btnTakeAttributeSnapshot.Click += new System.EventHandler(this.btnTakeAttributeSnapshot_Click);
            // 
            // btnCancelAttributeSnapshot
            // 
            this.btnCancelAttributeSnapshot.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelAttributeSnapshot.FlatAppearance.BorderSize = 2;
            this.btnCancelAttributeSnapshot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnCancelAttributeSnapshot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelAttributeSnapshot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAttributeSnapshot.Location = new System.Drawing.Point(12, 381);
            this.btnCancelAttributeSnapshot.Name = "btnCancelAttributeSnapshot";
            this.btnCancelAttributeSnapshot.Size = new System.Drawing.Size(130, 55);
            this.btnCancelAttributeSnapshot.TabIndex = 3;
            this.btnCancelAttributeSnapshot.Text = "Cancel";
            this.btnCancelAttributeSnapshot.UseVisualStyleBackColor = false;
            this.btnCancelAttributeSnapshot.Click += new System.EventHandler(this.btnCancelAttributeSnapshot_Click);
            // 
            // SnapshotAttributeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 448);
            this.Controls.Add(this.btnCancelAttributeSnapshot);
            this.Controls.Add(this.btnTakeAttributeSnapshot);
            this.Controls.Add(this.dataSelection);
            this.Controls.Add(this.grpAttributeTableSelection);
            this.Name = "SnapshotAttributeTable";
            this.Text = "SnapshotAttributeTable";
            this.Load += new System.EventHandler(this.SnapshotAttributeTable_Load);
            this.grpAttributeTableSelection.ResumeLayout(false);
            this.grpAttributeTableSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSelection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAttributeTableSelection;
        private System.Windows.Forms.Label lblSelectLayer;
        private System.Windows.Forms.ComboBox cboLayers;
        private System.Windows.Forms.Button btnEditColumns;
        private System.Windows.Forms.Button btnEditSelectedRows;
        private System.Windows.Forms.DataGridView dataSelection;
        private System.Windows.Forms.Button btnTakeAttributeSnapshot;
        private System.Windows.Forms.Button btnCancelAttributeSnapshot;
    }
}