using System;
using System.Windows.Forms;

namespace Companie_de_voyage
{
    public partial class Form1 : Form
    {
        GererData gererData = new GererData();
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            OpenChauffeur("ajout");
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            OpenChauffeur("supression");
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            OpenChauffeur("modification");
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            OpenChauffeur("liste");
        }
        void OpenChauffeur(string type)
        {
            Chauffeur manipulerChauffeur = new Chauffeur(type);
            manipulerChauffeur.MdiParent = this;
            manipulerChauffeur.Dock = DockStyle.Fill;
            manipulerChauffeur.Show();
        }
    }
}
