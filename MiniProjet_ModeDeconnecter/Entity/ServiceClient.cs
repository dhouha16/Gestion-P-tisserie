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
    class ServiceClient
    {
        private int id;
        private int numero_dessert;
        private int numero_Commande;
        private int numero_client;
        private int quantite;
        private int prixTotale;
        private int prix;
        public ServiceClient() { }
        public ServiceClient(int id,int numero_dessert, int numero_Commande, int numero_client, int quantite,int prixTotale ,int prix ) {
            this.id = id;
            this.Numero_dessert = numero_dessert;
            this.numero_client = numero_client;
            this.numero_Commande = numero_Commande;
            this.quantite = quantite;
            this.prixTotale = prixTotale;
            this.Prix = prix;
        }
        public int Id { get => id; set => id = value; }
        public int Numero_dessert { get => numero_dessert; set => numero_dessert = value; }
        public int Numero_Commande { get => numero_Commande; set => numero_Commande = value; }
        public int Numero_client { get => numero_client; set => numero_client = value; }
        public int Quantite { get => quantite; set => quantite = value; }
        public int PrixTotale { get => prixTotale; set => prixTotale = value; }
        public int Prix { get => prix; set => prix = value; }

        public void AjouterService()
        {

            SqlCommandBuilder builder = new SqlCommandBuilder();
            //Creates a new data row
            DataRow row = ConnectionBD.ds.Tables["Service"].NewRow();

            row["Id"] = Id;
            row["numero client"] = numero_client;
            row["numero commande"] = Numero_Commande;
            row["numero dessert"] = numero_dessert;
            row["quantité"] = Quantite;
            row["prix Totale"] = PrixTotale;
            row["prix"] = Prix;

            //Add the data row

            ConnectionBD.ds.Tables["Service"].Rows.Add(row);

            // Inserts a new record
            builder.DataAdapter = ConnectionBD.adapter;
            ConnectionBD.adapter.Update(ConnectionBD.ds, "Service");
            MessageBox.Show("Inserted!");
        }

        public void UpdateClient(int code_client)
        {
            SqlCommandBuilder builder = new SqlCommandBuilder();
            DataRow CurrentRow = ConnectionBD.ds.Tables["Service"].Rows.Find(id);
            if (CurrentRow != null)
            {

                CurrentRow.BeginEdit();
                CurrentRow["id"] = id;
                CurrentRow["numero client"] = Numero_dessert;
                CurrentRow["numero commande"] = Numero_Commande;
                CurrentRow["numero dessert"] = Numero_dessert;
                CurrentRow["quantité"] = quantite;
                CurrentRow["prix Totale"] = PrixTotale;
                CurrentRow["prix"] = Prix;
                CurrentRow.EndEdit();

                builder.DataAdapter = ConnectionBD.adapter;
                ConnectionBD.adapter.Update(ConnectionBD.ds, "Service");

            }
        }

        public void DeleteClient(int code_client)
        {
            SqlCommandBuilder builder = new SqlCommandBuilder();

            DataRow CurrentRow = ConnectionBD.ds.Tables["Service"].Rows.Find(id);
            CurrentRow.Delete();

            builder.DataAdapter = ConnectionBD.adapter;
            ConnectionBD.adapter.Update(ConnectionBD.ds, "Service");


        }
       

    }
    }
