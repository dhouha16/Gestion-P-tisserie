using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProjet_ModeDeconnecter.Entity
{
    class Dessert
    {
        private int code_dessert;
        private string nom_dessert;
        private int prix;
        PictureBox image;
        MemoryStream ms = new MemoryStream();
        public Dessert(int code_dessert, string nom_dessert,int prix,PictureBox image)
        {
            this.code_dessert = code_dessert;
            this.nom_dessert = nom_dessert;
            this.prix = prix;
            this.Image = image;

        }
        public Dessert(int code_dessert, string nom_dessert, int prix)
        {
            this.code_dessert = code_dessert;
            this.nom_dessert = nom_dessert;
            this.prix = prix;
        }
        public Dessert() { }

        public int CodeDessert { get { return code_dessert; } set { code_dessert = value; } }
        public string NomDessert { get { return nom_dessert; } set { nom_dessert = value; } }
        public int Prix { get { return prix; } set { prix = value; } }

        public PictureBox Image { get => image; set => image = value; }

        public void ListerDessert(DataGridView ListeDessert)
        {
            ConnectionBD.Connecter();


            string sql = "Select * From [dbo].[Dessert];";

            SqlCommand SelectCmd = new SqlCommand(sql, ConnectionBD.con);

            ConnectionBD.adapter.SelectCommand = SelectCmd;

            ConnectionBD.adapter.Fill(ConnectionBD.ds, "Dessert");

            ConnectionBD.ds.Tables["Dessert"].PrimaryKey = new DataColumn[] { ConnectionBD.ds.Tables["Dessert"].Columns["code_dessert"] };

            ListeDessert.DataSource = ConnectionBD.ds.Tables["Dessert"];


            ConnectionBD.Deconnecter();

        }

        public void AjouterDessert()
        {
            try
            {
                SqlCommandBuilder builder = new SqlCommandBuilder();
                //Creates a new data row
                DataRow row = ConnectionBD.ds.Tables["Dessert"].NewRow();

                image.Image.Save(ms, image.Image.RawFormat);
                byte[] img = ms.ToArray();
                row["code_dessert"] = code_dessert;
                row["nom_dessert"] = nom_dessert;
                row["prix"] = prix;
                row["image"] = img;

                //Add the data row

                ConnectionBD.ds.Tables["Dessert"].Rows.Add(row);

                // Inserts a new record
                builder.DataAdapter = ConnectionBD.adapter;
                ConnectionBD.adapter.Update(ConnectionBD.ds, "Dessert");
                MessageBox.Show("Inserted!");
            }catch
            { MessageBox.Show("vous avez un champ mal rempli"); }
}

        public void UpdateDessert(int code_dessert)
        {
            SqlCommandBuilder builder = new SqlCommandBuilder();
            DataRow CurrentRow = ConnectionBD.ds.Tables["Dessert"].Rows.Find(code_dessert);
            if (CurrentRow != null)
            {
                CurrentRow.BeginEdit();
                CurrentRow["code_dessert"] = code_dessert;
                CurrentRow["nom_dessert"] = nom_dessert;
                CurrentRow["prix"] = prix;
                CurrentRow.EndEdit();
                builder.DataAdapter = ConnectionBD.adapter;
                ConnectionBD.adapter.Update(ConnectionBD.ds, "Dessert");

            }
        }

        public void DeleteDessert(int code_client)
        {
            SqlCommandBuilder builder = new SqlCommandBuilder();

            DataRow CurrentRow = ConnectionBD.ds.Tables["Dessert"].Rows.Find(code_client);
            CurrentRow.Delete();

            builder.DataAdapter = ConnectionBD.adapter;
            ConnectionBD.adapter.Update(ConnectionBD.ds, "Dessert");


        }









    }
}
