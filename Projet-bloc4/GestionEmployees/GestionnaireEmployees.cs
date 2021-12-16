using Projet_bloc4.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_bloc4.GestionEmployees
{
    public class GestionnaireEmployees
    {
       static  List<Employee> list_employees = new List<Employee>();

        private static int EmployeesNumber;

        public int AddEmployee(Employee employee)
        {
            if (employee.Id != 0)
                throw new AddExistingEmployeeException("Impossible d'ajouter un employé déjà existant");
            else
            {
                employee.Id = ++GestionnaireEmployees.EmployeesNumber;
                employee.CreationDate = DateTime.Now;
                list_employees.Add(employee);
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
