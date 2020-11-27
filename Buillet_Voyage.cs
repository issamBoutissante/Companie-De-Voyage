using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Companie_de_voyage
{
    public partial class Buillet_Voyage : Form
    {
        GererData gererData = new GererData();
        public Buillet_Voyage()
        {
            InitializeComponent();
            foreach (var reader in gererData.GetData("select id_voyage,count(n_billet) as billet from billet group by id_voyage;"))
            {
                BilletParVoyagedataGridView.Rows.Add(reader["id_voyage"], reader["billet"]);
                numroVoyage.Items.Add(reader["id_voyage"]);
            }
        }

        private void numroVoyage_SelectedIndexChanged(object sender, EventArgs e)
        {
           NombreBillet.Text= gererData.getScalar("select count(id_voyage) from billet where id_voyage=" + numroVoyage.Text);
        }
    }
}