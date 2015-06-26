namespace GreenShark_Live_Performance
{
    partial class MateriaalForm
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
            this.lbMateriaal = new System.Windows.Forms.ListBox();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.btnMaakAan = new System.Windows.Forms.Button();
            this.btnPasAan = new System.Windows.Forms.Button();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblMateriaal = new System.Windows.Forms.Label();
            this.cbBoot = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbMateriaal
            // 
            this.lbMateriaal.FormattingEnabled = true;
            this.lbMateriaal.Location = new System.Drawing.Point(9, 88);
            this.lbMateriaal.Name = "lbMateriaal";
            this.lbMateriaal.Size = new System.Drawing.Size(264, 134);
            this.lbMateriaal.TabIndex = 47;
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(171, 59);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(73, 23);
            this.btnVerwijder.TabIndex = 46;
            this.btnVerwijder.Text = "Verwijder";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            // 
            // btnMaakAan
            // 
            this.btnMaakAan.Location = new System.Drawing.Point(9, 59);
            this.btnMaakAan.Name = "btnMaakAan";
            this.btnMaakAan.Size = new System.Drawing.Size(75, 23);
            this.btnMaakAan.TabIndex = 45;
            this.btnMaakAan.Text = "Maak Aan";
            this.btnMaakAan.UseVisualStyleBackColor = true;
            // 
            // btnPasAan
            // 
            this.btnPasAan.Location = new System.Drawing.Point(90, 59);
            this.btnPasAan.Name = "btnPasAan";
            this.btnPasAan.Size = new System.Drawing.Size(75, 23);
            this.btnPasAan.TabIndex = 44;
            this.btnPasAan.Text = "Pas Aan";
            this.btnPasAan.UseVisualStyleBackColor = true;
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(74, 33);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(121, 20);
            this.tbNaam.TabIndex = 39;
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(12, 36);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(41, 13);
            this.lblNaam.TabIndex = 38;
            this.lblNaam.Text = "Naam: ";
            // 
            // lblMateriaal
            // 
            this.lblMateriaal.AutoSize = true;
            this.lblMateriaal.Location = new System.Drawing.Point(12, 9);
            this.lblMateriaal.Name = "lblMateriaal";
            this.lblMateriaal.Size = new System.Drawing.Size(56, 13);
            this.lblMateriaal.TabIndex = 37;
            this.lblMateriaal.Text = "Materiaal: ";
            // 
            // cbBoot
            // 
            this.cbBoot.FormattingEnabled = true;
            this.cbBoot.Location = new System.Drawing.Point(74, 6);
            this.cbBoot.Name = "cbBoot";
            this.cbBoot.Size = new System.Drawing.Size(121, 21);
            this.cbBoot.TabIndex = 36;
            // 
            // MateriaalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 389);
            this.Controls.Add(this.lbMateriaal);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.btnMaakAan);
            this.Controls.Add(this.btnPasAan);
            this.Controls.Add(this.tbNaam);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.lblMateriaal);
            this.Controls.Add(this.cbBoot);
            this.Name = "MateriaalForm";
            this.Text = "Materiaal";
            this.Load += new System.EventHandler(this.MateriaalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMateriaal;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.Button btnMaakAan;
        private System.Windows.Forms.Button btnPasAan;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblMateriaal;
        private System.Windows.Forms.ComboBox cbBoot;
    }
}