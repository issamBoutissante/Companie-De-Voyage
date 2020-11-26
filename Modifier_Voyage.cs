using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Companie_de_voyage
{
    public partial class Modifier_Voyage : Form
    {
        GererData gererData = new GererData();
        public Modifier_Voyage()
        {
            InitializeComponent();
            foreach (var chauffeur in gererData.GetData("select id_chauffeur from chauffeur"))
            {
                idChauffeur.Items.Add(chauffeur.GetSqlString(0));
            }
            foreach (var reader in gererData.GetData("select * from vehicule;"))
            {
                matricule.Items.Add(reader.GetSqlString(0));
            }
            foreach (var reader in gererData.GetData("select id_voyage from voyage;"))
            {
                id.Items.Add(reader.GetInt32(0));
            }
        }

        private void id_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var reader in gererData.GetData("select * from voyage where id_voyage='" + id.Text + "';"))
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

        private void idChauffeur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            string query = "update voyage set date_voyage=@dateVoyage, ville_depart=@villeDepart, ville_arrive=@villeArrive," +
                "duree=@duree,nbre_voyageurs=@nombreVoyageur,place_libre=@placeLibre,tarif=@tarif,id_chauffeur=@idChauffeur" +
                ",immatricule=@matricule where id_voyage=@idVoyage";
            SqlCommand command = new SqlCommand(query)
            {
                Parameters =
                {
                    new SqlParameter("@idVoyage",id.Text),
                    new SqlParameter("@dateVoyage",DateVoyage.Text),
                    new SqlParameter("@villeDepart",villeDepart.Text),
                    new SqlParameter("@villeArrive",VilleArrive.Text),
                    new SqlParameter("@duree",duree.Text),
                    new SqlParameter("@nombreVoyageur",NombresVoyageurs.Text),
                    new SqlParameter("@placeLibre",PlaceLibre.Text),
                    new SqlParameter("@tarif",Tarif.Text),
                    new SqlParameter("@idChauffeur",idChauffeur.Text),
                    new SqlParameter("@matricule",matricule.Text),
                }
            };
            MessageBox.Show(gererData.Modifier(command));
        }
    }
}
