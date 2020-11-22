namespace Companie_de_voyage
{
    partial class Chauffeur
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
            this.idChauffeur = new System.Windows.Forms.TextBox();
            this.nomChauffeur = new System.Windows.Forms.TextBox();
            this.prenomChauffeur = new System.Windows.Forms.TextBox();
            this.adresseChauffeur = new System.Windows.Forms.TextBox();
            this.salaireChauffeur = new System.Windows.Forms.TextBox();
            this.dateRecrutementChauffeur = new System.Windows.Forms.DateTimePicker();
            this.AjouterChauffeur = new System.Windows.Forms.Button();
            this.idChauffeurLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SupprimerChaffaur = new System.Windows.Forms.Button();
            this.ModiffierChauffeur = new System.Windows.Forms.Button();
            this.chauffeurdataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chauffeurdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idChauffeur
            // 
            this.idChauffeur.Location = new System.Drawing.Point(131, 67);
            this.idChauffeur.Name = "idChauffeur";
            this.idChauffeur.Size = new System.Drawing.Size(202, 20);
            this.idChauffeur.TabIndex = 0;
            // 
            // nomChauffeur
            // 
            this.nomChauffeur.Location = new System.Drawing.Point(131, 108);
            this.nomChauffeur.Name = "nomChauffeur";
            this.nomChauffeur.Size = new System.Drawing.Size(202, 20);
            this.nomChauffeur.TabIndex = 1;
            // 
            // prenomChauffeur
            // 
            this.prenomChauffeur.Location = new System.Drawing.Point(131, 151);
            this.prenomChauffeur.Name = "prenomChauffeur";
            this.prenomChauffeur.Size = new System.Drawing.Size(202, 20);
            this.prenomChauffeur.TabIndex = 2;
            // 
            // adresseChauffeur
            // 
            this.adresseChauffeur.Location = new System.Drawing.Point(131, 193);
            this.adresseChauffeur.Name = "adresseChauffeur";
            this.adresseChauffeur.Size = new System.Drawing.Size(202, 20);
            this.adresseChauffeur.TabIndex = 3;
            // 
            // salaireChauffeur
            // 
            this.salaireChauffeur.Location = new System.Drawing.Point(131, 281);
            this.salaireChauffeur.Name = "salaireChauffeur";
            this.salaireChauffeur.Size = new System.Drawing.Size(202, 20);
            this.salaireChauffeur.TabIndex = 4;
            // 
            // dateRecrutementChauffeur
            // 
            this.dateRecrutementChauffeur.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateRecrutementChauffeur.Location = new System.Drawing.Point(131, 238);
            this.dateRecrutementChauffeur.Name = "dateRecrutementChauffeur";
            this.dateRecrutementChauffeur.Size = new System.Drawing.Size(202, 20);
            this.dateRecrutementChauffeur.TabIndex = 5;
            // 
            // AjouterChauffeur
            // 
            this.AjouterChauffeur.Location = new System.Drawing.Point(397, 126);
            this.AjouterChauffeur.Name = "AjouterChauffeur";
            this.AjouterChauffeur.Size = new System.Drawing.Size(75, 23);
            this.AjouterChauffeur.TabIndex = 6;
            this.AjouterChauffeur.Text = "Ajouter";
            this.AjouterChauffeur.UseVisualStyleBackColor = true;
            this.AjouterChauffeur.Click += new System.EventHandler(this.AjouterChauffeur_Click);
            // 
            // idChauffeurLabel
            // 
            this.idChauffeurLabel.AutoSize = true;
            this.idChauffeurLabel.Location = new System.Drawing.Point(44, 67);
            this.idChauffeurLabel.Name = "idChauffeurLabel";
            this.idChauffeurLabel.Size = new System.Drawing.Size(15, 13);
            this.idChauffeurLabel.TabIndex = 7;
            this.idChauffeurLabel.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "adresse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "date recrutement";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "salaire";
            // 
            // SupprimerChaffaur
            // 
            this.SupprimerChaffaur.Location = new System.Drawing.Point(397, 67);
            this.SupprimerChaffaur.Name = "SupprimerChaffaur";
            this.SupprimerChaffaur.Size = new System.Drawing.Size(75, 23);
            this.SupprimerChaffaur.TabIndex = 13;
            this.SupprimerChaffaur.Text = "Supprimer";
            this.SupprimerChaffaur.UseVisualStyleBackColor = true;
            this.SupprimerChaffaur.Click += new System.EventHandler(this.SupprimerChaffaur_Click);
            // 
            // ModiffierChauffeur
            // 
            this.ModiffierChauffeur.Location = new System.Drawing.Point(398, 191);
            this.ModiffierChauffeur.Name = "ModiffierChauffeur";
            this.ModiffierChauffeur.Size = new System.Drawing.Size(75, 23);
            this.ModiffierChauffeur.TabIndex = 14;
            this.ModiffierChauffeur.Text = "Modifier";
            this.ModiffierChauffeur.UseVisualStyleBackColor = true;
            this.ModiffierChauffeur.Click += new System.EventHandler(this.ModiffierChauffeur_Click);
            // 
            // chauffeurdataGridView
            // 
            this.chauffeurdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chauffeurdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.chauffeurdataGridView.Location = new System.Drawing.Point(497, 67);
            this.chauffeurdataGridView.Name = "chauffeurdataGridView";
            this.chauffeurdataGridView.Size = new System.Drawing.Size(268, 282);
            this.chauffeurdataGridView.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Penom";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Adresse";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Date Recrutement";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Salaire";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Chauffeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 376);
            this.Controls.Add(this.chauffeurdataGridView);
            this.Controls.Add(this.ModiffierChauffeur);
            this.Controls.Add(this.SupprimerChaffaur);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idChauffeurLabel);
            this.Controls.Add(this.AjouterChauffeur);
            this.Controls.Add(this.dateRecrutementChauffeur);
            this.Controls.Add(this.salaireChauffeur);
            this.Controls.Add(this.adresseChauffeur);
            this.Controls.Add(this.prenomChauffeur);
            this.Controls.Add(this.nomChauffeur);
            this.Controls.Add(this.idChauffeur);
            this.Name = "Chauffeur";
            this.Text = "Chauffeur";
            ((System.ComponentModel.ISupportInitialize)(this.chauffeurdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idChauffeur;
        private System.Windows.Forms.TextBox nomChauffeur;
        private System.Windows.Forms.TextBox prenomChauffeur;
        private System.Windows.Forms.TextBox adresseChauffeur;
        private System.Windows.Forms.TextBox salaireChauffeur;
        private System.Windows.Forms.DateTimePicker dateRecrutementChauffeur;
        private System.Windows.Forms.Button AjouterChauffeur;
        private System.Windows.Forms.Label idChauffeurLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SupprimerChaffaur;
        private System.Windows.Forms.Button ModiffierChauffeur;
        private System.Windows.Forms.DataGridView chauffeurdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}