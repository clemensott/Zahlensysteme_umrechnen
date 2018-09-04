namespace Zahlensysteme_umrechnen
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_von = new System.Windows.Forms.Label();
            this.lbl_von_sys = new System.Windows.Forms.Label();
            this.labl_von_zahl = new System.Windows.Forms.Label();
            this.lbl_zu = new System.Windows.Forms.Label();
            this.lbl_zu_sys = new System.Windows.Forms.Label();
            this.lbl_zu_zahl = new System.Windows.Forms.Label();
            this.txb_von = new System.Windows.Forms.TextBox();
            this.txb_zu = new System.Windows.Forms.TextBox();
            this.dud_von = new System.Windows.Forms.DomainUpDown();
            this.dud_zu = new System.Windows.Forms.DomainUpDown();
            this.lbl_fehler = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_von
            // 
            this.lbl_von.AutoSize = true;
            this.lbl_von.Location = new System.Drawing.Point(25, 22);
            this.lbl_von.Name = "lbl_von";
            this.lbl_von.Size = new System.Drawing.Size(26, 13);
            this.lbl_von.TabIndex = 0;
            this.lbl_von.Text = "Von";
            // 
            // lbl_von_sys
            // 
            this.lbl_von_sys.AutoSize = true;
            this.lbl_von_sys.Location = new System.Drawing.Point(28, 55);
            this.lbl_von_sys.Name = "lbl_von_sys";
            this.lbl_von_sys.Size = new System.Drawing.Size(72, 13);
            this.lbl_von_sys.TabIndex = 1;
            this.lbl_von_sys.Text = "Zahlensystem";
            // 
            // labl_von_zahl
            // 
            this.labl_von_zahl.AutoSize = true;
            this.labl_von_zahl.Location = new System.Drawing.Point(130, 55);
            this.labl_von_zahl.Name = "labl_von_zahl";
            this.labl_von_zahl.Size = new System.Drawing.Size(28, 13);
            this.labl_von_zahl.TabIndex = 2;
            this.labl_von_zahl.Text = "Zahl";
            // 
            // lbl_zu
            // 
            this.lbl_zu.AutoSize = true;
            this.lbl_zu.Location = new System.Drawing.Point(28, 131);
            this.lbl_zu.Name = "lbl_zu";
            this.lbl_zu.Size = new System.Drawing.Size(20, 13);
            this.lbl_zu.TabIndex = 3;
            this.lbl_zu.Text = "Zu";
            // 
            // lbl_zu_sys
            // 
            this.lbl_zu_sys.AutoSize = true;
            this.lbl_zu_sys.Location = new System.Drawing.Point(31, 166);
            this.lbl_zu_sys.Name = "lbl_zu_sys";
            this.lbl_zu_sys.Size = new System.Drawing.Size(72, 13);
            this.lbl_zu_sys.TabIndex = 4;
            this.lbl_zu_sys.Text = "Zahlensystem";
            // 
            // lbl_zu_zahl
            // 
            this.lbl_zu_zahl.AutoSize = true;
            this.lbl_zu_zahl.Location = new System.Drawing.Point(130, 166);
            this.lbl_zu_zahl.Name = "lbl_zu_zahl";
            this.lbl_zu_zahl.Size = new System.Drawing.Size(28, 13);
            this.lbl_zu_zahl.TabIndex = 5;
            this.lbl_zu_zahl.Text = "Zahl";
            // 
            // txb_von
            // 
            this.txb_von.Location = new System.Drawing.Point(133, 72);
            this.txb_von.Name = "txb_von";
            this.txb_von.Size = new System.Drawing.Size(131, 20);
            this.txb_von.TabIndex = 6;
            this.txb_von.TextChanged += new System.EventHandler(this.txb_von_TextChanged);
            // 
            // txb_zu
            // 
            this.txb_zu.Enabled = false;
            this.txb_zu.Location = new System.Drawing.Point(133, 183);
            this.txb_zu.Name = "txb_zu";
            this.txb_zu.Size = new System.Drawing.Size(131, 20);
            this.txb_zu.TabIndex = 7;
            // 
            // dud_von
            // 
            this.dud_von.Items.Add("16");
            this.dud_von.Items.Add("15");
            this.dud_von.Items.Add("14");
            this.dud_von.Items.Add("13");
            this.dud_von.Items.Add("12");
            this.dud_von.Items.Add("11");
            this.dud_von.Items.Add("10");
            this.dud_von.Items.Add("9");
            this.dud_von.Items.Add("8");
            this.dud_von.Items.Add("7");
            this.dud_von.Items.Add("6");
            this.dud_von.Items.Add("5");
            this.dud_von.Items.Add("4");
            this.dud_von.Items.Add("3");
            this.dud_von.Items.Add("2");
            this.dud_von.Location = new System.Drawing.Point(31, 72);
            this.dud_von.Name = "dud_von";
            this.dud_von.Size = new System.Drawing.Size(69, 20);
            this.dud_von.TabIndex = 8;
            this.dud_von.TextChanged += new System.EventHandler(this.dud_von_TextChanged);
            // 
            // dud_zu
            // 
            this.dud_zu.Items.Add("16");
            this.dud_zu.Items.Add("15");
            this.dud_zu.Items.Add("14");
            this.dud_zu.Items.Add("13");
            this.dud_zu.Items.Add("12");
            this.dud_zu.Items.Add("11");
            this.dud_zu.Items.Add("10");
            this.dud_zu.Items.Add("9");
            this.dud_zu.Items.Add("8");
            this.dud_zu.Items.Add("7");
            this.dud_zu.Items.Add("6");
            this.dud_zu.Items.Add("5");
            this.dud_zu.Items.Add("4");
            this.dud_zu.Items.Add("3");
            this.dud_zu.Items.Add("2");
            this.dud_zu.Location = new System.Drawing.Point(34, 183);
            this.dud_zu.Name = "dud_zu";
            this.dud_zu.Size = new System.Drawing.Size(66, 20);
            this.dud_zu.TabIndex = 9;
            this.dud_zu.TextChanged += new System.EventHandler(this.dud_zu_TextChanged);
            // 
            // lbl_fehler
            // 
            this.lbl_fehler.ForeColor = System.Drawing.Color.Red;
            this.lbl_fehler.Location = new System.Drawing.Point(1, 217);
            this.lbl_fehler.Name = "lbl_fehler";
            this.lbl_fehler.Size = new System.Drawing.Size(283, 23);
            this.lbl_fehler.TabIndex = 10;
            this.lbl_fehler.Text = "Fehler";
            this.lbl_fehler.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_fehler.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lbl_fehler);
            this.Controls.Add(this.dud_zu);
            this.Controls.Add(this.dud_von);
            this.Controls.Add(this.txb_zu);
            this.Controls.Add(this.txb_von);
            this.Controls.Add(this.lbl_zu_zahl);
            this.Controls.Add(this.lbl_zu_sys);
            this.Controls.Add(this.lbl_zu);
            this.Controls.Add(this.labl_von_zahl);
            this.Controls.Add(this.lbl_von_sys);
            this.Controls.Add(this.lbl_von);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Zahlensystem umrechnen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_von;
        private System.Windows.Forms.Label lbl_von_sys;
        private System.Windows.Forms.Label labl_von_zahl;
        private System.Windows.Forms.Label lbl_zu;
        private System.Windows.Forms.Label lbl_zu_sys;
        private System.Windows.Forms.Label lbl_zu_zahl;
        private System.Windows.Forms.TextBox txb_von;
        private System.Windows.Forms.TextBox txb_zu;
        private System.Windows.Forms.DomainUpDown dud_von;
        private System.Windows.Forms.DomainUpDown dud_zu;
        private System.Windows.Forms.Label lbl_fehler;
    }
}

