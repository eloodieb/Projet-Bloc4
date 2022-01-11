using Projet_bloc4.Exceptions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projet_bloc4.GestionEmployees
{
    public class GestionnaireEmployees
    {
        static List<Employee> list_employees = new List<Employee>();


        //Connexion à la base de données
        static string connexionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elodie\source\repos\Projet-bloc4\Projet-bloc4\projet4.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection con = new SqlConnection(connexionString);

        public int AddEmployee(Employee employee)
        {
            if (employee.Id != 0)
                MessageBox.Show("Impossible d'ajouter un employé déjà existant");
            else
            {

                //Ouverture de la connexion
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Employees values (@name, @firstname, @phoneNumber, @mobileNumber, @email, @idService, @idSite)", con);

                cmd.Parameters.AddWithValue("@name", employee.Name);
                cmd.Parameters.AddWithValue("@firstname", employee.Firstname);
                cmd.Parameters.AddWithValue("@phoneNumber", employee.MobilePhone);
                cmd.Parameters.AddWithValue("@mobileNumber", employee.PhoneNumber);
                cmd.Parameters.AddWithValue("@email", employee.Email);
                cmd.Parameters.AddWithValue("@idService", employee.Service);
                cmd.Parameters.AddWithValue("@idSite", employee.Site);


                //Exécute la requête sql
                cmd.ExecuteNonQuery();

                // Fermeture Connexion
                con.Close();

            }
            return employee.Id;
        }

        public void UpdateEmployee(Employee employee)
        {
            if (employee.Id == 0)
                MessageBox.Show("Vous essayez de modifier un service inexistant");


            SqlCommand cmd = new SqlCommand("Update Employees Set name = @name, firstname = @firstname, phoneNumber = @phoneNumber, mobileNumber = @mobileNumber, email = @email, idSite = @idSite, idService = @idService WHERE Id = @id", con);

            cmd.Parameters.AddWithValue("@name", employee.Name);
            cmd.Parameters.AddWithValue("@firstname", employee.Firstname);
            cmd.Parameters.AddWithValue("@phoneNumber", employee.MobilePhone);
            cmd.Parameters.AddWithValue("@mobileNumber", employee.PhoneNumber);
            cmd.Parameters.AddWithValue("@email", employee.Email);
            cmd.Parameters.AddWithValue("@idSite", employee.Site);
            cmd.Parameters.AddWithValue("@idService", employee.Service);
            cmd.Parameters.AddWithValue("@id", employee.Id);

            //Exécute la requête sql
            con.Open();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Salarié modifié");


            // Fermeture Connexion
            con.Close();


        }

        public void DeleteEmployee(int id)
        {
            Employee employee = this.SearchEmployeeById(id);

            SqlCommand cmd = new SqlCommand("Delete from Employees where Id = @Id", con);
            cmd.Parameters.AddWithValue("@id", employee.Id);

            con.Open();
            //Exécute la requête sql
            cmd.ExecuteNonQuery();
            MessageBox.Show("Salarié supprimé");

            // Fermeture Connexion
            con.Close();

        }

        public Employee SearchEmployeeById(int id)
        {
            foreach (var item in GetEmployees())
            {
                if (item.Id == id)
                    return item;
            }
            return null;
        }

        public List<Employee> GetEmployees()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Employees", con);


            SqlDataReader rdr = cmd.ExecuteReader();


            while (rdr.Read())
            {

                Employee employee = new Employee();
                employee.Id = rdr.GetInt32(0);
                employee.Name = rdr.GetString(1);
                employee.Firstname = rdr.GetString(2);
                employee.PhoneNumber = rdr.GetString(3);
                employee.MobilePhone = rdr.GetString(4);
                employee.Email = rdr.GetString(5);
                employee.Service = rdr.GetInt32(6);
                employee.Site = rdr.GetInt32(7);

                list_employees.Add(employee);

            }


            con.Close();
            return list_employees;
        }


    }
}
