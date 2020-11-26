using System;
using System.Windows.Forms;

namespace Companie_de_voyage
{
    public partial class Supprimer_Chauffeur : Form
    {
        GererData gererData = new GererData();
        public Supprimer_Chauffeur()
        {
            InitializeComponent();
        }
        private void Supprimer_Click(object sender, EventArgs e)
        {
            string query = "delete from chauffeur where id_chauffeur='" + id.Text + "';";
            MessageBox.Show(gererData.Supprimer(query));
        }

        private void id_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var chauffeur in gererData.GetData("select * from chauffeur where id_chauffeur='" + id.Text + "';"))
            {
                nom.Text = chauffeur.GetString(1);
                prenom.Text = chauffeur.GetString(2);
                adresse.Text = chauffeur.GetString(3);
                dateRecrutement.Value = chauffeur.GetDateTime(4);
                salaire.Text = chauffeur.GetSqlMoney(5).ToString();

            }
        }

        private void id_Click(object sender, EventArgs e)
        {
            id.Items.Clear();
            foreach (var chauffeur in gererData.GetData("select id_chauffeur from chauffeur"))
            {
                id.Items.Add(chauffeur.GetSqlString(0));
            }
        }
    }
}
