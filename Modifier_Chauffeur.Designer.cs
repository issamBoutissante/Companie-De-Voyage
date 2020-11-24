namespace Companie_de_voyage
{
    partial class Modifier_Chauffeur
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
            this.id = new System.Windows.Forms.ComboBox();
            this.idChauffeurLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Modifier = new System.Windows.Forms.Button();
            this.dateRecrutement = new System.Windows.Forms.DateTimePicker();
            this.salaire = new System.Windows.Forms.TextBox();
            this.adresse = new System.Windows.Forms.TextBox();
            this.prenom = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.FormattingEnabled = true;
            this.id.Location = new System.Drawing.Point(246, 129);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(201, 21);
            this.id.TabIndex = 54;
            this.id.SelectedIndexChanged += new System.EventHandler(this.id_SelectedIndexChanged);
            this.id.Click += new System.EventHandler(this.id_Click);
            // 
            // idChauffeurLabel
            // 
            this.idChauffeurLabel.AutoSize = true;
            this.idChauffeurLabel.Location = new System.Drawing.Point(159, 137);
            this.idChauffeurLabel.Name = "idChauffeurLabel";
            this.idChauffeurLabel.Size = new System.Drawing.Size(15, 13);
            this.idChauffeurLabel.TabIndex = 53;
            this.idChauffeurLabel.Text = "id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "salaire";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "date recrutement";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "adresse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "prenom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "nom";
            // 
            // Modifier
            // 
            this.Modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Modifier.Location = new System.Drawing.Point(516, 137);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(126, 34);
            this.Modifier.TabIndex = 47;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // dateRecrutement
            // 
            this.dateRecrutement.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateRecrutement.Location = new System.Drawing.Point(246, 308);
            this.dateRecrutement.Name = "dateRecrutement";
            this.dateRecrutement.Size = new System.Drawing.Size(202, 20);
            this.dateRecrutement.TabIndex = 46;
            // 
            // salaire
            // 
            this.salaire.Location = new System.Drawing.Point(246, 351);
            this.salaire.Name = "salaire";
            this.salaire.Size = new System.Drawing.Size(202, 20);
            this.salaire.TabIndex = 45;
            // 
            // adresse
            // 
            this.adresse.Location = new System.Drawing.Point(246, 263);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(202, 20);
            this.adresse.TabIndex = 44;
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(246, 221);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(202, 20);
            this.prenom.TabIndex = 43;
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(247, 178);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(202, 20);
            this.nom.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(372, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 24);
            this.label1.TabIndex = 41;
            this.label1.Text = "Modifier Chauffeur";
            // 
            // Modifier_Chauffeur
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
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.dateRecrutement);
            this.Controls.Add(this.salaire);
            this.Controls.Add(this.adresse);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.label1);
            this.Name = "Modifier_Chauffeur";
            this.Text = "Modifier_Chauffeur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox id;
        private System.Windows.Forms.Label idChauffeurLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.DateTimePicker dateRecrutement;
        private System.Windows.Forms.TextBox salaire;
        private System.Windows.Forms.TextBox adresse;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Label label1;
    }
}