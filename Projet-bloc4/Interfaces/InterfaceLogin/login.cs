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

        private bool btn_connexion_clicked = false;
        private void txt_password_TextChanged(object sender, KeyEventArgs e)
        {
            string password = "espAdmin2022";
            if (txt_password.Text == password && e.KeyCode == Keys.Enter)//|| btn_connexion_clicked = true 
            {
                home home = new home();
                this.Close();
                home.Show();
            }
        }

        private void btn_connexion_Click(object sender, EventArgs e)
        {
            btn_connexion_clicked = true;
        }
    }
}
