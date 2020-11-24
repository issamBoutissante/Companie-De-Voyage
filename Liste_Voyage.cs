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
    public partial class Liste_Voyage : Form
    {
        GererData gererData = new GererData();
        public Liste_Voyage()
        {
            InitializeComponent();
        }

        private void Afficher_Click(object sender, EventArgs e)
        {
            foreach(var reader in gererData.GetData("select * from voyage"))
            {
                VoyagedataGridView.Rows.Add(reader.GetInt32(0), reader.GetDateTime(1), reader.GetSqlString(2), reader.GetSqlString(3)
                    , reader.GetSqlDecimal(4), reader.GetInt32(5), reader.GetInt32(6), reader.GetSqlMoney(7), reader.GetSqlString(8), reader.GetSqlString(9));
            }
        }
    }
}
