using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace MiniProjet_ModeDeconnecter.Entity
{
    class Client
    {
        public static SqlDataAdapter adapter1 = new SqlDataAdapter();
        public DataTable d1 = new DataTable();
        private int code_client;
        private string nom_client;
        private string prenom_client;
        private string adresse;
        private Int64 num_tel;
        private string nom_dessert;

        public Client()
        {
           
        }
        public Client(int code_client, string nom_client, string prenom_client, string adresse, int num_tel,string nom_dessert)
        {
            this.code_client = code_client;
            this.nom_client = nom_client;
            this.prenom_client = prenom_client;
            this.adresse = adresse;
            this.num_tel = num_tel;
            this.nom_dessert = nom_dessert;
        }

        public int CodeClient { get { return code_client; } set { code_client = value; } }
        public string NomClient { get { return nom_client; } set { nom_client = value; } }
        public string PrenomClient { get { return prenom_client; } set { prenom_client = value; } }
        public string Adresse { get { return adresse; } set { adresse = value; } }
        public Int64 Num_tel { get { return num_tel; } set { num_tel = value; } }

        public string Nom_dessert { get => nom_dessert; set => nom_dessert = value; }

        public void ListerClient(DataGridView listeClient, ComboBox dessert)
        {
            ConnectionBD.Connecter();
         


            string sql = "Select * From [dbo].[client];";

            SqlCommand SelectCmd = new SqlCommand(sql, ConnectionBD.con);

            ConnectionBD.adapter.SelectCommand = SelectCmd;

            ConnectionBD.adapter.Fill(ConnectionBD.ds, "client");

            ConnectionBD.ds.Tables["client"].PrimaryKey = new DataColumn[] { ConnectionBD.ds.Tables["client"].Columns["code_client"] };

            listeClient.DataSource = ConnectionBD.ds.Tables["client"];


            adapter1 = new SqlDataAdapter("select nom_dessert from Dessert", ConnectionBD.con);
            adapter1.Fill(d1);
            dessert.DataSource = d1;
            dessert.DisplayMember = "nom_dessert";
            dessert.ValueMember = "nom_dessert";


            ConnectionBD.Deconnecter();

        }

        public void AjouterClient()
        {

            SqlCommandBuilder builder = new SqlCommandBuilder();
            //Creates a new data row
            DataRow row = ConnectionBD.ds.Tables["client"].NewRow();

            row["code_client"] = code_client;
            row["nom"] = nom_client;
            row["prenom"] = prenom_client;
            row["adresse"] = adresse;
            row["num_tel"] = num_tel;
            row["nom_dessert"] = nom_dessert;

            //Add the data row

            ConnectionBD.ds.Tables["client"].Rows.Add(row);

            // Inserts a new record
            builder.DataAdapter = ConnectionBD.adapter;
            ConnectionBD.adapter.Update(ConnectionBD.ds, "client");
            MessageBox.Show("Inserted!");
        }

        public void UpdateClient(int code_client)
        {
            SqlCommandBuilder builder = new SqlCommandBuilder();


            DataRow CurrentRow = ConnectionBD.ds.Tables["client"].Rows.Find(code_client);
            if (CurrentRow != null)
            {

                CurrentRow.BeginEdit();
                CurrentRow["code_client"] = code_client;
                CurrentRow["nom"] = nom_client;
                CurrentRow["prenom"] = prenom_client;
                CurrentRow["adresse"] = adresse;
                CurrentRow["num_tel"] = num_tel;
                CurrentRow["nom_dessert"] = nom_dessert;
                CurrentRow.EndEdit();

                builder.DataAdapter = ConnectionBD.adapter;
                ConnectionBD.adapter.Update(ConnectionBD.ds, "client");

            }




        }

        public void DeleteClient(int code_client)
        {
            SqlCommandBuilder builder = new SqlCommandBuilder();

            DataRow CurrentRow = ConnectionBD.ds.Tables["client"].Rows.Find(code_client);
            CurrentRow.Delete();

            builder.DataAdapter = ConnectionBD.adapter;
            ConnectionBD.adapter.Update(ConnectionBD.ds, "client");


        }







    }

}
