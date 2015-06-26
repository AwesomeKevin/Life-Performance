namespace GreenShark_Live_Performance
{
    partial class RapportageForm
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
            this.lbMissies = new System.Windows.Forms.ListBox();
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
            this.SuspendLayout();
            // 
            // lbMissies
            // 
            this.lbMissies.FormattingEnabled = true;
            this.lbMissies.Location = new System.Drawing.Point(15, 157);
            this.lbMissies.Name = "lbMissies";
            this.lbMissies.Size = new System.Drawing.Size(235, 134);
            this.lbMissies.TabIndex = 47;
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(177, 111);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(73, 40);
            this.btnVerwijder.TabIndex = 46;
            this.btnVerwijder.Text = "Voeg meting toe";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            // 
            // btnMaakAan
            // 
            this.btnMaakAan.Location = new System.Drawing.Point(15, 111);
            this.btnMaakAan.Name = "btnMaakAan";
            this.btnMaakAan.Size = new System.Drawing.Size(75, 40);
            this.btnMaakAan.TabIndex = 45;
            this.btnMaakAan.Text = "Voeg verslag toe";
            this.btnMaakAan.UseVisualStyleBackColor = true;
            // 
            // btnPasAan
            // 
            this.btnPasAan.Location = new System.Drawing.Point(96, 111);
            this.btnPasAan.Name = "btnPasAan";
            this.btnPasAan.Size = new System.Drawing.Size(75, 40);
            this.btnPasAan.TabIndex = 44;
            this.btnPasAan.Text = "Voeg incident toe";
            this.btnPasAan.UseVisualStyleBackColor = true;
            // 
            // tbLocatieY
            // 
            this.tbLocatieY.Location = new System.Drawing.Point(69, 85);
            this.tbLocatieY.Name = "tbLocatieY";
            this.tbLocatieY.Size = new System.Drawing.Size(181, 20);
            this.tbLocatieY.TabIndex = 43;
            // 
            // lblMaximumSnelheid
            // 
            this.lblMaximumSnelheid.AutoSize = true;
            this.lblMaximumSnelheid.Location = new System.Drawing.Point(12, 88);
            this.lblMaximumSnelheid.Name = "lblMaximumSnelheid";
            this.lblMaximumSnelheid.Size = new System.Drawing.Size(45, 13);
            this.lblMaximumSnelheid.TabIndex = 42;
            this.lblMaximumSnelheid.Text = "Meting: ";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(12, 62);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(51, 13);
            this.lblType.TabIndex = 41;
            this.lblType.Text = "Incident: ";
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(69, 59);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(181, 20);
            this.tbType.TabIndex = 40;
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(69, 33);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(181, 20);
            this.tbNaam.TabIndex = 39;
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(12, 36);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(48, 13);
            this.lblNaam.TabIndex = 38;
            this.lblNaam.Text = "Verslag: ";
            // 
            // lblBoot
            // 
            this.lblBoot.AutoSize = true;
            this.lblBoot.Location = new System.Drawing.Point(12, 9);
            this.lblBoot.Name = "lblBoot";
            this.lblBoot.Size = new System.Drawing.Size(42, 13);
            this.lblBoot.TabIndex = 37;
            this.lblBoot.Text = "Missie: ";
            // 
            // cbBoot
            // 
            this.cbBoot.FormattingEnabled = true;
            this.cbBoot.Location = new System.Drawing.Point(69, 6);
            this.cbBoot.Name = "cbBoot";
            this.cbBoot.Size = new System.Drawing.Size(181, 21);
            this.cbBoot.TabIndex = 36;
            // 
            // RapportageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 311);
            this.Controls.Add(this.lbMissies);
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
            this.Name = "RapportageForm";
            this.Text = "Rapportage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMissies;
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
    }
}