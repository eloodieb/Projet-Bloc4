using System;
using System.Windows.Forms;

namespace Projet_bloc4.Interfaces
{
    public partial class InterfaceEmployeeDetails : Form
    {
        public InterfaceEmployeeDetails()
        {
            InitializeComponent();
        }

        private void InterfaceEmployeeDetails_Load(object sender, EventArgs e)
        {






        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            home home = new home();
            this.Hide();
            home.Show();
        }

    
    }
}
