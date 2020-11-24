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
    public partial class Suprimer_Voyage : Form
    {
        GererData gererData = new GererData();
        public Suprimer_Voyage()
        {
            InitializeComponent();
        }

        private void id_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var reader in gererData.GetData("select * from voyage where id_chauffeur='" + id.Text + "';"))
            {
                DateVoyage.Value = reader.GetDateTime(1);
                villeDepart.Text = reader.GetString(2);
                VilleArrive.Text = reader.GetString(3);
                duree.Text = reader.GetDecimal(4).ToString();
                NombresVoyageurs.Text = reader.GetInt32(5).ToString();
                PlaceLibre.Text = reader.GetInt32(6).ToString();
                Tarif.Text = reader.GetSqlMoney(7).ToString();
                idChauffeur.Text = reader.GetString(8);
                matricule.Text = reader.GetString(9);
            }
        }

        private void Suprimer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(gererData.Supprimer("delete from voyage where id_voyage=" + id.Text + ";"));
        }

        private void id_Click(object sender, EventArgs e)
        {
            id.Items.Clear();
            foreach (var reader in gererData.GetData("select id_voyage from voyage;"))
            {
                id.Items.Add(reader.GetInt32(0));
            }
        }
    }
}
