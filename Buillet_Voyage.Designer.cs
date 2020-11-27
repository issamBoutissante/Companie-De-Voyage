namespace Companie_de_voyage
{
    partial class Buillet_Voyage
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
            this.BilletParVoyagedataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numroVoyage = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreBillet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BilletParVoyagedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(253, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nombre De Billet par Voyage";
            // 
            // BilletParVoyagedataGridView
            // 
            this.BilletParVoyagedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BilletParVoyagedataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.BilletParVoyagedataGridView.Location = new System.Drawing.Point(103, 142);
            this.BilletParVoyagedataGridView.Name = "BilletParVoyagedataGridView";
            this.BilletParVoyagedataGridView.Size = new System.Drawing.Size(243, 150);
            this.BilletParVoyagedataGridView.TabIndex = 23;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Numero Voyage";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre de Billet";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // numroVoyage
            // 
            this.numroVoyage.FormattingEnabled = true;
            this.numroVoyage.Location = new System.Drawing.Point(515, 142);
            this.numroVoyage.Name = "numroVoyage";
            this.numroVoyage.Size = new System.Drawing.Size(121, 21);
            this.numroVoyage.TabIndex = 24;
            this.numroVoyage.SelectedIndexChanged += new System.EventHandler(this.numroVoyage_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Numuro Voyage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nombre Billet";
            // 
            // NombreBillet
            // 
            this.NombreBillet.AutoSize = true;
            this.NombreBillet.Location = new System.Drawing.Point(512, 219);
            this.NombreBillet.Name = "NombreBillet";
            this.NombreBillet.Size = new System.Drawing.Size(0, 13);
            this.NombreBillet.TabIndex = 27;
            // 
            // Buillet_Voyage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NombreBillet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numroVoyage);
            this.Controls.Add(this.BilletParVoyagedataGridView);
            this.Controls.Add(this.label5);
            this.Name = "Buillet_Voyage";
            this.Text = "Buillet_Voyage";
            ((System.ComponentModel.ISupportInitialize)(this.BilletParVoyagedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView BilletParVoyagedataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ComboBox numroVoyage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NombreBillet;
    }
}