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
    public partial class Liste_Vehicule : Form
    {
        GererData gererData = new GererData();
        public Liste_Vehicule()
        {
            InitializeComponent();
        }

        private void Afficher_Click(object sender, EventArgs e)
        {
            foreach (var chauffeur in gererData.GetData("select * from vehicule;"))
            {
                viheculedataGridView.Rows.Add(chauffeur.GetSqlString(0), chauffeur.GetSqlString(1),
                    chauffeur.GetSqlString(2), chauffeur.GetDateTime(3));
            }
        }
    }
}
