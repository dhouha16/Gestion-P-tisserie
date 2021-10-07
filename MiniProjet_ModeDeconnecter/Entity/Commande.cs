using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProjet_ModeDeconnecter.Entity
{
    class Commande
    {
        public static SqlDataAdapter adapter1 = new SqlDataAdapter();
        public DataTable d1 = new DataTable();
        int num_commande;
        int code_dessert;
        DateTime date_commande;
        int code_client;
        public Commande()
        {

        }
        public Commande(int num_commande, int code_dessert, DateTime date_commande, int code_client)
        {
            this.Num_commande = num_commande;
            this.code_dessert = code_dessert;
            this.date_commande = date_commande;
            this.code_client = code_client;

        }

        public int Code_dessert { get => code_dessert; set => code_dessert = value; }
        public DateTime Date_commande { get => date_commande; set => date_commande = value; }
        public int Code_client { get => code_client; set => code_client = value; }
        public int Num_commande { get => num_commande; set => num_commande = value; }

        public void ListerCommande(DataGridView ListeCommande, ComboBox combclient)
        {
            ConnectionBD.Connecter();


            string sql = "Select * From [dbo].[Commande];";

            SqlCommand SelectCmd = new SqlCommand(sql, ConnectionBD.con);

            ConnectionBD.adapter.SelectCommand = SelectCmd;

            ConnectionBD.adapter.Fill(ConnectionBD.ds, "Commande");

            ConnectionBD.ds.Tables["Commande"].PrimaryKey = new DataColumn[] { ConnectionBD.ds.Tables["Commande"].Columns["num_commande"] };

           ListeCommande.DataSource = ConnectionBD.ds.Tables["Commande"];

            adapter1 = new SqlDataAdapter("select code_client from client", ConnectionBD.con);
            adapter1.Fill(d1);
            combclient.DataSource = d1;
            combclient.DisplayMember = "code_client";
            combclient.ValueMember = "code_client";



            ConnectionBD.Deconnecter();

        }

        public void AjouterCommande()
        {

            SqlCommandBuilder builder = new SqlCommandBuilder();
            //Creates a new data row
            DataRow row = ConnectionBD.ds.Tables["Commande"].NewRow();

            row["num_commande"] = num_commande;
            row["date_commande"] = date_commande;
            row["code_dessert"] = code_dessert;
            row["code_client"] = code_client;
          

            //Add the data row

            ConnectionBD.ds.Tables["Commande"].Rows.Add(row);

            // Inserts a new record
            builder.DataAdapter = ConnectionBD.adapter;
            ConnectionBD.adapter.Update(ConnectionBD.ds, "Commande");
            MessageBox.Show("Inserted!");
        }

       public void DeleteCommande(int num_commande)
        {
            SqlCommandBuilder builder = new SqlCommandBuilder();

            DataRow CurrentRow = ConnectionBD.ds.Tables["Commande"].Rows.Find(num_commande);
            CurrentRow.Delete();

            builder.DataAdapter = ConnectionBD.adapter;
            ConnectionBD.adapter.Update(ConnectionBD.ds, "Commande");

        }

        public void UpdateClient(int num_commande)
        {
            SqlCommandBuilder builder = new SqlCommandBuilder();


            DataRow CurrentRow = ConnectionBD.ds.Tables["client"].Rows.Find(num_commande);
            if (CurrentRow != null)
            {

                CurrentRow.BeginEdit();
                CurrentRow["code_client"] = code_client;
                CurrentRow["num_commande"] = num_commande;
                CurrentRow["code_dessert"] = code_dessert;
                CurrentRow["date_commande"] = date_commande;
                CurrentRow.EndEdit();

                builder.DataAdapter = ConnectionBD.adapter;
                ConnectionBD.adapter.Update(ConnectionBD.ds, "Commande");

            }


        }



    }
}
