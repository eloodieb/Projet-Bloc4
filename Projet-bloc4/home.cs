using Projet_bloc4.Interfaces.InterfaceEmployees;
using Projet_bloc4.Interfaces.InterfaceServices;
using Projet_bloc4.Interfaces.InterfaceSites;
using System;
using System.Windows.Forms;

namespace Projet_bloc4
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void gérerLesSitesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Permet de naviguer sur la page Sites
            InterfaceSites form = new InterfaceSites();
            form.Show();
        }

        private void gérerLesServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfaceServices form = new InterfaceServices();
            form.Show();
        }

        private void gérerLesSalariésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfaceEmployees form = new InterfaceEmployees();
            form.Show();
        }
    }
}
