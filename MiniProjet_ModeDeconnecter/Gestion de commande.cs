using MiniProjet_ModeDeconnecter.Entity;
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
    public partial class Gestion_de_commande : Form
    {
        public Gestion_de_commande()
        {
            InitializeComponent();
        }
        Commande c = new Commande();
       

        private void Gestion_de_commande_Load(object sender, EventArgs e)
        {
            c.ListerCommande(ListeCommande, combclient);
        }

        private void button_nouveau_Click(object sender, EventArgs e)
        {

            NumCommande.Text = "";
            combclient.Text = "";
            codeDessert.Text = "";
            dateTime.Text = "";
           
        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            int num_commande = Int32.Parse(NumCommande.Text);
            int codeClientt = Int32.Parse(combclient.Text);
            int codeDessertt = Int32.Parse(codeDessert.Text);
            DateTime date = Convert.ToDateTime(dateTime.Text);
            Commande p = new Commande(num_commande, codeClientt, date, codeDessertt);
            p.AjouterCommande();

        }
        private void button_supprimer_Click(object sender, EventArgs e)
        {
            int codeC = Int32.Parse(ListeCommande.Rows[ListeCommande.CurrentRow.Index].Cells[0].Value.ToString());
          c.DeleteCommande(codeC);


        }

      

        private void button_modifier_Click(object sender, EventArgs e)
        {
            int num_commande = Int32.Parse(NumCommande.Text);
            int codeClientt = Int32.Parse(combclient.Text);
            int codeDessertt = Int32.Parse(codeDessert.Text);
            DateTime date = Convert.ToDateTime(dateTime.Text);
            Commande p = new Commande(num_commande, codeClientt, date, codeDessertt);
            c.UpdateClient(num_commande);

        }

      /*  private void button1_Click(object sender, EventArgs e)
        {

            string num_commande = ListeCommande.Rows[ListeCommande.CurrentRow.Index].Cells[0].Value.ToString();
            string code_client = ListeCommande.Rows[ListeCommande.CurrentRow.Index].Cells[1].Value.ToString();
            string code_dessert = ListeCommande.Rows[ListeCommande.CurrentRow.Index].Cells[2].Value.ToString();
            string date = ListeCommande.Rows[ListeCommande.CurrentRow.Index].Cells[3].Value.ToString();

            NumCommande.Text = num_commande;
            combclient.Text = code_client;
            codeDessert.Text = code_dessert;
            dateTime.Text = date;

        }*/

        private void button_quitter_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void ListeCommande_RowHeaderCellChanged(object sender, DataGridViewRowEventArgs e)
        {

            string num_commande = ListeCommande.Rows[ListeCommande.CurrentRow.Index].Cells[0].Value.ToString();
            string code_client = ListeCommande.Rows[ListeCommande.CurrentRow.Index].Cells[1].Value.ToString();
            string code_dessert = ListeCommande.Rows[ListeCommande.CurrentRow.Index].Cells[2].Value.ToString();
            string date = ListeCommande.Rows[ListeCommande.CurrentRow.Index].Cells[3].Value.ToString();

            NumCommande.Text = num_commande;
            combclient.Text = code_client;
            codeDessert.Text = code_dessert;
            dateTime.Text = date;
        }

        private void ListeCommande_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string num_commande = ListeCommande.Rows[ListeCommande.CurrentRow.Index].Cells[0].Value.ToString();
            string code_client = ListeCommande.Rows[ListeCommande.CurrentRow.Index].Cells[1].Value.ToString();
            string code_dessert = ListeCommande.Rows[ListeCommande.CurrentRow.Index].Cells[2].Value.ToString();
            //string date = ListeCommande.Rows[ListeCommande.CurrentRow.Index].Cells[3].Value.ToString();

            NumCommande.Text = num_commande;
            combclient.Text = code_client;
            codeDessert.Text = code_dessert;
            //dateTime.Text = date;
        }
    }
}
