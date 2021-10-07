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
    public partial class Connection : Form
    {
        public Connection()
        {
            InitializeComponent();
        }

        

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 admin = new Form1();
            admin.Show();
        }

        private void Connection_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            ConnectionBD.Connecter();
            SqlDataAdapter da = new SqlDataAdapter("Select Count(*) From connection where login='" + login.Text + "' and password = '" + password.Text + "'", ConnectionBD.con);
            DataTable dt = new DataTable();
            da.Fill(ConnectionBD.ds);
            if (login.Text.ToString().Equals("admin") && password.Text.ToString().Equals("root"))
            {

                this.Hide();
                Interface admin = new Interface();
                admin.Show();

            }
            else
            {
                MessageBox.Show("verifiez votre données!");
            }

        }
    }
}
