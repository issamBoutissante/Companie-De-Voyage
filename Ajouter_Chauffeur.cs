using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Companie_de_voyage
{
    public partial class Ajouter_Chauffeur : Form
    {
        GererData gererData = new GererData();
        public Ajouter_Chauffeur()
        {
            InitializeComponent();
        }

        private void AjouterChauffeur_Click(object sender, EventArgs e)
        {
            string query = "insert into chauffeur(id_chauffeur,nom,prenom,adresse,date_recrutement,salaire) values(@id,@nom,@prenom,@adresse,@dateRecrutement,@salaire)";
            SqlCommand command = new SqlCommand(query)
            {
                Parameters = {
                    new SqlParameter("@id", id.Text) ,
                    new SqlParameter("@nom", nom.Text),
                    new SqlParameter("@prenom", prenom.Text),
                    new SqlParameter("@adresse", adresse.Text),
                    new SqlParameter("@dateRecrutement", dateRecrutement.Value),
                    new SqlParameter("@salaire", salaire.Text)
                }
            };
            MessageBox.Show(gererData.Ajout(command));
        }
    }
}
