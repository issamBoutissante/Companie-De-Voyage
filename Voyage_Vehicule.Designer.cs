namespace Companie_de_voyage
{
    partial class Voyage_Vehicule
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
            this.NombreDeVoyage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imatricule = new System.Windows.Forms.ComboBox();
            this.VoyageParVehiculedataGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.VoyageParVehiculedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NombreDeVoyage
            // 
            this.NombreDeVoyage.AutoSize = true;
            this.NombreDeVoyage.Location = new System.Drawing.Point(543, 262);
            this.NombreDeVoyage.Name = "NombreDeVoyage";
            this.NombreDeVoyage.Size = new System.Drawing.Size(0, 13);
            this.NombreDeVoyage.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nombre Voyage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "imatricule";
            // 
            // imatricule
            // 
            this.imatricule.FormattingEnabled = true;
            this.imatricule.Location = new System.Drawing.Point(546, 185);
            this.imatricule.Name = "imatricule";
            this.imatricule.Size = new System.Drawing.Size(121, 21);
            this.imatricule.TabIndex = 30;
            this.imatricule.SelectedIndexChanged += new System.EventHandler(this.imatricule_SelectedIndexChanged);
            // 
            // VoyageParVehiculedataGridView
            // 
            this.VoyageParVehiculedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VoyageParVehiculedataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.VoyageParVehiculedataGridView.Location = new System.Drawing.Point(134, 185);
            this.VoyageParVehiculedataGridView.Name = "VoyageParVehiculedataGridView";
            this.VoyageParVehiculedataGridView.Size = new System.Drawing.Size(243, 150);
            this.VoyageParVehiculedataGridView.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(284, 115);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(319, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "Nombre De Voyage par Vehicule";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "matricule Vehicule";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "nombre de voyage";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Voyage_Vehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NombreDeVoyage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imatricule);
            this.Controls.Add(this.VoyageParVehiculedataGridView);
            this.Controls.Add(this.label5);
            this.Name = "Voyage_Vehicule";
            this.Text = "Voyage_Vehicule";
            ((System.ComponentModel.ISupportInitialize)(this.VoyageParVehiculedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NombreDeVoyage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox imatricule;
        private System.Windows.Forms.DataGridView VoyageParVehiculedataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}