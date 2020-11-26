using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Companie_de_voyage
{
    public partial class Suprimer_Billet : Form
    {
        GererData gererData = new GererData();
        public Suprimer_Billet()
        {
            InitializeComponent();
        }

        private void nombreBillet_Click(object sender, EventArgs e)
        {
            nombreBillet.Items.Clear();
            foreach(var reader in gererData.GetData("select n_billet from billet"))
            {
                nombreBillet.Items.Add(reader.GetInt32(0));
            }
        }

        private void nombreBillet_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var reader in gererData.GetData("select * from billet"))
            {
                dateDelivrance.Value = reader.GetDateTime(1);
                idVoyage.Text = reader.GetInt32(2).ToString();
            }
        }

        private void Suprimer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(gererData.Supprimer("delete from billet where n_billet="+nombreBillet.Text+";"));
        }
    }
}
