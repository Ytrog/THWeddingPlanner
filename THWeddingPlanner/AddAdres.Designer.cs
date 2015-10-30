namespace THWeddingPlanner
{
    partial class AddAdres
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
            this.components = new System.ComponentModel.Container();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStraatnaam = new System.Windows.Forms.TextBox();
            this.txtPlaats = new System.Windows.Forms.TextBox();
            this.txtLand = new System.Windows.Forms.TextBox();
            this.txtPostcode = new System.Windows.Forms.MaskedTextBox();
            this.txtHuisnummer = new System.Windows.Forms.MaskedTextBox();
            this.txtToevoeging = new System.Windows.Forms.MaskedTextBox();
            this.tipError = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(4, 165);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(86, 165);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Straatnaam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Huisnummer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Toevoeging";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Postcode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Plaats";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Land";
            // 
            // txtStraatnaam
            // 
            this.txtStraatnaam.Location = new System.Drawing.Point(84, 9);
            this.txtStraatnaam.Name = "txtStraatnaam";
            this.txtStraatnaam.Size = new System.Drawing.Size(277, 20);
            this.txtStraatnaam.TabIndex = 0;
            // 
            // txtPlaats
            // 
            this.txtPlaats.Location = new System.Drawing.Point(84, 113);
            this.txtPlaats.Name = "txtPlaats";
            this.txtPlaats.Size = new System.Drawing.Size(277, 20);
            this.txtPlaats.TabIndex = 4;
            // 
            // txtLand
            // 
            this.txtLand.Location = new System.Drawing.Point(84, 139);
            this.txtLand.Name = "txtLand";
            this.txtLand.Size = new System.Drawing.Size(277, 20);
            this.txtLand.TabIndex = 5;
            this.txtLand.Text = "Nederland";
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(84, 87);
            this.txtPostcode.Mask = "0000 AA";
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(100, 20);
            this.txtPostcode.TabIndex = 3;
            // 
            // txtHuisnummer
            // 
            this.txtHuisnummer.AsciiOnly = true;
            this.txtHuisnummer.Location = new System.Drawing.Point(84, 35);
            this.txtHuisnummer.Name = "txtHuisnummer";
            this.txtHuisnummer.Size = new System.Drawing.Size(100, 20);
            this.txtHuisnummer.TabIndex = 1;
            this.txtHuisnummer.Validating += new System.ComponentModel.CancelEventHandler(this.txtHuisnummer_Validating);
            // 
            // txtToevoeging
            // 
            this.txtToevoeging.AsciiOnly = true;
            this.txtToevoeging.Location = new System.Drawing.Point(86, 61);
            this.txtToevoeging.Mask = "A";
            this.txtToevoeging.Name = "txtToevoeging";
            this.txtToevoeging.Size = new System.Drawing.Size(98, 20);
            this.txtToevoeging.TabIndex = 2;
            // 
            // AddAdres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 201);
            this.Controls.Add(this.txtToevoeging);
            this.Controls.Add(this.txtHuisnummer);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.txtLand);
            this.Controls.Add(this.txtPlaats);
            this.Controls.Add(this.txtStraatnaam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "AddAdres";
            this.Text = "AddAdres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStraatnaam;
        private System.Windows.Forms.TextBox txtPlaats;
        private System.Windows.Forms.TextBox txtLand;
        private System.Windows.Forms.MaskedTextBox txtPostcode;
        private System.Windows.Forms.MaskedTextBox txtHuisnummer;
        private System.Windows.Forms.MaskedTextBox txtToevoeging;
        private System.Windows.Forms.ToolTip tipError;
    }
}