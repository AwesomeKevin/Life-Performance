namespace GreenShark_Live_Performance
{
    partial class MissieForm
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
            this.cbMissie = new System.Windows.Forms.ComboBox();
            this.lblMissie = new System.Windows.Forms.Label();
            this.lblNaam = new System.Windows.Forms.Label();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.lblBegindatum = new System.Windows.Forms.Label();
            this.tbLocatieX = new System.Windows.Forms.TextBox();
            this.lblLocatieX = new System.Windows.Forms.Label();
            this.lblLocatieY = new System.Windows.Forms.Label();
            this.tbLocatieY = new System.Windows.Forms.TextBox();
            this.btnPasAan = new System.Windows.Forms.Button();
            this.btnMaakAan = new System.Windows.Forms.Button();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.lbMissies = new System.Windows.Forms.ListBox();
            this.tbBegindatum = new System.Windows.Forms.TextBox();
            this.tbEinddatum = new System.Windows.Forms.TextBox();
            this.lblEinddatum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbMissie
            // 
            this.cbMissie.FormattingEnabled = true;
            this.cbMissie.Location = new System.Drawing.Point(79, 12);
            this.cbMissie.Name = "cbMissie";
            this.cbMissie.Size = new System.Drawing.Size(200, 21);
            this.cbMissie.TabIndex = 0;
            // 
            // lblMissie
            // 
            this.lblMissie.AutoSize = true;
            this.lblMissie.Location = new System.Drawing.Point(12, 15);
            this.lblMissie.Name = "lblMissie";
            this.lblMissie.Size = new System.Drawing.Size(42, 13);
            this.lblMissie.TabIndex = 1;
            this.lblMissie.Text = "Missie: ";
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(12, 42);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(41, 13);
            this.lblNaam.TabIndex = 2;
            this.lblNaam.Text = "Naam: ";
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(79, 39);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(200, 20);
            this.tbNaam.TabIndex = 3;
            // 
            // lblBegindatum
            // 
            this.lblBegindatum.AutoSize = true;
            this.lblBegindatum.Location = new System.Drawing.Point(12, 71);
            this.lblBegindatum.Name = "lblBegindatum";
            this.lblBegindatum.Size = new System.Drawing.Size(69, 13);
            this.lblBegindatum.TabIndex = 5;
            this.lblBegindatum.Text = "Begindatum: ";
            // 
            // tbLocatieX
            // 
            this.tbLocatieX.Location = new System.Drawing.Point(79, 118);
            this.tbLocatieX.Name = "tbLocatieX";
            this.tbLocatieX.Size = new System.Drawing.Size(200, 20);
            this.tbLocatieX.TabIndex = 8;
            // 
            // lblLocatieX
            // 
            this.lblLocatieX.AutoSize = true;
            this.lblLocatieX.Location = new System.Drawing.Point(12, 121);
            this.lblLocatieX.Name = "lblLocatieX";
            this.lblLocatieX.Size = new System.Drawing.Size(58, 13);
            this.lblLocatieX.TabIndex = 11;
            this.lblLocatieX.Text = "Locatie X: ";
            // 
            // lblLocatieY
            // 
            this.lblLocatieY.AutoSize = true;
            this.lblLocatieY.Location = new System.Drawing.Point(12, 147);
            this.lblLocatieY.Name = "lblLocatieY";
            this.lblLocatieY.Size = new System.Drawing.Size(58, 13);
            this.lblLocatieY.TabIndex = 12;
            this.lblLocatieY.Text = "Locatie Y: ";
            // 
            // tbLocatieY
            // 
            this.tbLocatieY.Location = new System.Drawing.Point(79, 144);
            this.tbLocatieY.Name = "tbLocatieY";
            this.tbLocatieY.Size = new System.Drawing.Size(200, 20);
            this.tbLocatieY.TabIndex = 13;
            // 
            // btnPasAan
            // 
            this.btnPasAan.Location = new System.Drawing.Point(96, 170);
            this.btnPasAan.Name = "btnPasAan";
            this.btnPasAan.Size = new System.Drawing.Size(75, 23);
            this.btnPasAan.TabIndex = 14;
            this.btnPasAan.Text = "Pas Aan";
            this.btnPasAan.UseVisualStyleBackColor = true;
            // 
            // btnMaakAan
            // 
            this.btnMaakAan.Location = new System.Drawing.Point(15, 170);
            this.btnMaakAan.Name = "btnMaakAan";
            this.btnMaakAan.Size = new System.Drawing.Size(75, 23);
            this.btnMaakAan.TabIndex = 15;
            this.btnMaakAan.Text = "Maak Aan";
            this.btnMaakAan.UseVisualStyleBackColor = true;
            this.btnMaakAan.Click += new System.EventHandler(this.btnMaakAan_Click);
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(177, 170);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(73, 23);
            this.btnVerwijder.TabIndex = 16;
            this.btnVerwijder.Text = "Verwijder";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            // 
            // lbMissies
            // 
            this.lbMissies.FormattingEnabled = true;
            this.lbMissies.Location = new System.Drawing.Point(15, 199);
            this.lbMissies.Name = "lbMissies";
            this.lbMissies.Size = new System.Drawing.Size(264, 134);
            this.lbMissies.TabIndex = 17;
            // 
            // tbBegindatum
            // 
            this.tbBegindatum.Location = new System.Drawing.Point(79, 66);
            this.tbBegindatum.Name = "tbBegindatum";
            this.tbBegindatum.Size = new System.Drawing.Size(200, 20);
            this.tbBegindatum.TabIndex = 18;
            this.tbBegindatum.Text = "11/03/2015";
            this.tbBegindatum.TextChanged += new System.EventHandler(this.tbBegindatum_TextChanged);
            // 
            // tbEinddatum
            // 
            this.tbEinddatum.Location = new System.Drawing.Point(79, 92);
            this.tbEinddatum.Name = "tbEinddatum";
            this.tbEinddatum.Size = new System.Drawing.Size(200, 20);
            this.tbEinddatum.TabIndex = 20;
            // 
            // lblEinddatum
            // 
            this.lblEinddatum.AutoSize = true;
            this.lblEinddatum.Location = new System.Drawing.Point(12, 97);
            this.lblEinddatum.Name = "lblEinddatum";
            this.lblEinddatum.Size = new System.Drawing.Size(63, 13);
            this.lblEinddatum.TabIndex = 19;
            this.lblEinddatum.Text = "Einddatum: ";
            // 
            // MissieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 349);
            this.Controls.Add(this.tbEinddatum);
            this.Controls.Add(this.lblEinddatum);
            this.Controls.Add(this.tbBegindatum);
            this.Controls.Add(this.lbMissies);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.btnMaakAan);
            this.Controls.Add(this.btnPasAan);
            this.Controls.Add(this.tbLocatieY);
            this.Controls.Add(this.lblLocatieY);
            this.Controls.Add(this.lblLocatieX);
            this.Controls.Add(this.tbLocatieX);
            this.Controls.Add(this.lblBegindatum);
            this.Controls.Add(this.tbNaam);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.lblMissie);
            this.Controls.Add(this.cbMissie);
            this.Name = "MissieForm";
            this.Text = "Missies";
            this.Load += new System.EventHandler(this.MissieForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMissie;
        private System.Windows.Forms.Label lblMissie;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.Label lblBegindatum;
        private System.Windows.Forms.TextBox tbLocatieX;
        private System.Windows.Forms.Label lblLocatieX;
        private System.Windows.Forms.Label lblLocatieY;
        private System.Windows.Forms.TextBox tbLocatieY;
        private System.Windows.Forms.Button btnPasAan;
        private System.Windows.Forms.Button btnMaakAan;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.ListBox lbMissies;
        private System.Windows.Forms.TextBox tbBegindatum;
        private System.Windows.Forms.TextBox tbEinddatum;
        private System.Windows.Forms.Label lblEinddatum;
    }
}