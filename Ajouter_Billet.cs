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
    public partial class Ajouter_Billet : Form
    {
        GererData gererData = new GererData();
        public Ajouter_Billet()
        {
            InitializeComponent();
            foreach (var reader in gererData.GetData("select id_voyage from voyage;"))
            {
                idVoyage.Items.Add(reader.GetInt32(0));
            }
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            string query = "insert into billet values(@nBillet,@dateDelivrance,@idVoyage)";
            SqlCommand command = new SqlCommand(query)
            {
                Parameters =
                {
                     new SqlParameter("@nBillet",nobreBillet.Text),
                     new SqlParameter("@dateDelivrance",dateDelivrance.Text),
                     new SqlParameter("@idVoyage",idVoyage.Text),
                }
            };
            MessageBox.Show(gererData.Ajout(command));
            
        }
    }
}
