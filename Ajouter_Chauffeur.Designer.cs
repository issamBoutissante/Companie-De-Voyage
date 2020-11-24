namespace Companie_de_voyage
{
    partial class Ajouter_Chauffeur
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idChauffeurLabel = new System.Windows.Forms.Label();
            this.Ajouter = new System.Windows.Forms.Button();
            this.dateRecrutement = new System.Windows.Forms.DateTimePicker();
            this.salaire = new System.Windows.Forms.TextBox();
            this.adresse = new System.Windows.Forms.TextBox();
            this.prenom = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(302, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajout Chauffeur";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "salaire";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "date recrutement";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "adresse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "prenom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "nom";
            // 
            // idChauffeurLabel
            // 
            this.idChauffeurLabel.AutoSize = true;
            this.idChauffeurLabel.Location = new System.Drawing.Point(89, 107);
            this.idChauffeurLabel.Name = "idChauffeurLabel";
            this.idChauffeurLabel.Size = new System.Drawing.Size(15, 13);
            this.idChauffeurLabel.TabIndex = 20;
            this.idChauffeurLabel.Text = "id";
            // 
            // Ajouter
            // 
            this.Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Ajouter.Location = new System.Drawing.Point(449, 107);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(94, 34);
            this.Ajouter.TabIndex = 19;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.AjouterChauffeur_Click);
            // 
            // dateRecrutement
            // 
            this.dateRecrutement.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateRecrutement.Location = new System.Drawing.Point(176, 278);
            this.dateRecrutement.Name = "dateRecrutement";
            this.dateRecrutement.Size = new System.Drawing.Size(202, 20);
            this.dateRecrutement.TabIndex = 18;
            // 
            // salaire
            // 
            this.salaire.Location = new System.Drawing.Point(176, 321);
            this.salaire.Name = "salaire";
            this.salaire.Size = new System.Drawing.Size(202, 20);
            this.salaire.TabIndex = 17;
            // 
            // adresse
            // 
            this.adresse.Location = new System.Drawing.Point(176, 233);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(202, 20);
            this.adresse.TabIndex = 16;
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(176, 191);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(202, 20);
            this.prenom.TabIndex = 15;
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(177, 148);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(202, 20);
            this.nom.TabIndex = 14;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(176, 107);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(202, 20);
            this.id.TabIndex = 13;
            // 
            // Ajouter_Chauffeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 406);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idChauffeurLabel);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.dateRecrutement);
            this.Controls.Add(this.salaire);
            this.Controls.Add(this.adresse);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label1);
            this.Name = "Ajouter_Chauffeur";
            this.Text = "Ajouter_Chauffeur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label idChauffeurLabel;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.DateTimePicker dateRecrutement;
        private System.Windows.Forms.TextBox salaire;
        private System.Windows.Forms.TextBox adresse;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.TextBox id;
    }
}