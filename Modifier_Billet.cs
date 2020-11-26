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
    public partial class Modifier_Billet : Form
    {
        GererData gererData = new GererData();
        public Modifier_Billet()
        {
            InitializeComponent();
            foreach (var reader in gererData.GetData("select n_billet from billet"))
            {
                nombreBillet.Items.Add(reader.GetInt32(0));
            }
            foreach (var reader in gererData.GetData("select id_voyage from voyage"))
            {
                idVoyage.Items.Add(reader.GetInt32(0));
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            string query = "update billet set date_delivrance=@dateDelivrance,id_voyage=@idVoyage where n_billet=@nBillet";
            SqlCommand command = new SqlCommand(query)
            {
                Parameters =
                {
                     new SqlParameter("@nBillet",nombreBillet.Text),
                     new SqlParameter("@dateDelivrance",dateDelivrance.Text),
                     new SqlParameter("@idVoyage",idVoyage.Text),
                }
            };
            MessageBox.Show(gererData.Modifier(command));
            ;
        }

        private void nombreBillet_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var reader in gererData.GetData("select * from billet"))
            {
                dateDelivrance.Value = reader.GetDateTime(1);
                idVoyage.Text = reader.GetInt32(2).ToString();
            }
        }
    }
}
