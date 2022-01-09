using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Projet_bloc4.Interfaces.InterfaceLogin
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "espadmin")
            {
                Console.WriteLine("la");
                home home = new home();
                home.menuStrip1.Visible = true;
                home.Show();
            }
            else
            {
                MessageBox.Show("rrr");
            }
        }
    }
}
