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
    public partial class ListeCLient : Form
    {
        Client p = new Client();

        public static SqlDataAdapter adapter1 = new SqlDataAdapter();
        public DataTable d1 = new DataTable();
        public ListeCLient()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListeCLient_Load(object sender, EventArgs e)
        {

            ConnectionBD.Connecter();



            string sql = "Select * From [dbo].[client];";

            SqlCommand SelectCmd = new SqlCommand(sql, ConnectionBD.con);

            ConnectionBD.adapter.SelectCommand = SelectCmd;

            ConnectionBD.adapter.Fill(ConnectionBD.ds, "client");

            ConnectionBD.ds.Tables["client"].PrimaryKey = new DataColumn[] { ConnectionBD.ds.Tables["client"].Columns["code_client"] };

            listeC.DataSource = ConnectionBD.ds.Tables["client"];
            adapter1 = new SqlDataAdapter("select nom_dessert from Dessert", ConnectionBD.con);
            adapter1.Fill(d1);
            dessert.DataSource = d1;
            dessert.DisplayMember = "nom_dessert";
            dessert.ValueMember = "nom_dessert";




            ConnectionBD.Deconnecter();
        }

        private void rechercher_Click(object sender, EventArgs e)
        {
            string req = "select * from client where code_client='" + recherche.Text + "'";
            ConnectionBD.ds.Clear();
            ConnectionBD.adapter = new SqlDataAdapter(req, ConnectionBD.con);
            ConnectionBD.adapter.Fill(ConnectionBD.ds, "client");
            listeC.DataSource = ConnectionBD.ds.Tables["client"];
        }

        private void button_modifier_Click(object sender, EventArgs e)
        {
            int code = Int32.Parse(textcodeClient.Text);
            string Nom = textnomClient.Text;
            string Prenom = prenom.Text;
            string Adresse = AdresseClient.Text;
            int telephone = Int32.Parse(numTel1.Text);
            string dessertt = dessert.Text;
            Client p = new Client(code, Nom, Prenom, Adresse, telephone, dessertt);
            p.UpdateClient(code);
        }

        private void button_supprimer_Click(object sender, EventArgs e)
        {

            int code = Int32.Parse(listeC.Rows[listeC.CurrentRow.Index].Cells[0].Value.ToString());
            p.DeleteClient(code);
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

        private void button_quitter_Click(object sender, EventArgs e)
        {
            Form1 j = new Form1();
            j.Show();
        }

        private void listeC_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string code = listeC.Rows[listeC.CurrentRow.Index].Cells[0].Value.ToString();
            string Nom = listeC.Rows[listeC.CurrentRow.Index].Cells[1].Value.ToString();
            string Prenom = listeC.Rows[listeC.CurrentRow.Index].Cells[2].Value.ToString();
            string adresse = listeC.Rows[listeC.CurrentRow.Index].Cells[3].Value.ToString();
            string numTel = listeC.Rows[listeC.CurrentRow.Index].Cells[4].Value.ToString();
            string Dessert = listeC.Rows[listeC.CurrentRow.Index].Cells[5].Value.ToString();
            textcodeClient.Text = code;
            textnomClient.Text = Nom;
            prenom.Text = Prenom;
            AdresseClient.Text = adresse;
            numTel1.Text = numTel;
            dessert.Text = Dessert;
        }
    }
}
