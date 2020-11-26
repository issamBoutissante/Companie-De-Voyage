namespace Companie_de_voyage
{
    partial class Suprimer_Voyage
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
            this.matricule = new System.Windows.Forms.ComboBox();
            this.idChauffeur = new System.Windows.Forms.ComboBox();
            this.duree = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DateVoyage = new System.Windows.Forms.DateTimePicker();
            this.Tarif = new System.Windows.Forms.TextBox();
            this.PlaceLibre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Suprimer = new System.Windows.Forms.Button();
            this.NombresVoyageurs = new System.Windows.Forms.TextBox();
            this.VilleArrive = new System.Windows.Forms.TextBox();
            this.villeDepart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // matricule
            // 
            this.matricule.FormattingEnabled = true;
            this.matricule.Location = new System.Drawing.Point(533, 366);
            this.matricule.Name = "matricule";
            this.matricule.Size = new System.Drawing.Size(201, 21);
            this.matricule.TabIndex = 70;
            this.matricule.SelectedIndexChanged += new System.EventHandler(this.matricule_SelectedIndexChanged);
            // 
            // idChauffeur
            // 
            this.idChauffeur.FormattingEnabled = true;
            this.idChauffeur.Location = new System.Drawing.Point(533, 322);
            this.idChauffeur.Name = "idChauffeur";
            this.idChauffeur.Size = new System.Drawing.Size(201, 21);
            this.idChauffeur.TabIndex = 69;
            this.idChauffeur.SelectedIndexChanged += new System.EventHandler(this.idChauffeur_SelectedIndexChanged);
            // 
            // duree
            // 
            this.duree.Location = new System.Drawing.Point(149, 366);
            this.duree.Name = "duree";
            this.duree.Size = new System.Drawing.Size(202, 20);
            this.duree.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(410, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 67;
            this.label7.Text = "matricule";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(410, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 66;
            this.label8.Text = "id chauffeur";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(410, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "tarif";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(410, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 64;
            this.label10.Text = "place libre";
            // 
            // DateVoyage
            // 
            this.DateVoyage.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateVoyage.Location = new System.Drawing.Point(149, 234);
            this.DateVoyage.Name = "DateVoyage";
            this.DateVoyage.Size = new System.Drawing.Size(202, 20);
            this.DateVoyage.TabIndex = 63;
            // 
            // Tarif
            // 
            this.Tarif.Location = new System.Drawing.Point(533, 279);
            this.Tarif.Name = "Tarif";
            this.Tarif.Size = new System.Drawing.Size(202, 20);
            this.Tarif.TabIndex = 62;
            // 
            // PlaceLibre
            // 
            this.PlaceLibre.Location = new System.Drawing.Point(533, 237);
            this.PlaceLibre.Name = "PlaceLibre";
            this.PlaceLibre.Size = new System.Drawing.Size(202, 20);
            this.PlaceLibre.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "nombre de voyageurs";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "duree";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "ville arrive";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "ville depart";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "date voyage";
            // 
            // Suprimer
            // 
            this.Suprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Suprimer.Location = new System.Drawing.Point(616, 115);
            this.Suprimer.Name = "Suprimer";
            this.Suprimer.Size = new System.Drawing.Size(119, 34);
            this.Suprimer.TabIndex = 55;
            this.Suprimer.Text = "Suprimer";
            this.Suprimer.UseVisualStyleBackColor = true;
            this.Suprimer.Click += new System.EventHandler(this.Suprimer_Click);
            // 
            // NombresVoyageurs
            // 
            this.NombresVoyageurs.Location = new System.Drawing.Point(534, 201);
            this.NombresVoyageurs.Name = "NombresVoyageurs";
            this.NombresVoyageurs.Size = new System.Drawing.Size(202, 20);
            this.NombresVoyageurs.TabIndex = 54;
            // 
            // VilleArrive
            // 
            this.VilleArrive.Location = new System.Drawing.Point(149, 321);
            this.VilleArrive.Name = "VilleArrive";
            this.VilleArrive.Size = new System.Drawing.Size(202, 20);
            this.VilleArrive.TabIndex = 53;
            // 
            // villeDepart
            // 
            this.villeDepart.Location = new System.Drawing.Point(149, 279);
            this.villeDepart.Name = "villeDepart";
            this.villeDepart.Size = new System.Drawing.Size(202, 20);
            this.villeDepart.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(345, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 24);
            this.label1.TabIndex = 51;
            this.label1.Text = "Suprimer Voyage";
            // 
            // id
            // 
            this.id.FormattingEnabled = true;
            this.id.Location = new System.Drawing.Point(150, 195);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(201, 21);
            this.id.TabIndex = 72;
            this.id.SelectedIndexChanged += new System.EventHandler(this.id_SelectedIndexChanged);
            this.id.Click += new System.EventHandler(this.id_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(62, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 71;
            this.label11.Text = "id";
            // 
            // Suprimer_Voyage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.matricule);
            this.Controls.Add(this.idChauffeur);
            this.Controls.Add(this.duree);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DateVoyage);
            this.Controls.Add(this.Tarif);
            this.Controls.Add(this.PlaceLibre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Suprimer);
            this.Controls.Add(this.NombresVoyageurs);
            this.Controls.Add(this.VilleArrive);
            this.Controls.Add(this.villeDepart);
            this.Controls.Add(this.label1);
            this.Name = "Suprimer_Voyage";
            this.Text = "Suprimer_Voyage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox matricule;
        private System.Windows.Forms.ComboBox idChauffeur;
        private System.Windows.Forms.TextBox duree;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker DateVoyage;
        private System.Windows.Forms.TextBox Tarif;
        private System.Windows.Forms.TextBox PlaceLibre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Suprimer;
        private System.Windows.Forms.TextBox NombresVoyageurs;
        private System.Windows.Forms.TextBox VilleArrive;
        private System.Windows.Forms.TextBox villeDepart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox id;
        private System.Windows.Forms.Label label11;
    }
}