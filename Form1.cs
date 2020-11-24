using System;
using System.Windows.Forms;

namespace Companie_de_voyage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            OpenForm(new Ajouter_Chauffeur());
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            OpenForm(new Supprimer_Chauffeur());
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            OpenForm(new Modifier_Chauffeur());
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            OpenForm(new Liste_Chauffeur());
        }
        void OpenForm(Form newForm)
        {
            if (this.ActiveMdiChild != null) this.ActiveMdiChild.Close();
            newForm.MdiParent = this;
            newForm.Dock = DockStyle.Fill;
            newForm.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            OpenForm(new Liste_Vehicule());
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            OpenForm(new Ajouter_Vehicule());

        }
        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            OpenForm(new Suprimer_Vehicule());
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            OpenForm(new Modifier_Vehicule());
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OpenForm(new Liste_Voyage());
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            OpenForm(new Ajouter_Voyage());
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            OpenForm(new Suprimer_Voyage());
        }
    }
}
