namespace THWeddingPlanner
{
    partial class ManageTiers
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
            this.dgvTiers = new System.Windows.Forms.DataGridView();
            this.Naam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Volgorde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTiers
            // 
            this.dgvTiers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naam,
            this.Volgorde});
            this.dgvTiers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTiers.Location = new System.Drawing.Point(0, 0);
            this.dgvTiers.Name = "dgvTiers";
            this.dgvTiers.RowHeadersVisible = false;
            this.dgvTiers.Size = new System.Drawing.Size(545, 313);
            this.dgvTiers.TabIndex = 0;
            this.dgvTiers.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvTiers_RowsAdded);
            this.dgvTiers.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvTiers_RowsRemoved);
            // 
            // Naam
            // 
            this.Naam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Naam.DataPropertyName = "Naam";
            this.Naam.HeaderText = "Naam";
            this.Naam.Name = "Naam";
            // 
            // Volgorde
            // 
            this.Volgorde.DataPropertyName = "Volgorde";
            this.Volgorde.HeaderText = "Volgorde";
            this.Volgorde.Name = "Volgorde";
            // 
            // ManageTiers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 313);
            this.Controls.Add(this.dgvTiers);
            this.Name = "ManageTiers";
            this.Text = "ManageTiers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageTiers_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTiers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Volgorde;
    }
}