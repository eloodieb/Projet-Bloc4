using Projet_bloc4.GestionServices;
using Projet_bloc4.GestionSites;
using Projet_bloc4.Interfaces.InterfaceEmployees;
using Projet_bloc4.Interfaces.InterfaceLogin;
using Projet_bloc4.Interfaces.InterfaceServices;
using Projet_bloc4.Interfaces.InterfaceSites;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using Projet_bloc4.Interfaces;

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
            KeyPreview = true;
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
           

            SqlCommand cmd = new SqlCommand("SELECT Employees.Id, Employees.name, firstname, Services.Name, Sites.City, phoneNumber, mobileNumber, email FROM Employees LEFT OUTER JOIN  Sites on (Employees.idSite = Sites.Id) LEFT OUTER JOIN  Services on (Employees.idService = Services.Id)", con);
            con.Open();

            //Permet d'afficher la liste des clients dans la dataGrid
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridViewEmployees.DataSource = dt;

            con.Close();

            dataGridViewEmployees.Columns[0].Visible = false;
            dataGridViewEmployees.Columns[5].Visible = false;
            dataGridViewEmployees.Columns[6].Visible = false;
            dataGridViewEmployees.Columns[7].Visible = false;

            GestionnaireServices service = new GestionnaireServices();

            listViewServices.Items.Clear();
            foreach (Service item in service.GetServices())
            {
                var row = new string[] {item.Name};
                var lvi = new ListViewItem(row);
                lvi.Tag = item;
                listViewServices.Items.Add(lvi);

            }


            GestionnairesSites site = new GestionnairesSites();


            foreach (Site item in site.GetSites())
            {
                var row = new string[] {item.Name};
                var lvi = new ListViewItem(row);
                lvi.Tag = item;
                listViewSites.Items.Add(lvi);

            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT  Employees.Id, Employees.name, firstname, Services.Name, Sites.City, phoneNumber, mobileNumber, email FROM Employees LEFT OUTER JOIN  Sites on (Employees.idSite = Sites.Id) LEFT OUTER JOIN  Services on (Employees.idService = Services.Id) where Employees.name like '%" + txt_search.Text + "%'", con);
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

                SqlCommand cmd = new SqlCommand("SELECT  Employees.Id, Employees.name, firstname, Services.Name, Sites.City, phoneNumber, mobileNumber, email FROM Employees LEFT OUTER JOIN  Sites on (Employees.idSite = Sites.Id) LEFT OUTER JOIN  Services on (Employees.idService = Services.Id)  where idService = '" + selectedItem.Id + "'", con);
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

                SqlCommand cmd = new SqlCommand("SELECT  Employees.Id, Employees.name, firstname, Services.Name, Sites.City, phoneNumber, mobileNumber, email FROM Employees LEFT OUTER JOIN  Sites on (Employees.idSite = Sites.Id) LEFT OUTER JOIN  Services on (Employees.idService = Services.Id)  where idSite = '" + selectedItem.Id + "'", con);
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

        private void home_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Control && e.Alt && e.KeyCode == Keys.K)
            {

                login loginForm = new login();
                this.Hide();
                loginForm.Show();
               
          
            }
           
        }

        public void dataGridViewEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

         InterfaceEmployeeDetails interfaceEmployeeDetails = new InterfaceEmployeeDetails();
         interfaceEmployeeDetails.txt_name.Text = dataGridViewEmployees.CurrentRow.Cells[1].Value.ToString();
         interfaceEmployeeDetails.txt_firstname.Text = dataGridViewEmployees.CurrentRow.Cells[2].Value.ToString();
         interfaceEmployeeDetails.txt_service.Text = dataGridViewEmployees.CurrentRow.Cells[3].Value.ToString();
         interfaceEmployeeDetails.txt_site.Text = dataGridViewEmployees.CurrentRow.Cells[4].Value.ToString();
         interfaceEmployeeDetails.txt_phone.Text = dataGridViewEmployees.CurrentRow.Cells[5].Value.ToString();
         interfaceEmployeeDetails.txt_mobile_phone.Text = dataGridViewEmployees.CurrentRow.Cells[6].Value.ToString();
         interfaceEmployeeDetails.txt_email.Text = dataGridViewEmployees.CurrentRow.Cells[7].Value.ToString();
            this.Hide();
         interfaceEmployeeDetails.Show();

        }
    }
}
