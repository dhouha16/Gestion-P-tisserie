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
   
    public partial class Gestion_de_client : Form
    {
        Client p = new Client();

        public Gestion_de_client()
        {
            InitializeComponent();
        }

        private void Gestion_de_client_Load(object sender, EventArgs e)
        {
         p.ListerClient(listeClient,dessert);

        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            string Sexe;
            int code = Int32.Parse(textcodeClient.Text);
            string Nom = textnomClient.Text;
            string Prenom = prenom.Text;
            string Adresse = AdresseClient.Text;
            int telephone= Int32.Parse(numTel1.Text);
            string dessertt= dessert.Text;
            Client p = new Client(code, Nom, Prenom, Adresse,telephone, dessertt);
            p.AjouterClient();
        }

       /* private void button_modifier_Click(object sender, EventArgs e)
        {          
            int code = Int32.Parse(textcodeClient.Text);
            string Nom = textnomClient.Text;
            string Prenom = prenom.Text;
            string Adresse = AdresseClient.Text;
            int telephone = Int32.Parse(numTel1.Text);
            string dessertt = dessert.Text;
            Client p = new Client(code, Nom, Prenom, Adresse, telephone, dessertt);
            p.UpdateClient(code);
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            string code = listeClient.Rows[listeClient.CurrentRow.Index].Cells[0].Value.ToString();
            string Nom = listeClient.Rows[listeClient.CurrentRow.Index].Cells[1].Value.ToString();
            string Prenom = listeClient.Rows[listeClient.CurrentRow.Index].Cells[2].Value.ToString();
            string adresse = listeClient.Rows[listeClient.CurrentRow.Index].Cells[3].Value.ToString();
            string numTel = listeClient.Rows[listeClient.CurrentRow.Index].Cells[4].Value.ToString();
            string Dessert = listeClient.Rows[listeClient.CurrentRow.Index].Cells[5].Value.ToString();
            textcodeClient.Text = code;
            textnomClient.Text = Nom;
            prenom.Text = Prenom;
            AdresseClient.Text = adresse;
            numTel1.Text = numTel;
            dessert.Text = Dessert;
        }


        private void button_supprimer_Click(object sender, EventArgs e)
        {
            int code = Int32.Parse(listeClient.Rows[listeClient.CurrentRow.Index].Cells[0].Value.ToString());
            p.DeleteClient(code);
        }




        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ListeDessert_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void button_nouveau_Click(object sender, EventArgs e)
        {
            textcodeClient.Text = "";
            textnomClient.Text = "";
            prenom.Text = "";
            AdresseClient.Text = "";
            numTel1.Text = "";
            textcodeClient.Focus();
        }

        private void listeClient_RowHeaderCellChanged(object sender, DataGridViewRowEventArgs e)
        {

            string code = listeClient.Rows[listeClient.CurrentRow.Index].Cells[0].Value.ToString();
            string Nom = listeClient.Rows[listeClient.CurrentRow.Index].Cells[1].Value.ToString();
            string Prenom = listeClient.Rows[listeClient.CurrentRow.Index].Cells[2].Value.ToString();
            string adresse = listeClient.Rows[listeClient.CurrentRow.Index].Cells[3].Value.ToString();
            string numTel = listeClient.Rows[listeClient.CurrentRow.Index].Cells[4].Value.ToString();
            string Dessert = listeClient.Rows[listeClient.CurrentRow.Index].Cells[5].Value.ToString();
            textcodeClient.Text = code;
            textnomClient.Text = Nom;
            prenom.Text = Prenom;
            AdresseClient.Text = adresse;
            numTel1.Text = numTel;
            dessert.Text = Dessert;
        }

/*private void rechercher_Click(object sender, EventArgs e)
        {
            string req = "select * from client where code_client='" + textnomClient.Text + "'";
            ConnectionBD.ds.Clear();
            ConnectionBD.adapter = new SqlDataAdapter(req, ConnectionBD.con);
            ConnectionBD.adapter.Fill(ConnectionBD.ds, "client");
            listeClient.DataSource = ConnectionBD.ds.Tables["client"];
        }*/

        private void button_quitter_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }
    }



    }

