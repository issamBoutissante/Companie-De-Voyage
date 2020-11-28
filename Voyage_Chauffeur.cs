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
    public partial class Voyage_Chauffeur : Form
    {
        GererData gererData = new GererData();
        public Voyage_Chauffeur()
        {
            InitializeComponent();
            foreach (var reader in gererData.GetData("select id_chauffeur,count(id_voyage) as nombreVoyage from voyage group by id_chauffeur;"))
            {
                VoyageParVehiculedataGridView.Rows.Add(reader["id_chauffeur"], reader["nombreVoyage"]);
                imatricule.Items.Add(reader["id_chauffeur"]);
            }
        }

        private void imatricule_SelectedIndexChanged(object sender, EventArgs e)
        {
            NombreDeVoyage.Text = gererData.getScalar($"select count(id_chauffeur) from voyage where id_chauffeur='{imatricule.Text}';");
        }
    }
}
