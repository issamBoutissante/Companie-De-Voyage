using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Companie_de_voyage
{
    public partial class Chauffeur : Form
    {
        GererData gererData = new GererData();
        public Chauffeur(string type)
        {
            InitializeComponent();
            switch (type)
            {
                case "ajout":
                    ShowAjout();
                    break;
                case "supression":
                    ShowSupprission();
                    break;
                case "liste":
                    ShowListe();
                    break;
                case "modification":
                    ShowModification();
                    break;
            }
        }

        private void AjouterChauffeur_Click(object sender, EventArgs e)
        {
            string query = "insert into chauffeur(id_chauffeur,nom,prenom,adresse,date_recrutement,salaire) values(@id,@nom,@prenom,@adresse,@dateRecrutement,@salaire)";
            SqlCommand command = new SqlCommand(query) 
            {
                Parameters = {
                    new SqlParameter("@id", idChauffeur.Text) ,
                    new SqlParameter("@nom", nomChauffeur.Text),
                    new SqlParameter("@prenom", prenomChauffeur.Text),
                    new SqlParameter("@adresse", adresseChauffeur.Text),
                    new SqlParameter("@dateRecrutement", dateRecrutementChauffeur.Value),
                    new SqlParameter("@salaire", salaireChauffeur.Text)
                } 
            };
            MessageBox.Show(gererData.Ajout(command));
        }

        private void SupprimerChaffaur_Click(object sender, EventArgs e)
        {
            string query = "delete from chauffeur where id_chauffeur="+idChauffeur.Text+";";
            MessageBox.Show(gererData.Supprimer(query));
        }
        void ShowSupprission()
        {
            foreach (Control control in this.Controls)
            {
                control.Visible = false;
            }
            idChauffeurLabel.Visible = true;
            idChauffeur.Visible = true;
            SupprimerChaffaur.Visible = true;
        }
        void ShowListe()
        {
            foreach(Control control in this.Controls)
            {
                control.Visible = false;
            }
            chauffeurdataGridView.Size = new Size(645, 282);
            chauffeurdataGridView.Location = new Point(65, 45);
            chauffeurdataGridView.Visible = true;
            foreach(var chauffeur in gererData.GetData("select * from chauffeur;"))
            {
                chauffeurdataGridView.Rows.Add(chauffeur.GetSqlString(0), chauffeur.GetSqlString(1),chauffeur.GetSqlString(2),
                    chauffeur.GetSqlString(3),chauffeur.GetDateTime(4),chauffeur.GetSqlMoney(5));
            }
        }
        void ShowAjout()
        {
            chauffeurdataGridView.Visible = false;
            ModiffierChauffeur.Visible = false;
            SupprimerChaffaur.Visible = false;
        }
        void ShowModification()
        {
            chauffeurdataGridView.Visible = false;
            AjouterChauffeur.Visible = false;
            SupprimerChaffaur.Visible = false;
        }

        private void ModiffierChauffeur_Click(object sender, EventArgs e)
        {
            string query = "update chauffeur set nom=@nom,prenom=@prenom,adresse=@adresse,date_recrutement=@dateRecrutement,salaire=@salaire where id_chauffeur=@id;";
            SqlCommand command = new SqlCommand(query)
            {
                Parameters = {
                    new SqlParameter("@id", idChauffeur.Text) ,
                    new SqlParameter("@nom", nomChauffeur.Text),
                    new SqlParameter("@prenom", prenomChauffeur.Text),
                    new SqlParameter("@adresse", adresseChauffeur.Text),
                    new SqlParameter("@dateRecrutement", dateRecrutementChauffeur.Value),
                    new SqlParameter("@salaire", salaireChauffeur.Text)
                }
            };
            MessageBox.Show(gererData.Modifier(command));
        }
    }
}
