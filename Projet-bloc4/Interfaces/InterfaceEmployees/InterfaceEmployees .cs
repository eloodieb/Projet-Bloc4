﻿using Projet_bloc4.GestionEmployees;
using Projet_bloc4.GestionServices;
using Projet_bloc4.GestionSites;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

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
            txt_site.Text = "";
            lbl_creation_date.Text = DateTime.Now.ToShortDateString();
            lbl_update_date.Text = "";

            //Connexion à la base de données
            GestionnairesSites site = new GestionnairesSites();

            foreach (Site p in site.GetSites())
            {

                txt_site.Items.Add(p.Id + " " +p.Name);
             
            }



            GestionnaireServices service = new GestionnaireServices();

            foreach (Service s in service.GetServices())
            {
                txt_service.Items.Add(s.Id);
              
            }


        }

        private void bt_register_Click(object sender, EventArgs e)
        {


            Employee employee = new Employee();
            employee.Name = txt_name.Text;
            employee.Firstname = txt_firstname.Text;
            employee.MobilePhone = txt_mobileNumber.Text;
            employee.PhoneNumber = txt_phoneNumber.Text;
            employee.Email = txt_email.Text;
            employee.Service = Convert.ToInt32(txt_service.SelectedItem);
            employee.Site = Convert.ToInt32(txt_site.SelectedItem);

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
                //employee.Service = txt_service.Text;
                //employee.Site = txt_site.Text;
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
            if (employee != null)
            {
                lbl_id.Text = employee.Id.ToString();
                txt_name.Text = employee.Name;
                txt_firstname.Text = employee.Firstname;
                txt_mobileNumber.Text = employee.MobilePhone;
                txt_phoneNumber.Text = employee.PhoneNumber;
                txt_email.Text = employee.Email;
  
                        
                txt_site.Text = employee.Site.ToString();
            
                lbl_creation_date.Text = employee.CreationDate.ToString();
           
                if (employee.UpdateDate.Year != 1)
                    lbl_update_date.Text = employee.UpdateDate.ToShortDateString();
            }

        }

        private void bt_previous_Click(object sender, EventArgs e)
        {
            if (lbl_id.Text != "" && lbl_id.Text != "-")
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

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sitesTableAdapter.FillBy(this.projet4DataSet.Sites);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
