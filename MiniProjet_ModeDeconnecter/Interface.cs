using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProjet_ModeDeconnecter
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
        }

        private void Commande_Click(object sender, EventArgs e)
        {
            Gestion_de_commande c = new Gestion_de_commande();
            c.Show();

        }

        private void Service_Click(object sender, EventArgs e)
        {
            ligne l = new ligne();
            l.Show();
                
        }

        private void Dessert1_Click(object sender, EventArgs e)
        {
            Gestion_de_dessert d = new Gestion_de_dessert();
            d.Show();
        }

        private void Client_Click(object sender, EventArgs e)
        {
            Gestion_de_client g = new Gestion_de_client();
            g.Show();
   
        }
    }
}
