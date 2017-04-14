namespace InfoShape
{
    partial class ColumnEditor
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
            this.lstAvailableColumns = new System.Windows.Forms.ListBox();
            this.lstSelectedColumns = new System.Windows.Forms.ListBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnDeselect = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnDeselectAll = new System.Windows.Forms.Button();
            this.lblAvailableColumns = new System.Windows.Forms.Label();
            this.lblSelectedColumns = new System.Windows.Forms.Label();
            this.btnFinishColumns = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAvailableColumns
            // 
            this.lstAvailableColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstAvailableColumns.FormattingEnabled = true;
            this.lstAvailableColumns.Location = new System.Drawing.Point(12, 56);
            this.lstAvailableColumns.Name = "lstAvailableColumns";
            this.lstAvailableColumns.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstAvailableColumns.Size = new System.Drawing.Size(305, 355);
            this.lstAvailableColumns.TabIndex = 0;
            this.lstAvailableColumns.DoubleClick += new System.EventHandler(this.lstAvailableColumns_DoubleClick);
            // 
            // lstSelectedColumns
            // 
            this.lstSelectedColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSelectedColumns.FormattingEnabled = true;
            this.lstSelectedColumns.Location = new System.Drawing.Point(416, 56);
            this.lstSelectedColumns.Name = "lstSelectedColumns";
            this.lstSelectedColumns.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstSelectedColumns.Size = new System.Drawing.Size(305, 355);
            this.lstSelectedColumns.TabIndex = 1;
            this.lstSelectedColumns.DoubleClick += new System.EventHandler(this.lstSelectedColumns_DoubleClick);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(329, 86);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "->";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnDeselect
            // 
            this.btnDeselect.Location = new System.Drawing.Point(329, 115);
            this.btnDeselect.Name = "btnDeselect";
            this.btnDeselect.Size = new System.Drawing.Size(75, 23);
            this.btnDeselect.TabIndex = 3;
            this.btnDeselect.Text = "<-";
            this.btnDeselect.UseVisualStyleBackColor = true;
            this.btnDeselect.Click += new System.EventHandler(this.btnDeselect_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(329, 218);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAll.TabIndex = 4;
            this.btnSelectAll.Text = "all ->";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnDeselectAll
            // 
            this.btnDeselectAll.Location = new System.Drawing.Point(329, 247);
            this.btnDeselectAll.Name = "btnDeselectAll";
            this.btnDeselectAll.Size = new System.Drawing.Size(75, 23);
            this.btnDeselectAll.TabIndex = 5;
            this.btnDeselectAll.Text = "<- all";
            this.btnDeselectAll.UseVisualStyleBackColor = true;
            this.btnDeselectAll.Click += new System.EventHandler(this.btnDeselectAll_Click);
            // 
            // lblAvailableColumns
            // 
            this.lblAvailableColumns.AutoSize = true;
            this.lblAvailableColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableColumns.Location = new System.Drawing.Point(58, 15);
            this.lblAvailableColumns.Name = "lblAvailableColumns";
            this.lblAvailableColumns.Size = new System.Drawing.Size(212, 29);
            this.lblAvailableColumns.TabIndex = 6;
            this.lblAvailableColumns.Text = "Available Columns";
            // 
            // lblSelectedColumns
            // 
            this.lblSelectedColumns.AutoSize = true;
            this.lblSelectedColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedColumns.Location = new System.Drawing.Point(463, 15);
            this.lblSelectedColumns.Name = "lblSelectedColumns";
            this.lblSelectedColumns.Size = new System.Drawing.Size(210, 29);
            this.lblSelectedColumns.TabIndex = 7;
            this.lblSelectedColumns.Text = "Selected Columns";
            // 
            // btnFinishColumns
            // 
            this.btnFinishColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinishColumns.Location = new System.Drawing.Point(329, 388);
            this.btnFinishColumns.Name = "btnFinishColumns";
            this.btnFinishColumns.Size = new System.Drawing.Size(75, 23);
            this.btnFinishColumns.TabIndex = 8;
            this.btnFinishColumns.Text = "Done";
            this.btnFinishColumns.UseVisualStyleBackColor = true;
            this.btnFinishColumns.Click += new System.EventHandler(this.btnFinishColumns_Click);
            // 
            // ColumnEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 417);
            this.Controls.Add(this.btnFinishColumns);
            this.Controls.Add(this.lblSelectedColumns);
            this.Controls.Add(this.lblAvailableColumns);
            this.Controls.Add(this.btnDeselectAll);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.btnDeselect);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lstSelectedColumns);
            this.Controls.Add(this.lstAvailableColumns);
            this.MinimizeBox = false;
            this.Name = "ColumnEditor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Column Selection";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ColumnEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAvailableColumns;
        private System.Windows.Forms.ListBox lstSelectedColumns;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnDeselect;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnDeselectAll;
        private System.Windows.Forms.Label lblAvailableColumns;
        private System.Windows.Forms.Label lblSelectedColumns;
        private System.Windows.Forms.Button btnFinishColumns;
    }
}