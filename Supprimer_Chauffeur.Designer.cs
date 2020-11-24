namespace Companie_de_voyage
{
    partial class Supprimer_Chauffeur
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Supprimer = new System.Windows.Forms.Button();
            this.dateRecrutement = new System.Windows.Forms.DateTimePicker();
            this.salaire = new System.Windows.Forms.TextBox();
            this.adresse = new System.Windows.Forms.TextBox();
            this.prenom = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idChauffeurLabel = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "salaire";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "date recrutement";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "adresse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "prenom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "nom";
            // 
            // Supprimer
            // 
            this.Supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Supprimer.Location = new System.Drawing.Point(530, 137);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(126, 34);
            this.Supprimer.TabIndex = 33;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // dateRecrutement
            // 
            this.dateRecrutement.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateRecrutement.Location = new System.Drawing.Point(260, 308);
            this.dateRecrutement.Name = "dateRecrutement";
            this.dateRecrutement.Size = new System.Drawing.Size(202, 20);
            this.dateRecrutement.TabIndex = 32;
            // 
            // salaire
            // 
            this.salaire.Location = new System.Drawing.Point(260, 351);
            this.salaire.Name = "salaire";
            this.salaire.Size = new System.Drawing.Size(202, 20);
            this.salaire.TabIndex = 31;
            // 
            // adresse
            // 
            this.adresse.Location = new System.Drawing.Point(260, 263);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(202, 20);
            this.adresse.TabIndex = 30;
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(260, 221);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(202, 20);
            this.prenom.TabIndex = 29;
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(261, 178);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(202, 20);
            this.nom.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(386, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Ajout Chauffeur";
            // 
            // idChauffeurLabel
            // 
            this.idChauffeurLabel.AutoSize = true;
            this.idChauffeurLabel.Location = new System.Drawing.Point(173, 137);
            this.idChauffeurLabel.Name = "idChauffeurLabel";
            this.idChauffeurLabel.Size = new System.Drawing.Size(15, 13);
            this.idChauffeurLabel.TabIndex = 39;
            this.idChauffeurLabel.Text = "id";
            // 
            // id
            // 
            this.id.FormattingEnabled = true;
            this.id.Location = new System.Drawing.Point(260, 129);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(201, 21);
            this.id.TabIndex = 40;
            this.id.SelectedIndexChanged += new System.EventHandler(this.id_SelectedIndexChanged);
            this.id.Click += new System.EventHandler(this.id_Click);
            // 
            // Supprimer_Chauffeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.id);
            this.Controls.Add(this.idChauffeurLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.dateRecrutement);
            this.Controls.Add(this.salaire);
            this.Controls.Add(this.adresse);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.label1);
            this.Name = "Supprimer_Chauffeur";
            this.Text = "Supprimer_Chauffeur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.DateTimePicker dateRecrutement;
        private System.Windows.Forms.TextBox salaire;
        private System.Windows.Forms.TextBox adresse;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label idChauffeurLabel;
        private System.Windows.Forms.ComboBox id;
    }
}