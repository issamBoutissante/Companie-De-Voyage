namespace Companie_de_voyage
{
    partial class Liste_Billet
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
            this.billetdataGridView = new System.Windows.Forms.DataGridView();
            this.Afficher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.billetdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // billetdataGridView
            // 
            this.billetdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billetdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.billetdataGridView.Location = new System.Drawing.Point(231, 115);
            this.billetdataGridView.Name = "billetdataGridView";
            this.billetdataGridView.Size = new System.Drawing.Size(344, 282);
            this.billetdataGridView.TabIndex = 22;
            // 
            // Afficher
            // 
            this.Afficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Afficher.Location = new System.Drawing.Point(520, 52);
            this.Afficher.Name = "Afficher";
            this.Afficher.Size = new System.Drawing.Size(107, 39);
            this.Afficher.TabIndex = 21;
            this.Afficher.Text = "Afficher";
            this.Afficher.UseVisualStyleBackColor = true;
            this.Afficher.Click += new System.EventHandler(this.Afficher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(202, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = " Informations Billets";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre Billet";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Date Delivrance";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Id Voyage";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Liste_Billet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.billetdataGridView);
            this.Controls.Add(this.Afficher);
            this.Controls.Add(this.label1);
            this.Name = "Liste_Billet";
            this.Text = "Liste_Billet";
            ((System.ComponentModel.ISupportInitialize)(this.billetdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView billetdataGridView;
        private System.Windows.Forms.Button Afficher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}