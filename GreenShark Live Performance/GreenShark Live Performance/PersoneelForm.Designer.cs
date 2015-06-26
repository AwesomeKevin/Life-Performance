namespace GreenShark_Live_Performance
{
    partial class PersoneelForm
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
            this.lbPersoneel = new System.Windows.Forms.ListBox();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.btnMaakAan = new System.Windows.Forms.Button();
            this.btnPasAan = new System.Windows.Forms.Button();
            this.lblAchternaam = new System.Windows.Forms.Label();
            this.tbAchternaam = new System.Windows.Forms.TextBox();
            this.lblGeboortedatum = new System.Windows.Forms.Label();
            this.dtpGeboortedatum = new System.Windows.Forms.DateTimePicker();
            this.tbVoornaam = new System.Windows.Forms.TextBox();
            this.lblVoornaam = new System.Windows.Forms.Label();
            this.lblMedewerker = new System.Windows.Forms.Label();
            this.cbMederwerkers = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbPersoneel
            // 
            this.lbPersoneel.FormattingEnabled = true;
            this.lbPersoneel.Location = new System.Drawing.Point(12, 152);
            this.lbPersoneel.Name = "lbPersoneel";
            this.lbPersoneel.Size = new System.Drawing.Size(290, 134);
            this.lbPersoneel.TabIndex = 33;
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(175, 123);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(73, 23);
            this.btnVerwijder.TabIndex = 32;
            this.btnVerwijder.Text = "Verwijder";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            // 
            // btnMaakAan
            // 
            this.btnMaakAan.Location = new System.Drawing.Point(13, 123);
            this.btnMaakAan.Name = "btnMaakAan";
            this.btnMaakAan.Size = new System.Drawing.Size(75, 23);
            this.btnMaakAan.TabIndex = 31;
            this.btnMaakAan.Text = "Maak Aan";
            this.btnMaakAan.UseVisualStyleBackColor = true;
            // 
            // btnPasAan
            // 
            this.btnPasAan.Location = new System.Drawing.Point(94, 123);
            this.btnPasAan.Name = "btnPasAan";
            this.btnPasAan.Size = new System.Drawing.Size(75, 23);
            this.btnPasAan.TabIndex = 30;
            this.btnPasAan.Text = "Pas Aan";
            this.btnPasAan.UseVisualStyleBackColor = true;
            // 
            // lblAchternaam
            // 
            this.lblAchternaam.AutoSize = true;
            this.lblAchternaam.Location = new System.Drawing.Point(10, 66);
            this.lblAchternaam.Name = "lblAchternaam";
            this.lblAchternaam.Size = new System.Drawing.Size(70, 13);
            this.lblAchternaam.TabIndex = 26;
            this.lblAchternaam.Text = "Achternaam: ";
            // 
            // tbAchternaam
            // 
            this.tbAchternaam.Location = new System.Drawing.Point(102, 63);
            this.tbAchternaam.Name = "tbAchternaam";
            this.tbAchternaam.Size = new System.Drawing.Size(200, 20);
            this.tbAchternaam.TabIndex = 24;
            // 
            // lblGeboortedatum
            // 
            this.lblGeboortedatum.AutoSize = true;
            this.lblGeboortedatum.Location = new System.Drawing.Point(10, 95);
            this.lblGeboortedatum.Name = "lblGeboortedatum";
            this.lblGeboortedatum.Size = new System.Drawing.Size(86, 13);
            this.lblGeboortedatum.TabIndex = 23;
            this.lblGeboortedatum.Text = "Geboortedatum: ";
            // 
            // dtpGeboortedatum
            // 
            this.dtpGeboortedatum.Location = new System.Drawing.Point(102, 89);
            this.dtpGeboortedatum.Name = "dtpGeboortedatum";
            this.dtpGeboortedatum.Size = new System.Drawing.Size(200, 20);
            this.dtpGeboortedatum.TabIndex = 22;
            // 
            // tbVoornaam
            // 
            this.tbVoornaam.Location = new System.Drawing.Point(102, 37);
            this.tbVoornaam.Name = "tbVoornaam";
            this.tbVoornaam.Size = new System.Drawing.Size(200, 20);
            this.tbVoornaam.TabIndex = 21;
            // 
            // lblVoornaam
            // 
            this.lblVoornaam.AutoSize = true;
            this.lblVoornaam.Location = new System.Drawing.Point(10, 40);
            this.lblVoornaam.Name = "lblVoornaam";
            this.lblVoornaam.Size = new System.Drawing.Size(61, 13);
            this.lblVoornaam.TabIndex = 20;
            this.lblVoornaam.Text = "Voornaam: ";
            // 
            // lblMedewerker
            // 
            this.lblMedewerker.AutoSize = true;
            this.lblMedewerker.Location = new System.Drawing.Point(10, 13);
            this.lblMedewerker.Name = "lblMedewerker";
            this.lblMedewerker.Size = new System.Drawing.Size(72, 13);
            this.lblMedewerker.TabIndex = 19;
            this.lblMedewerker.Text = "Medewerker: ";
            // 
            // cbMederwerkers
            // 
            this.cbMederwerkers.FormattingEnabled = true;
            this.cbMederwerkers.Location = new System.Drawing.Point(102, 10);
            this.cbMederwerkers.Name = "cbMederwerkers";
            this.cbMederwerkers.Size = new System.Drawing.Size(200, 21);
            this.cbMederwerkers.TabIndex = 18;
            // 
            // PersoneelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 305);
            this.Controls.Add(this.lbPersoneel);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.btnMaakAan);
            this.Controls.Add(this.btnPasAan);
            this.Controls.Add(this.lblAchternaam);
            this.Controls.Add(this.tbAchternaam);
            this.Controls.Add(this.lblGeboortedatum);
            this.Controls.Add(this.dtpGeboortedatum);
            this.Controls.Add(this.tbVoornaam);
            this.Controls.Add(this.lblVoornaam);
            this.Controls.Add(this.lblMedewerker);
            this.Controls.Add(this.cbMederwerkers);
            this.Name = "PersoneelForm";
            this.Text = "Personeel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPersoneel;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.Button btnMaakAan;
        private System.Windows.Forms.Button btnPasAan;
        private System.Windows.Forms.Label lblAchternaam;
        private System.Windows.Forms.TextBox tbAchternaam;
        private System.Windows.Forms.Label lblGeboortedatum;
        private System.Windows.Forms.DateTimePicker dtpGeboortedatum;
        private System.Windows.Forms.TextBox tbVoornaam;
        private System.Windows.Forms.Label lblVoornaam;
        private System.Windows.Forms.Label lblMedewerker;
        private System.Windows.Forms.ComboBox cbMederwerkers;
    }
}