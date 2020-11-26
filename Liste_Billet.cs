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
    public partial class Liste_Billet : Form
    {
        GererData gererData = new GererData();
        public Liste_Billet()
        {
            InitializeComponent();
        }

        private void Afficher_Click(object sender, EventArgs e)
        {
            foreach(var reader in gererData.GetData("select * from billet"))
            {
                billetdataGridView.Rows.Add(reader.GetInt32(0), reader.GetDateTime(1), reader.GetInt32(2));
            }
        }
    }
}
