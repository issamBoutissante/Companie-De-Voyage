namespace Companie_de_voyage
{
    partial class Ajouter_Billet
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
            this.label10 = new System.Windows.Forms.Label();
            this.dateDelivrance = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Ajouter = new System.Windows.Forms.Button();
            this.nobreBillet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idVoyage = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(155, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "Id Voyage";
            // 
            // dateDelivrance
            // 
            this.dateDelivrance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDelivrance.Location = new System.Drawing.Point(248, 171);
            this.dateDelivrance.Name = "dateDelivrance";
            this.dateDelivrance.Size = new System.Drawing.Size(202, 20);
            this.dateDelivrance.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Date Delivrance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Nombre Billet";
            // 
            // Ajouter
            // 
            this.Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Ajouter.Location = new System.Drawing.Point(538, 120);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(94, 34);
            this.Ajouter.TabIndex = 48;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // nobreBillet
            // 
            this.nobreBillet.Location = new System.Drawing.Point(248, 130);
            this.nobreBillet.Name = "nobreBillet";
            this.nobreBillet.Size = new System.Drawing.Size(202, 20);
            this.nobreBillet.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(311, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 45;
            this.label1.Text = "Ajout Billet";
            // 
            // idVoyage
            // 
            this.idVoyage.FormattingEnabled = true;
            this.idVoyage.Location = new System.Drawing.Point(249, 216);
            this.idVoyage.Name = "idVoyage";
            this.idVoyage.Size = new System.Drawing.Size(201, 21);
            this.idVoyage.TabIndex = 94;
            // 
            // Ajouter_Billet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.idVoyage);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateDelivrance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.nobreBillet);
            this.Controls.Add(this.label1);
            this.Name = "Ajouter_Billet";
            this.Text = "Ajouter_Billet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateDelivrance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.TextBox nobreBillet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox idVoyage;
    }
}