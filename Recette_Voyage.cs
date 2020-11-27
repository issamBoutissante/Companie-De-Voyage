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
    public partial class Recette_Voyage : Form
    {
        GererData gererData = new GererData();

        public Recette_Voyage()
        {
            InitializeComponent();
            foreach (var reader in gererData.GetData("select id_voyage,nbre_voyageurs*tarif as recette from voyage;"))
            {
                RecetteParVoyagedataGridView.Rows.Add(reader["id_voyage"], reader["recette"]);
                NumeroVoyage.Items.Add(reader["id_voyage"]);
            }
        }

        private void NumeroVoyage_SelectedIndexChanged(object sender, EventArgs e)
        {
            Recette.Text= gererData.getScalar("select nbre_voyageurs*tarif from voyage where id_voyage=" + NumeroVoyage.Text + ";");   
        }
    }
}
