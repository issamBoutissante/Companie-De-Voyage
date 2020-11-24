using System;
using System.Windows.Forms;

namespace Companie_de_voyage
{
    public partial class Suprimer_Vehicule : Form
    {
        GererData gererData = new GererData();
        public Suprimer_Vehicule()
        {
            InitializeComponent();
        }

        private void matricule_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var reader in gererData.GetData("select marque,type_vehicule,dt_mise_service from vehicule  where immatricule='" + matricule.Text + "';"))
            {
                marque.Text = reader.GetString(0);
                type.Text = reader.GetString(1);
                dateMiseService.Value = reader.GetDateTime(2);
            }
        }

        private void Suprimer_Click(object sender, EventArgs e)
        {
            string query = "delete from vehicule where immatricule='" + matricule.Text + "';";
            MessageBox.Show(gererData.Supprimer(query));
        }

        private void matricule_Click(object sender, EventArgs e)
        {
            matricule.Items.Clear();
            foreach (var reader in gererData.GetData("select * from vehicule;"))
            {
                matricule.Items.Add(reader.GetSqlString(0));
            }
        }
    }
}
