using Projet_bloc4.GestionEmployees;
using Projet_bloc4.GestionServices;
using Projet_bloc4.GestionSites;
using System;
using System.Data;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace Projet_bloc4.Interfaces.InterfaceEmployees
{

    public partial class InterfaceEmployees : Form
    {
        //Connexion à la base de données
        static string connexionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elodie\source\repos\Projet-bloc4\Projet-bloc4\projet4.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection con = new SqlConnection(connexionString);

        public InterfaceEmployees()
        {
            InitializeComponent();

        }

        private void bt_add_Click(object sender, EventArgs e)
        {

            lbl_id.Text = "";
            txt_name.Text = "";
            txt_firstname.Text = "";
            txt_mobileNumber.Text = "";
            txt_phoneNumber.Text = "";
            txt_email.Text = "";
    
        }

        private void bt_register_Click(object sender, EventArgs e)
        {

            var selectedItem = (Service)listViewServices.SelectedItems[0].Tag;
            var selectedItemSite = (Site)listViewSites.SelectedItems[0].Tag;
            Employee employee = new Employee();
            employee.Name = txt_name.Text;
            employee.Firstname = txt_firstname.Text;
            employee.MobilePhone = txt_mobileNumber.Text;
            employee.PhoneNumber = txt_phoneNumber.Text;
            employee.Email = txt_email.Text;
            employee.Service = selectedItem.Id;
            employee.Site = selectedItemSite.Id;
            Console.WriteLine(selectedItem);
            Console.WriteLine(selectedItemSite);

            new GestionnaireEmployees().AddEmployee(employee);
            MessageBox.Show("Salarié ajouté");

        }

        private void bt_update_Click(object sender, EventArgs e)
        {

            try
            {
                int id = int.Parse(lbl_id.Text);
                Employee employee = new GestionnaireEmployees().SearchEmployeeById(id);
                Console.WriteLine(employee.Id.ToString());
                employee.Name = txt_name.Text;
                employee.Firstname = txt_firstname.Text;
                employee.MobilePhone = txt_mobileNumber.Text;
                employee.PhoneNumber = txt_phoneNumber.Text;
                employee.Email = txt_email.Text;

                var selectedItem = (Service)listViewServices.SelectedItems[0].Tag;
                var selectedItemSite = (Site)listViewSites.SelectedItems[0].Tag;

                employee.Service = selectedItem.Id;
                employee.Site = selectedItemSite.Id;
                new GestionnaireEmployees().UpdateEmployee(employee);
            }
            catch (FormatException)
            {
                MessageBox.Show("Le lbl_id est vide");
            }
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(lbl_id.Text);
                new GestionnaireEmployees().DeleteEmployee(id);

            }
            catch (FormatException)
            {
                MessageBox.Show("Le lbl_id est vide");
            }
        }

   

        private void InterfaceEmployees_Load(object sender, EventArgs e)
        {
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

            SqlCommand cmd = new SqlCommand("SELECT Employees.Id, Employees.name, firstname, phoneNumber, mobileNumber, email, Services.Name, Sites.City FROM Employees LEFT OUTER JOIN  Sites on (Employees.idSite = Sites.Id) LEFT OUTER JOIN  Services on (Employees.idService = Services.Id)", con);
            con.Open();


            //Permet d'afficher la liste des clients dans la dataGrid
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridViewEmployeesAdmin.DataSource = dt;

            con.Close();


        }

        private void btn_deconnexion_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.menuStrip1.Visible = false;
            this.Hide();
            home.Show();
        }

 

        private void dataGridViewEmployeesAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewEmployeesAdmin.CurrentRow.Index != -1)
            {
                lbl_id.Text = dataGridViewEmployeesAdmin.CurrentRow.Cells[0].Value.ToString();
                txt_name.Text = dataGridViewEmployeesAdmin.CurrentRow.Cells[1].Value.ToString();
                txt_firstname.Text = dataGridViewEmployeesAdmin.CurrentRow.Cells[2].Value.ToString();
                txt_mobileNumber.Text = dataGridViewEmployeesAdmin.CurrentRow.Cells[3].Value.ToString();
                txt_phoneNumber.Text = dataGridViewEmployeesAdmin.CurrentRow.Cells[4].Value.ToString();
                txt_email.Text = dataGridViewEmployeesAdmin.CurrentRow.Cells[5].Value.ToString();


            }
        }

   
    }
}
