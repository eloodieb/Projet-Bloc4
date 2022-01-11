using System;
using System.Windows.Forms;


namespace Projet_bloc4.Interfaces.InterfaceLogin
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();

        }


        private void btn_connexion_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "espadmin")
            {
         
                home home = new home();
                home.menuStrip1.Visible = true;
                this.Hide();
                home.Show();
            }
            else
            {
                MessageBox.Show("Mot de passe incorrect");
            }
        }
    }
}
