using Projet_bloc4.GestionServices;
using Projet_bloc4.GestionSites;
using Projet_bloc4.Interfaces.InterfaceEmployees;
using Projet_bloc4.Interfaces.InterfaceServices;
using Projet_bloc4.Interfaces.InterfaceSites;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projet_bloc4
{
    public partial class home : Form
    {
        //Connexion à la base de données
        static string connexionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elodie\source\repos\Projet-bloc4\Projet-bloc4\projet4.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection con = new SqlConnection(connexionString);

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

        private void home_Load(object sender, EventArgs e)
        {
           

            SqlCommand cmd = new SqlCommand("SELECT Id, name, firstname, idService, idSite FROM Employees", con);
            con.Open();

            //Permet d'afficher la liste des clients dans la dataGrid
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridViewEmployees.DataSource = dt;

            con.Close();

            dataGridViewEmployees.Columns[0].Visible = false;

            GestionnaireServices service = new GestionnaireServices();


            foreach (Service item in service.GetServices())
            {
                var row = new string[] { item.Name };
                var lvi = new ListViewItem(row);
                lvi.Tag = item;
                listViewServices.Items.Add(lvi);

            }


            GestionnairesSites site = new GestionnairesSites();


            foreach (Site item in site.GetSites())
            {
                var row = new string[] { item.Name };
                var lvi = new ListViewItem(row);
                lvi.Tag = item;
                listViewSites.Items.Add(lvi);

            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT Id, name, firstname, idService, idSite FROM Employees where name like '%" + txt_search.Text + "%'", con);
            con.Open();
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridViewEmployees.DataSource = dt;
            con.Close(); 
        }

        private void listViewServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = (Service)listViewServices.SelectedItems[0].Tag;

                SqlCommand cmd = new SqlCommand("SELECT Id, name, firstname, idService, idSite FROM Employees where idService = '" + selectedItem.Id + "'", con);
                con.Open();
                SqlDataAdapter sdr = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                dataGridViewEmployees.DataSource = dt;
                con.Close();
            }
          
            catch
            {

            }
        }

        private void listViewSites_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = (Site)listViewSites.SelectedItems[0].Tag;

                SqlCommand cmd = new SqlCommand("SELECT Id, name, firstname, idService, idSite FROM Employees where idSite = '" + selectedItem.Id + "'", con);
                con.Open();
                SqlDataAdapter sdr = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                dataGridViewEmployees.DataSource = dt;
                con.Close();
            }

            catch
            {

            }
        }
    }
}
