using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProjet_ModeDeconnecter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListeDessert d = new ListeDessert();
            d.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Connection g = new Connection();
            g.Show();

        }

        

     
        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

      
    }
}
