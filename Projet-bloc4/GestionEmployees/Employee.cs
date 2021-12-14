using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_bloc4.GestionEmployees
{
    public class Employee
    {
        int id;
        string name;
        string firstname;
        string mobilePhone;
        string phoneNumber;
        string email;
        string service;
        string site;
        DateTime creationDate;
        DateTime updateDate;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string MobilePhone { get => mobilePhone; set => mobilePhone = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
        public string Service { get => service; set => service = value; }
        public string Site { get => site; set => site = value; }
        public DateTime CreationDate { get => creationDate; set => creationDate = value; }
        public DateTime UpdateDate { get => updateDate; set => updateDate = value; }
    }
}
