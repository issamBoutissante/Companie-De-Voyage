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
    public partial class Liste_Chauffeur : Form
    {
        GererData gererData = new GererData();
        public Liste_Chauffeur()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var chauffeur in gererData.GetData("select * from chauffeur;"))
            {
                chauffeurdataGridView.Rows.Add(chauffeur["id_chauffeur"], chauffeur["nom"],
                    chauffeur["prenom"], chauffeur["adresse"], chauffeur["date_recrutement"], chauffeur["salaire"]);

            }
        }
    }
}
