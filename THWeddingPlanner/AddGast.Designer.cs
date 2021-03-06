﻿namespace THWeddingPlanner
{
    partial class AddGast
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
            this.txtVoornaam = new System.Windows.Forms.TextBox();
            this.txtAchternaam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAdres = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddAddress = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBijzonderheden = new System.Windows.Forms.TextBox();
            this.txtDieet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTier = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbKind = new System.Windows.Forms.CheckBox();
            this.btnManageTiers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVoornaam
            // 
            this.txtVoornaam.Location = new System.Drawing.Point(82, 29);
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.Size = new System.Drawing.Size(396, 20);
            this.txtVoornaam.TabIndex = 0;
            // 
            // txtAchternaam
            // 
            this.txtAchternaam.Location = new System.Drawing.Point(82, 55);
            this.txtAchternaam.Name = "txtAchternaam";
            this.txtAchternaam.Size = new System.Drawing.Size(396, 20);
            this.txtAchternaam.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Voornaam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Achternaam";
            // 
            // cmbAdres
            // 
            this.cmbAdres.FormattingEnabled = true;
            this.cmbAdres.Location = new System.Drawing.Point(82, 82);
            this.cmbAdres.Name = "cmbAdres";
            this.cmbAdres.Size = new System.Drawing.Size(276, 21);
            this.cmbAdres.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Adres";
            // 
            // btnAddAddress
            // 
            this.btnAddAddress.Location = new System.Drawing.Point(364, 82);
            this.btnAddAddress.Name = "btnAddAddress";
            this.btnAddAddress.Size = new System.Drawing.Size(114, 23);
            this.btnAddAddress.TabIndex = 3;
            this.btnAddAddress.Text = "Voeg adres toe";
            this.btnAddAddress.UseVisualStyleBackColor = true;
            this.btnAddAddress.Click += new System.EventHandler(this.btnAddAddress_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Bijzonderheden";
            // 
            // txtBijzonderheden
            // 
            this.txtBijzonderheden.Location = new System.Drawing.Point(19, 327);
            this.txtBijzonderheden.Multiline = true;
            this.txtBijzonderheden.Name = "txtBijzonderheden";
            this.txtBijzonderheden.Size = new System.Drawing.Size(451, 116);
            this.txtBijzonderheden.TabIndex = 8;
            // 
            // txtDieet
            // 
            this.txtDieet.Location = new System.Drawing.Point(19, 192);
            this.txtDieet.Multiline = true;
            this.txtDieet.Name = "txtDieet";
            this.txtDieet.Size = new System.Drawing.Size(451, 116);
            this.txtDieet.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Dieet/Allergie";
            // 
            // cmbTier
            // 
            this.cmbTier.FormattingEnabled = true;
            this.cmbTier.Location = new System.Drawing.Point(81, 152);
            this.cmbTier.Name = "cmbTier";
            this.cmbTier.Size = new System.Drawing.Size(277, 21);
            this.cmbTier.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Uitnodigen voor";
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(19, 452);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 19;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(101, 452);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cbKind
            // 
            this.cbKind.AutoSize = true;
            this.cbKind.Location = new System.Drawing.Point(19, 116);
            this.cbKind.Name = "cbKind";
            this.cbKind.Size = new System.Drawing.Size(53, 17);
            this.cbKind.TabIndex = 4;
            this.cbKind.Text = "Kind?";
            this.cbKind.UseVisualStyleBackColor = true;
            // 
            // btnManageTiers
            // 
            this.btnManageTiers.Location = new System.Drawing.Point(365, 149);
            this.btnManageTiers.Name = "btnManageTiers";
            this.btnManageTiers.Size = new System.Drawing.Size(113, 23);
            this.btnManageTiers.TabIndex = 6;
            this.btnManageTiers.Text = "Beheer niveaus";
            this.btnManageTiers.UseVisualStyleBackColor = true;
            this.btnManageTiers.Click += new System.EventHandler(this.btnManageTiers_Click);
            // 
            // AddGast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 487);
            this.Controls.Add(this.btnManageTiers);
            this.Controls.Add(this.cbKind);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbTier);
            this.Controls.Add(this.txtDieet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBijzonderheden);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAddAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbAdres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAchternaam);
            this.Controls.Add(this.txtVoornaam);
            this.Name = "AddGast";
            this.Text = "Voeg gast toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.TextBox txtAchternaam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAdres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBijzonderheden;
        private System.Windows.Forms.TextBox txtDieet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTier;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox cbKind;
        private System.Windows.Forms.Button btnManageTiers;
    }
}