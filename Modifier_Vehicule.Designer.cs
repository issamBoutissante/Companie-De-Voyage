namespace Companie_de_voyage
{
    partial class Modifier_Vehicule
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
            this.Modifier = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.matricule = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idChauffeurLabel = new System.Windows.Forms.Label();
            this.dateMiseService = new System.Windows.Forms.DateTimePicker();
            this.type = new System.Windows.Forms.TextBox();
            this.marque = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(372, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 41;
            this.label1.Text = "Modifier Vihecule";
            // 
            // matricule
            // 
            this.matricule.FormattingEnabled = true;
            this.matricule.Location = new System.Drawing.Point(255, 137);
            this.matricule.Name = "matricule";
            this.matricule.Size = new System.Drawing.Size(201, 21);
            this.matricule.TabIndex = 57;
            this.matricule.SelectedIndexChanged += new System.EventHandler(this.matricule_SelectedIndexChanged);
            this.matricule.Click += new System.EventHandler(this.matricule_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "date mise service";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "marque";
            // 
            // idChauffeurLabel
            // 
            this.idChauffeurLabel.AutoSize = true;
            this.idChauffeurLabel.Location = new System.Drawing.Point(155, 137);
            this.idChauffeurLabel.Name = "idChauffeurLabel";
            this.idChauffeurLabel.Size = new System.Drawing.Size(49, 13);
            this.idChauffeurLabel.TabIndex = 53;
            this.idChauffeurLabel.Text = "matricule";
            // 
            // dateMiseService
            // 
            this.dateMiseService.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateMiseService.Location = new System.Drawing.Point(254, 266);
            this.dateMiseService.Name = "dateMiseService";
            this.dateMiseService.Size = new System.Drawing.Size(202, 20);
            this.dateMiseService.TabIndex = 52;
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(254, 221);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(202, 20);
            this.type.TabIndex = 51;
            // 
            // marque
            // 
            this.marque.Location = new System.Drawing.Point(255, 178);
            this.marque.Name = "marque";
            this.marque.Size = new System.Drawing.Size(202, 20);
            this.marque.TabIndex = 50;
            // 
            // Modifier_Vehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.matricule);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idChauffeurLabel);
            this.Controls.Add(this.dateMiseService);
            this.Controls.Add(this.type);
            this.Controls.Add(this.marque);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.label1);
            this.Name = "Modifier_Vehicule";
            this.Text = "Modifier_Vehicule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox matricule;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label idChauffeurLabel;
        private System.Windows.Forms.DateTimePicker dateMiseService;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.TextBox marque;
    }
}