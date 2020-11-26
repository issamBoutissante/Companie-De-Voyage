namespace Companie_de_voyage
{
    partial class Suprimer_Billet
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
            this.idVoyage = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateDelivrance = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Suprimer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nombreBillet = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // idVoyage
            // 
            this.idVoyage.FormattingEnabled = true;
            this.idVoyage.Location = new System.Drawing.Point(230, 221);
            this.idVoyage.Name = "idVoyage";
            this.idVoyage.Size = new System.Drawing.Size(201, 21);
            this.idVoyage.TabIndex = 102;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(136, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 101;
            this.label10.Text = "Id Voyage";
            // 
            // dateDelivrance
            // 
            this.dateDelivrance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDelivrance.Location = new System.Drawing.Point(229, 176);
            this.dateDelivrance.Name = "dateDelivrance";
            this.dateDelivrance.Size = new System.Drawing.Size(202, 20);
            this.dateDelivrance.TabIndex = 100;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 99;
            this.label6.Text = "Date Delivrance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 98;
            this.label2.Text = "Nombre Billet";
            // 
            // Suprimer
            // 
            this.Suprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Suprimer.Location = new System.Drawing.Point(519, 125);
            this.Suprimer.Name = "Suprimer";
            this.Suprimer.Size = new System.Drawing.Size(115, 34);
            this.Suprimer.TabIndex = 97;
            this.Suprimer.Text = "Suprimer";
            this.Suprimer.UseVisualStyleBackColor = true;
            this.Suprimer.Click += new System.EventHandler(this.Suprimer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(292, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 95;
            this.label1.Text = "Suprimer Billet";
            // 
            // nombreBillet
            // 
            this.nombreBillet.FormattingEnabled = true;
            this.nombreBillet.Location = new System.Drawing.Point(229, 138);
            this.nombreBillet.Name = "nombreBillet";
            this.nombreBillet.Size = new System.Drawing.Size(201, 21);
            this.nombreBillet.TabIndex = 103;
            this.nombreBillet.SelectedIndexChanged += new System.EventHandler(this.nombreBillet_SelectedIndexChanged);
            this.nombreBillet.Click += new System.EventHandler(this.nombreBillet_Click);
            // 
            // Suprimer_Billet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nombreBillet);
            this.Controls.Add(this.idVoyage);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateDelivrance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Suprimer);
            this.Controls.Add(this.label1);
            this.Name = "Suprimer_Billet";
            this.Text = "Suprimer_Billet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox idVoyage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateDelivrance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Suprimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox nombreBillet;
    }
}