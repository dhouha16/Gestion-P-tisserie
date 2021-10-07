using MiniProjet_ModeDeconnecter.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProjet_ModeDeconnecter
{
    public partial class ligne : Form
    {
        ServiceClient p = new ServiceClient();
        public static SqlDataAdapter adapter1 = new SqlDataAdapter();
        public static BindingSource bs = new BindingSource();
        public DataTable d1 = new DataTable();
        public DataTable d2 = new DataTable();
        public DataTable d3 = new DataTable();
        public DataTable d4 = new DataTable();
        public DataTable d5 = new DataTable();
        public SqlCommandBuilder cb;
        public DataRow dr;
        public ligne()
        {
            InitializeComponent();
        }

        private void ligne_Load(object sender, EventArgs e)
        {
            ConnectionBD.Connecter();
            string sql = "Select * From [dbo].[Service];";

            SqlCommand SelectCmd = new SqlCommand(sql, ConnectionBD.con);

            ConnectionBD.adapter.SelectCommand = SelectCmd;

            ConnectionBD.adapter.Fill(ConnectionBD.ds, "Service");
            bs.DataSource = d1;
            liste.DataSource=bs;
            ConnectionBD.ds.Tables["Service"].PrimaryKey = new DataColumn[] { ConnectionBD.ds.Tables["Service"].Columns["id"] };

            liste.DataSource = ConnectionBD.ds.Tables["Service"];


            adapter1 = new SqlDataAdapter("select code_client,nom from client", ConnectionBD.con);
            adapter1.Fill(d2);
            Client.DataSource = d2;
            Client.DisplayMember = "code_client";
            Client.ValueMember = "nom";

            adapter1 = new SqlDataAdapter("select num_commande from Commande", ConnectionBD.con);
            adapter1.Fill(d3);
            numCmd.DataSource = d3;
            numCmd.DisplayMember = "num_commande";
            numCmd.ValueMember = "num_commande";

            adapter1 = new SqlDataAdapter("select code_dessert from Dessert", ConnectionBD.con);
            adapter1.Fill(d4);
            numDessert.DataSource = d4;
            numDessert.DisplayMember = "code_dessert";
            numDessert.ValueMember = "code_dessert";

            adapter1 = new SqlDataAdapter("select prix from Dessert where code_dessert ='" + numDessert.Text + "'", ConnectionBD.con);
            adapter1.Fill(d5);
            prix.DataSource = d5;
            prix.DisplayMember = "prix";
            prix.ValueMember = "prix";


        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            
            int id = Int32.Parse(idLigne.Text);
            int  numClient = Int32.Parse(Client.Text);
            int numCommande = Int32.Parse(numCmd.Text); 
            int Dessert = Int32.Parse(numDessert.Text);
            int quantite = Int32.Parse(quantiteLigne.Text);
            int prixT= Int32.Parse(prixTotale.Text);
            int prixx = Int32.Parse(prix.Text);

            ServiceClient p = new ServiceClient(id, numClient, numCommande, Dessert, quantite, prixT, prixx);

            
            p.AjouterService();
        }

        private void Client_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_modifier_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(idLigne.Text);
                int numClient = Int32.Parse(Client.Text);
                int numCommande = Int32.Parse(numCmd.Text);
                int Dessert = Int32.Parse(numDessert.Text);
                int quantite = Int32.Parse(quantiteLigne.Text);
                int prixT = Int32.Parse(prixTotale.Text);
                int prixx = Int32.Parse(prix.Text);

                ServiceClient p = new ServiceClient(id, numClient, numCommande, Dessert, quantite, prixT,prixx);
                p.UpdateClient(id);
            }catch
            { MessageBox.Show("vous avez un champ mal rempli"); }
        }

        private void button_supprimer_Click(object sender, EventArgs e)
        {
           
                int code = Int32.Parse(liste.Rows[liste.CurrentRow.Index].Cells[0].Value.ToString());
                p.DeleteClient(code);
            
        }

        private void button_nouveau_Click(object sender, EventArgs e)
        {
            prixTotale.Text = "";
            quantiteLigne.Text = "";
        }

      

        private void rechercher_Click(object sender, EventArgs e)
        {
            string req = "select * from Service where Id='" + idLigne.Text + "'";
            ConnectionBD.ds.Clear();
            ConnectionBD.adapter = new SqlDataAdapter(req, ConnectionBD.con);
            ConnectionBD.adapter.Fill(ConnectionBD.ds, "Service");
            liste.DataSource = ConnectionBD.ds.Tables["Service"];
        }

        private void GestionClient_Enter(object sender, EventArgs e)
        {

        }

      
        private void liste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      
            private void liste_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
            {
            string id = liste.Rows[liste.CurrentRow.Index].Cells[0].Value.ToString();
            string numClient = liste.Rows[liste.CurrentRow.Index].Cells[1].Value.ToString();
            string numCommande = liste.Rows[liste.CurrentRow.Index].Cells[2].Value.ToString();
            string Dessert = liste.Rows[liste.CurrentRow.Index].Cells[3].Value.ToString();
            string quantite = liste.Rows[liste.CurrentRow.Index].Cells[4].Value.ToString();
            string prixx = liste.Rows[liste.CurrentRow.Index].Cells[5].Value.ToString();
            idLigne.Text = id;
            Client.Text = numClient;
            numCmd.Text = numCommande;
            numDessert.Text = Dessert;
            quantiteLigne.Text = quantite;
            prixTotale.Text = prixx;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button_quitter_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int a, b, c;
            a = Int32.Parse(quantiteLigne.Text);
            b = Int32.Parse(prix.Text);
            c = (a * b);
            prixTotale.Text = c.ToString();



        }
    }
}
