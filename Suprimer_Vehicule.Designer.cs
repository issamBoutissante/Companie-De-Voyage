namespace Companie_de_voyage
{
    partial class Suprimer_Vehicule
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idChauffeurLabel = new System.Windows.Forms.Label();
            this.Suprimer = new System.Windows.Forms.Button();
            this.dateMiseService = new System.Windows.Forms.DateTimePicker();
            this.type = new System.Windows.Forms.TextBox();
            this.marque = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.matricule = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "date mise service";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "marque";
            // 
            // idChauffeurLabel
            // 
            this.idChauffeurLabel.AutoSize = true;
            this.idChauffeurLabel.Location = new System.Drawing.Point(167, 180);
            this.idChauffeurLabel.Name = "idChauffeurLabel";
            this.idChauffeurLabel.Size = new System.Drawing.Size(49, 13);
            this.idChauffeurLabel.TabIndex = 45;
            this.idChauffeurLabel.Text = "matricule";
            // 
            // Suprimer
            // 
            this.Suprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Suprimer.Location = new System.Drawing.Point(539, 180);
            this.Suprimer.Name = "Suprimer";
            this.Suprimer.Size = new System.Drawing.Size(107, 34);
            this.Suprimer.TabIndex = 44;
            this.Suprimer.Text = "Suprimer";
            this.Suprimer.UseVisualStyleBackColor = true;
            this.Suprimer.Click += new System.EventHandler(this.Suprimer_Click);
            // 
            // dateMiseService
            // 
            this.dateMiseService.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateMiseService.Location = new System.Drawing.Point(266, 309);
            this.dateMiseService.Name = "dateMiseService";
            this.dateMiseService.Size = new System.Drawing.Size(202, 20);
            this.dateMiseService.TabIndex = 43;
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(266, 264);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(202, 20);
            this.type.TabIndex = 42;
            // 
            // marque
            // 
            this.marque.Location = new System.Drawing.Point(267, 221);
            this.marque.Name = "marque";
            this.marque.Size = new System.Drawing.Size(202, 20);
            this.marque.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(339, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = "Suprimer Vehicule";
            // 
            // matricule
            // 
            this.matricule.FormattingEnabled = true;
            this.matricule.Location = new System.Drawing.Point(267, 180);
            this.matricule.Name = "matricule";
            this.matricule.Size = new System.Drawing.Size(201, 21);
            this.matricule.TabIndex = 49;
            this.matricule.SelectedIndexChanged += new System.EventHandler(this.matricule_SelectedIndexChanged);
            this.matricule.Click += new System.EventHandler(this.matricule_Click);
            // 
            // Suprimer_Vehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.matricule);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idChauffeurLabel);
            this.Controls.Add(this.Suprimer);
            this.Controls.Add(this.dateMiseService);
            this.Controls.Add(this.type);
            this.Controls.Add(this.marque);
            this.Controls.Add(this.label1);
            this.Name = "Suprimer_Vehicule";
            this.Text = "Suprimer_Vehicule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label idChauffeurLabel;
        private System.Windows.Forms.Button Suprimer;
        private System.Windows.Forms.DateTimePicker dateMiseService;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.TextBox marque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox matricule;
    }
}