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
    public partial class Ajouter_Voyage : Form
    {
        GererData gererData = new GererData();
        public Ajouter_Voyage()
        {
            InitializeComponent();
            foreach (var reader in gererData.GetData("select * from vehicule"))
            {
                matricule.Items.Add(reader.GetString(0));
            }
            foreach (var reader in gererData.GetData("select * from chauffeur"))
            {
                idChauffeur.Items.Add(reader.GetSqlString(0));
            }
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            string query = "insert into voyage values(@dateVoyage,@villeDepart,@villeArrive,@duree" +
                ",@nombreVoyageur,@placeLibre,@tarif,@idChauffeur,@matricule);";
            SqlCommand command = new SqlCommand(query) {
                Parameters =
                {
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

            MessageBox.Show(gererData.Ajout(command));
        }

    }
}
