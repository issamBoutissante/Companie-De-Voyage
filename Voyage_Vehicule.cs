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
    public partial class Voyage_Vehicule : Form
    {
        GererData gererData = new GererData();
        public Voyage_Vehicule()
        {
            InitializeComponent();
            foreach (var reader in gererData.GetData("select immatricule,count(id_voyage) as nombreVoyage from voyage group by immatricule;"))
            {
               VoyageParVehiculedataGridView.Rows.Add(reader["immatricule"], reader["nombreVoyage"]);
                imatricule.Items.Add(reader["immatricule"]);
            }
        }

        private void imatricule_SelectedIndexChanged(object sender, EventArgs e)
        {
           NombreDeVoyage.Text= gererData.getScalar("select count(immatricule) from voyage where immatricule='" +imatricule.Text+"';");
        }
    }
}
