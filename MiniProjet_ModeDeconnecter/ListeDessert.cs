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
    public partial class ListeDessert : Form
    {
        public ListeDessert()
        {
            InitializeComponent();
        }

        public static DataTable DataSource { get; private set; }

        private void ListeDessert_Load(object sender, EventArgs e)
        {
            ConnectionBD.Connecter();


            string sql = "Select * From [dbo].[Dessert];";

            SqlCommand SelectCmd = new SqlCommand(sql, ConnectionBD.con);

            ConnectionBD.adapter.SelectCommand = SelectCmd;

            ConnectionBD.adapter.Fill(ConnectionBD.ds, "Dessert");

            ConnectionBD.ds.Tables["Dessert"].PrimaryKey = new DataColumn[] { ConnectionBD.ds.Tables["Dessert"].Columns["code_dessert"] };

            liste.DataSource = ConnectionBD.ds.Tables["Dessert"];


            ConnectionBD.Deconnecter();
            liste.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 18, FontStyle.Bold);
            liste.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 18, FontStyle.Bold);
            liste.Columns[2].HeaderCell.Style.Font = new Font("Tahoma", 18, FontStyle.Bold);
            liste.Columns[3].HeaderCell.Style.Font = new Font("Tahoma", 18, FontStyle.Bold);

            liste.Columns[0].HeaderCell.Style.ForeColor = Color.MediumVioletRed;
            liste.Columns[1].HeaderCell.Style.ForeColor = Color.MediumVioletRed;
            liste.Columns[2].HeaderCell.Style.ForeColor = Color.MediumVioletRed;
            liste.Columns[3].HeaderCell.Style.ForeColor = Color.MediumVioletRed;
        }

        private void rechercher1_Click(object sender, EventArgs e)
        {
            string req = "select * from Dessert where nom_dessert='" + recherche.Text + "'";
            ConnectionBD.ds.Clear();
            ConnectionBD.adapter = new SqlDataAdapter(req, ConnectionBD.con);
            ConnectionBD.adapter.Fill(ConnectionBD.ds, "Dessert");
            liste.DataSource = ConnectionBD.ds.Tables["Dessert"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gestion_de_client j = new Gestion_de_client();
            j.Show();
        }
    }
}
