namespace Companie_de_voyage
{
    partial class Recette_Voyage
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
            this.Recette = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NumeroVoyage = new System.Windows.Forms.ComboBox();
            this.RecetteParVoyagedataGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.RecetteParVoyagedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Recette
            // 
            this.Recette.AutoSize = true;
            this.Recette.Location = new System.Drawing.Point(508, 235);
            this.Recette.Name = "Recette";
            this.Recette.Size = new System.Drawing.Size(0, 13);
            this.Recette.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Recette";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Numero Voyage";
            // 
            // NumeroVoyage
            // 
            this.NumeroVoyage.FormattingEnabled = true;
            this.NumeroVoyage.Location = new System.Drawing.Point(511, 158);
            this.NumeroVoyage.Name = "NumeroVoyage";
            this.NumeroVoyage.Size = new System.Drawing.Size(121, 21);
            this.NumeroVoyage.TabIndex = 42;
            this.NumeroVoyage.SelectedIndexChanged += new System.EventHandler(this.NumeroVoyage_SelectedIndexChanged);
            // 
            // RecetteParVoyagedataGridView
            // 
            this.RecetteParVoyagedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecetteParVoyagedataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.RecetteParVoyagedataGridView.Location = new System.Drawing.Point(99, 158);
            this.RecetteParVoyagedataGridView.Name = "RecetteParVoyagedataGridView";
            this.RecetteParVoyagedataGridView.Size = new System.Drawing.Size(243, 150);
            this.RecetteParVoyagedataGridView.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(249, 88);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(194, 24);
            this.label5.TabIndex = 40;
            this.label5.Text = "Recette par Voyage";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id Voyage";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Recette";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Recette_Voyage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Recette);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumeroVoyage);
            this.Controls.Add(this.RecetteParVoyagedataGridView);
            this.Controls.Add(this.label5);
            this.Name = "Recette_Voyage";
            this.Text = "Recette_Voyage";
            ((System.ComponentModel.ISupportInitialize)(this.RecetteParVoyagedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Recette;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox NumeroVoyage;
        private System.Windows.Forms.DataGridView RecetteParVoyagedataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}