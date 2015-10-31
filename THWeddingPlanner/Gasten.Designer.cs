namespace THWeddingPlanner
{
    partial class Gasten
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gasten));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.dgvGasten = new System.Windows.Forms.DataGridView();
            this.weddingPlanData = new THWeddingPlanner.Data.WeddingPlan();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAddGast = new System.Windows.Forms.ToolStripButton();
            this.Voornaam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Achternaam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DieetAllergie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bijzonderheden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsKind = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.RightToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGasten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weddingPlanData)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dgvGasten);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(502, 381);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            // 
            // toolStripContainer1.RightToolStripPanel
            // 
            this.toolStripContainer1.RightToolStripPanel.Controls.Add(this.toolStrip1);
            this.toolStripContainer1.Size = new System.Drawing.Size(586, 406);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // dgvGasten
            // 
            this.dgvGasten.AllowUserToAddRows = false;
            this.dgvGasten.AllowUserToDeleteRows = false;
            this.dgvGasten.AllowUserToOrderColumns = true;
            this.dgvGasten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGasten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Voornaam,
            this.Achternaam,
            this.DieetAllergie,
            this.Bijzonderheden,
            this.IsKind});
            this.dgvGasten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGasten.Location = new System.Drawing.Point(0, 0);
            this.dgvGasten.Name = "dgvGasten";
            this.dgvGasten.RowHeadersVisible = false;
            this.dgvGasten.Size = new System.Drawing.Size(502, 381);
            this.dgvGasten.TabIndex = 0;
            // 
            // weddingPlanData
            // 
            this.weddingPlanData.DataSetName = "WeddingPlan";
            this.weddingPlanData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddGast});
            this.toolStrip1.Location = new System.Drawing.Point(0, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(84, 33);
            this.toolStrip1.TabIndex = 0;
            // 
            // tsbAddGast
            // 
            this.tsbAddGast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAddGast.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddGast.Image")));
            this.tsbAddGast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddGast.Name = "tsbAddGast";
            this.tsbAddGast.Size = new System.Drawing.Size(82, 19);
            this.tsbAddGast.Text = "Voeg gast toe";
            this.tsbAddGast.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsbAddGast.ToolTipText = "Voeg gast toe";
            this.tsbAddGast.Click += new System.EventHandler(this.tsbAddGast_Click);
            // 
            // Voornaam
            // 
            this.Voornaam.DataPropertyName = "Voornaam";
            this.Voornaam.HeaderText = "Voornaam";
            this.Voornaam.Name = "Voornaam";
            // 
            // Achternaam
            // 
            this.Achternaam.DataPropertyName = "Achternaam";
            this.Achternaam.HeaderText = "Achternaam";
            this.Achternaam.Name = "Achternaam";
            // 
            // DieetAllergie
            // 
            this.DieetAllergie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DieetAllergie.DataPropertyName = "DieetAllergie";
            this.DieetAllergie.HeaderText = "Dieet/Allergie";
            this.DieetAllergie.Name = "DieetAllergie";
            this.DieetAllergie.Width = 96;
            // 
            // Bijzonderheden
            // 
            this.Bijzonderheden.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Bijzonderheden.DataPropertyName = "Bijzonderheden";
            this.Bijzonderheden.HeaderText = "Bijzonderheden";
            this.Bijzonderheden.Name = "Bijzonderheden";
            // 
            // IsKind
            // 
            this.IsKind.DataPropertyName = "IsKind";
            this.IsKind.HeaderText = "Kind?";
            this.IsKind.Name = "IsKind";
            // 
            // Gasten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 406);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Gasten";
            this.Text = "Gasten";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.RightToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.RightToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGasten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weddingPlanData)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAddGast;
        private System.Windows.Forms.DataGridView dgvGasten;
        private Data.WeddingPlan weddingPlanData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Voornaam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Achternaam;
        private System.Windows.Forms.DataGridViewTextBoxColumn DieetAllergie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bijzonderheden;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsKind;
    }
}