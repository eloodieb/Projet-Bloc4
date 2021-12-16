using Projet_bloc4.GestionEmployees;
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

namespace Projet_bloc4.Interfaces.InterfaceEmployees
{
    public partial class InterfaceEmployees : Form
    {
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
            txt_service.Text = "";
            txt_site.Text= "";
            lbl_creation_date.Text = DateTime.Now.ToShortDateString();
            lbl_update_date.Text = "";


            //Chargement de la liste des différents sites
            //Connexion à la base de données
            string connexionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elodie\source\repos\Projet-bloc4\Projet-bloc4\projet4.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(connexionString);

            //Ouverture de la connexion
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Sites", con);


            //Exécute la requête sql
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txt_site.Items.Add(dr["city"]);
            }

            // Fermeture Connexion
            con.Close();

            //Chargement de la liste des différents Services
            //Ouverture de la connexion
            con.Open();
            SqlCommand cmdServices = new SqlCommand("select * from Services", con);


            //Exécute la requête sql
            SqlDataReader res;
            res = cmdServices.ExecuteReader();
            while (res.Read())
            {
                txt_service.Items.Add(res["name"]);
            }

            // Fermeture Connexion
            con.Close();
        }

        private void bt_register_Click(object sender, EventArgs e)
        {
      
          
            Employee employee = new Employee();
            employee.Name = txt_name.Text;
            employee.Firstname = txt_firstname.Text;
            employee.MobilePhone = txt_mobileNumber.Text;
            employee.PhoneNumber = txt_phoneNumber.Text;
            employee.Email = txt_email.Text;
            employee.Service = txt_service.GetItemText(txt_service.SelectedIndex);
            employee.Site = txt_site.GetItemText(txt_site.SelectedIndex);
            new GestionnaireEmployees().AddEmployee(employee);
            MessageBox.Show("Salarié ajouté");

        }

        private void bt_update_Click(object sender, EventArgs e)
        {

            try
            {
                int id = int.Parse(lbl_id.Text);
                Employee employee = new GestionnaireEmployees().SearchEmployeeById(id);
                employee.Name = txt_name.Text;
                employee.Firstname = txt_firstname.Text;
                employee.MobilePhone = txt_mobileNumber.Text;
                employee.PhoneNumber = txt_phoneNumber.Text;
                employee.Email = txt_email.Text;
                employee.Service = txt_service.Text;
                employee.Site = txt_site.Text;
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
                bt_start_Click(this, null);
            }
            catch (FormatException)
            {
                MessageBox.Show("Le lbl_id est vide");
            }
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            Employee employee = new GestionnaireEmployees().Start();
            this.Display(employee);
        }

        private void Display(Employee employee)
        {
            if(employee != null)
            {
                lbl_id.Text = employee.Id.ToString();
                txt_name.Text = employee.Name;
                txt_firstname.Text = employee.Firstname;
                txt_mobileNumber.Text = employee.MobilePhone;
                txt_phoneNumber.Text = employee.PhoneNumber;
                txt_email.Text = employee.Email;
                txt_service.Text = employee.Service;
                txt_site.Text = employee.Site;
                lbl_creation_date.Text = employee.CreationDate.ToString();

                if(employee.UpdateDate.Year != 1)
                lbl_update_date.Text = employee.UpdateDate.ToShortDateString();
            }

        }

        private void bt_previous_Click(object sender, EventArgs e)
        {
            if ( lbl_id.Text != "" && lbl_id.Text != "-")
            {
                Employee employee = new GestionnaireEmployees().Previous(int.Parse(lbl_id.Text));
                this.Display(employee);
            }

        }

        private void bt_next_Click(object sender, EventArgs e)
        {
            if (lbl_id.Text != "" && lbl_id.Text != "-")
            {
                Employee employee = new GestionnaireEmployees().Next(int.Parse(lbl_id.Text));
                this.Display(employee);
            }
        }

        private void bt_end_Click(object sender, EventArgs e)
        {
            Employee employee = new GestionnaireEmployees().End();
            this.Display(employee);
        }

    
    }
}
