using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Companie_de_voyage
{
    public partial class Modifier_Vehicule : Form
    {
        GererData gererData = new GererData();
        public Modifier_Vehicule()
        {
            InitializeComponent();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            string query = "update vehicule set immatricule=@matricule,marque=@marque,type_vehicule=@type,dt_mise_service=@dateMiseService where immatricule='"+matricule.Text+"';";
            SqlCommand command = new SqlCommand(query)
            {
                Parameters = {
                    new SqlParameter("@matricule", matricule.Text) ,
                    new SqlParameter("@marque", marque.Text),
                    new SqlParameter("@type", type.Text),
                    new SqlParameter("@dateMiseService", dateMiseService.Text),
                }
            };
            MessageBox.Show(gererData.Modifier(command));
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
