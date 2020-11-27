namespace Companie_de_voyage
{
    partial class Nombre_de_ligne
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
            this.label1 = new System.Windows.Forms.Label();
            this.NombreChauffeur = new System.Windows.Forms.TextBox();
            this.NombreVehicule = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreVoyage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NombreBillet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Chauffeur";
            // 
            // NombreChauffeur
            // 
            this.NombreChauffeur.Location = new System.Drawing.Point(345, 129);
            this.NombreChauffeur.Name = "NombreChauffeur";
            this.NombreChauffeur.Size = new System.Drawing.Size(64, 20);
            this.NombreChauffeur.TabIndex = 1;
            // 
            // NombreVehicule
            // 
            this.NombreVehicule.Location = new System.Drawing.Point(345, 178);
            this.NombreVehicule.Name = "NombreVehicule";
            this.NombreVehicule.Size = new System.Drawing.Size(64, 20);
            this.NombreVehicule.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre de Vehicule";
            // 
            // NombreVoyage
            // 
            this.NombreVoyage.Location = new System.Drawing.Point(345, 226);
            this.NombreVoyage.Name = "NombreVoyage";
            this.NombreVoyage.Size = new System.Drawing.Size(64, 20);
            this.NombreVoyage.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre de Voyage";
            // 
            // NombreBillet
            // 
            this.NombreBillet.Location = new System.Drawing.Point(344, 279);
            this.NombreBillet.Name = "NombreBillet";
            this.NombreBillet.Size = new System.Drawing.Size(64, 20);
            this.NombreBillet.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre de Billet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(252, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(274, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "Statistique base de donnees";
            // 
            // Nombre_de_ligne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NombreBillet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NombreVoyage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NombreVehicule);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NombreChauffeur);
            this.Controls.Add(this.label1);
            this.Name = "Nombre_de_ligne";
            this.Text = "Nombre_de_ligne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreChauffeur;
        private System.Windows.Forms.TextBox NombreVehicule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombreVoyage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NombreBillet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}