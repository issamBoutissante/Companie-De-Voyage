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
    public partial class Ajouter_Vehicule : Form
    {
        GererData gererData = new GererData();
        public Ajouter_Vehicule()
        {
            InitializeComponent();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            string query = "insert into vehicule values(@matricule,@marque,@type,@dateMiseService)";
            SqlCommand command = new SqlCommand(query)
            {
                Parameters = {
                    new SqlParameter("@matricule", matricule.Text) ,
                    new SqlParameter("@marque", marque.Text),
                    new SqlParameter("@type", type.Text),
                    new SqlParameter("@dateMiseService", dateMiseService.Text),
                }
            };
            MessageBox.Show(gererData.Ajout(command));
        }
    }
}
