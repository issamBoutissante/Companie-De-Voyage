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
    public partial class Modifier_Chauffeur : Form
    {
        GererData gererData = new GererData();
        public Modifier_Chauffeur()
        {
            InitializeComponent();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            string query = "update chauffeur set nom=@nom,prenom=@prenom,adresse=@adresse,date_recrutement=@dateRecrutement,salaire=@salaire where id_chauffeur=@id;";
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
            MessageBox.Show(gererData.Modifier(command));
        }

        private void id_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var chauffeur in gererData.GetData("select * from chauffeur where id_chauffeur='"+id.Text+"';"))
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
            foreach (var chauffeur in gererData.GetData("select * from chauffeur"))
            {
                id.Items.Add(chauffeur.GetSqlString(0));
            }
        }
    }
}
