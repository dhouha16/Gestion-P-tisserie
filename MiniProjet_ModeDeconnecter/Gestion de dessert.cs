using MiniProjet_ModeDeconnecter.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProjet_ModeDeconnecter
{
    public partial class Gestion_de_dessert : Form
    {
        public Gestion_de_dessert()
        {
            InitializeComponent();
        }
        Dessert d = new Dessert();

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Gestion_de_commande_Load(object sender, EventArgs e)
        {
            DataGridViewImageColumn Image = new DataGridViewImageColumn();
            Image.ImageLayout = DataGridViewImageCellLayout.Stretch;
            ListeDessert.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ListeDessert.RowTemplate.Height = 120;
            //ListeDessert.AllowUserToAddRows = false;
            d.ListerDessert(ListeDessert);
        }

        private void choisir_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "choisir le choix du jour (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
            }
        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            try
            {
            int code_dessert = Int32.Parse(textcodeDessert.Text);
            string nom_dessert = textnomDessert.Text;
            int priix = Int32.Parse(prix.Text);
            PictureBox image = pictureBox1;
            Dessert p = new Dessert(code_dessert, nom_dessert, priix, image);
            p.AjouterDessert();
                 }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
                    }           
        }

        private void button_modifier_Click(object sender, EventArgs e)
        {
            int code_dessert = Int32.Parse(textcodeDessert.Text);
            string nom_dessert = textnomDessert.Text;
            int prixx = Int32.Parse(prix.Text);
            
            Dessert c = new Dessert(code_dessert, nom_dessert, prixx);
           c.UpdateDessert(code_dessert);
        }

        private void button_supprimer_Click(object sender, EventArgs e)
        {

            int code = Int32.Parse(ListeDessert.Rows[ListeDessert.CurrentRow.Index].Cells[0].Value.ToString());
            d.DeleteDessert(code);
        }

        private void ListeDessert_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button_quitter_Click(object sender, EventArgs e)
        {
            Form1 d = new Form1();
                d.Show();
        }

        private void ListeDessert_RowHeaderCellChanged(object sender, DataGridViewRowEventArgs e)
        {
            string code_dessert = ListeDessert.Rows[ListeDessert.CurrentRow.Index].Cells[0].Value.ToString();
            string nom_dessert = ListeDessert.Rows[ListeDessert.CurrentRow.Index].Cells[1].Value.ToString();
            string prixx = ListeDessert.Rows[ListeDessert.CurrentRow.Index].Cells[2].Value.ToString();
            //string image = ListeDessert.Rows[ListeDessert.CurrentRow.Index].Cells[3].Value.ToString();

            textcodeDessert.Text = code_dessert;
            textnomDessert.Text = nom_dessert;
            prix.Text = prixx;
            // AdresseClient.Text = image;

        }

        private void ListeDessert_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string code_dessert = ListeDessert.Rows[ListeDessert.CurrentRow.Index].Cells[0].Value.ToString();
            string nom_dessert = ListeDessert.Rows[ListeDessert.CurrentRow.Index].Cells[1].Value.ToString();
            string prixx = ListeDessert.Rows[ListeDessert.CurrentRow.Index].Cells[2].Value.ToString();
            string prixTotalee = ListeDessert.Rows[ListeDessert.CurrentRow.Index].Cells[3].Value.ToString();

            textcodeDessert.Text = code_dessert;
            textnomDessert.Text = nom_dessert;
            prix.Text = prixx;
            //prixTotale.Text = prixx;
            // AdresseClient.Text = image;

        }

        private void button_nouveau_Click(object sender, EventArgs e)
        {
            textcodeDessert.Text = "";
            textnomDessert.Text = "";
            prix.Text = "";
            pictureBox1.Image = null;

        }
    }
}
