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
    public partial class Nombre_de_ligne : Form
    {
        GererData gererData = new GererData();
        public Nombre_de_ligne()
        {
            InitializeComponent();
            dynamic Count = gererData.CountRows();
            NombreChauffeur.Text = Count.nombreChauffeur;
            NombreVoyage.Text = Count.nombreVoyage;
            NombreVehicule.Text = Count.nombreVehicule;
            NombreBillet.Text = Count.nombreBillet;
        }
    }
}
