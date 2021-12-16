using Projet_bloc4.Exceptions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_bloc4.GestionEmployees
{
    public class GestionnaireEmployees
    {
       static  List<Employee> list_employees = new List<Employee>();

        private static int EmployeesNumber;
        //Connexion à la base de données
        static string connexionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elodie\source\repos\Projet-bloc4\Projet-bloc4\projet4.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection con = new SqlConnection(connexionString);

        public int AddEmployee(Employee employee)
        {
            if (employee.Id != 0)
                throw new AddExistingEmployeeException("Impossible d'ajouter un employé déjà existant");
            else
            {
                employee.Id = ++GestionnaireEmployees.EmployeesNumber;
                employee.CreationDate = DateTime.Now;
                list_employees.Add(employee);

                //Ouverture de la connexion
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Employees values (@Id, @name, @firstname, @phoneNumber, @mobileNumber, @email, @idSite, @idService)", con);
                cmd.Parameters.AddWithValue("@Id", employee.Id);
                cmd.Parameters.AddWithValue("@name", employee.Name);
                cmd.Parameters.AddWithValue("@firstname", employee.Firstname);
                cmd.Parameters.AddWithValue("@phoneNumber", employee.MobilePhone);
                cmd.Parameters.AddWithValue("@mobileNumber", employee.PhoneNumber);
                cmd.Parameters.AddWithValue("@email", employee.Email);
                cmd.Parameters.AddWithValue("@idSite", employee.Site);
                cmd.Parameters.AddWithValue("@idService", employee.Service);

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
                throw new UpdateInexistingEmployee("Vous essayez de modifier un service inexistant");

            Employee e = this.SearchEmployeeById(employee.Id);

            employee.UpdateDate = DateTime.Now;
            list_employees.Insert(list_employees.IndexOf(e), employee);


        }

        public void DeleteEmployee(int id)
        {
            Employee employee = this.SearchEmployeeById(id);
            list_employees.Remove(employee);

            //Ouverture de la connexion
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from Employees where Id = employee.Id", con);
            //Exécute la requête sql
            cmd.ExecuteNonQuery();

            // Fermeture Connexion
            con.Close();

        }

        public Employee SearchEmployeeById(int id)
        {
            foreach (var item in list_employees)
            {
                if (item.Id == id)
                    return item;
            }
            return null;
        }

        public List<Employee> GetEmployees()
        {
            return list_employees;
        }

        public Employee Start()
        {
            if (list_employees.Count > 0)
                return list_employees[0];
            else
                return null;
        }

        public Employee Next(int id)
        {
            Employee employee = this.SearchEmployeeById(id);
            int index = list_employees.IndexOf(employee);
            if ((list_employees.Count - 1) >= (index + 1))
                return list_employees[index + 1];
            else
                return null;
        }

        public Employee Previous(int id)
        {
            Employee employee = this.SearchEmployeeById(id);
            int index = list_employees.IndexOf(employee);
            if ((list_employees.Count - 1) >= (index - 1) && index > 0 )
                return list_employees[index - 1];
            else
                return null;
        }

        public Employee End()
        {
            if (list_employees.Count > 0)
                return list_employees[list_employees.Count - 1];
            else
                return null;
        }
    }
}
