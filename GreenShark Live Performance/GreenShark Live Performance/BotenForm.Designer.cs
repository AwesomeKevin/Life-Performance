namespace GreenShark_Live_Performance
{
    partial class BotenForm
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
            this.lbBoten = new System.Windows.Forms.ListBox();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.btnMaakAan = new System.Windows.Forms.Button();
            this.btnPasAan = new System.Windows.Forms.Button();
            this.tbLocatieY = new System.Windows.Forms.TextBox();
            this.lblMaximumSnelheid = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.tbType = new System.Windows.Forms.TextBox();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblBoot = new System.Windows.Forms.Label();
            this.cbBoot = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblMaximumAantalPersonen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbBoten
            // 
            this.lbBoten.FormattingEnabled = true;
            this.lbBoten.Location = new System.Drawing.Point(15, 171);
            this.lbBoten.Name = "lbBoten";
            this.lbBoten.Size = new System.Drawing.Size(264, 134);
            this.lbBoten.TabIndex = 33;
            this.lbBoten.SelectedIndexChanged += new System.EventHandler(this.lbMissies_SelectedIndexChanged);
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(177, 142);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(73, 23);
            this.btnVerwijder.TabIndex = 32;
            this.btnVerwijder.Text = "Verwijder";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            // 
            // btnMaakAan
            // 
            this.btnMaakAan.Location = new System.Drawing.Point(15, 142);
            this.btnMaakAan.Name = "btnMaakAan";
            this.btnMaakAan.Size = new System.Drawing.Size(75, 23);
            this.btnMaakAan.TabIndex = 31;
            this.btnMaakAan.Text = "Maak Aan";
            this.btnMaakAan.UseVisualStyleBackColor = true;
            // 
            // btnPasAan
            // 
            this.btnPasAan.Location = new System.Drawing.Point(96, 142);
            this.btnPasAan.Name = "btnPasAan";
            this.btnPasAan.Size = new System.Drawing.Size(75, 23);
            this.btnPasAan.TabIndex = 30;
            this.btnPasAan.Text = "Pas Aan";
            this.btnPasAan.UseVisualStyleBackColor = true;
            // 
            // tbLocatieY
            // 
            this.tbLocatieY.Location = new System.Drawing.Point(154, 85);
            this.tbLocatieY.Name = "tbLocatieY";
            this.tbLocatieY.Size = new System.Drawing.Size(121, 20);
            this.tbLocatieY.TabIndex = 29;
            // 
            // lblMaximumSnelheid
            // 
            this.lblMaximumSnelheid.AutoSize = true;
            this.lblMaximumSnelheid.Location = new System.Drawing.Point(12, 88);
            this.lblMaximumSnelheid.Name = "lblMaximumSnelheid";
            this.lblMaximumSnelheid.Size = new System.Drawing.Size(99, 13);
            this.lblMaximumSnelheid.TabIndex = 28;
            this.lblMaximumSnelheid.Text = "Maximum snelheid: ";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(12, 62);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(37, 13);
            this.lblType.TabIndex = 27;
            this.lblType.Text = "Type: ";
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(154, 59);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(121, 20);
            this.tbType.TabIndex = 25;
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(154, 33);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(121, 20);
            this.tbNaam.TabIndex = 21;
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(12, 36);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(41, 13);
            this.lblNaam.TabIndex = 20;
            this.lblNaam.Text = "Naam: ";
            // 
            // lblBoot
            // 
            this.lblBoot.AutoSize = true;
            this.lblBoot.Location = new System.Drawing.Point(12, 9);
            this.lblBoot.Name = "lblBoot";
            this.lblBoot.Size = new System.Drawing.Size(42, 13);
            this.lblBoot.TabIndex = 19;
            this.lblBoot.Text = "Missie: ";
            // 
            // cbBoot
            // 
            this.cbBoot.FormattingEnabled = true;
            this.cbBoot.Location = new System.Drawing.Point(154, 6);
            this.cbBoot.Name = "cbBoot";
            this.cbBoot.Size = new System.Drawing.Size(121, 21);
            this.cbBoot.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(154, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 35;
            // 
            // lblMaximumAantalPersonen
            // 
            this.lblMaximumAantalPersonen.AutoSize = true;
            this.lblMaximumAantalPersonen.Location = new System.Drawing.Point(12, 119);
            this.lblMaximumAantalPersonen.Name = "lblMaximumAantalPersonen";
            this.lblMaximumAantalPersonen.Size = new System.Drawing.Size(136, 13);
            this.lblMaximumAantalPersonen.TabIndex = 34;
            this.lblMaximumAantalPersonen.Text = "Maximum aantal personen: ";
            // 
            // BotenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 322);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblMaximumAantalPersonen);
            this.Controls.Add(this.lbBoten);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.btnMaakAan);
            this.Controls.Add(this.btnPasAan);
            this.Controls.Add(this.tbLocatieY);
            this.Controls.Add(this.lblMaximumSnelheid);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.tbNaam);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.lblBoot);
            this.Controls.Add(this.cbBoot);
            this.Name = "BotenForm";
            this.Text = "Boten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbBoten;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.Button btnMaakAan;
        private System.Windows.Forms.Button btnPasAan;
        private System.Windows.Forms.TextBox tbLocatieY;
        private System.Windows.Forms.Label lblMaximumSnelheid;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblBoot;
        private System.Windows.Forms.ComboBox cbBoot;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblMaximumAantalPersonen;
    }
}