using System;

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
        int service;
        int site;
        DateTime creationDate;
        DateTime updateDate;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string MobilePhone { get => mobilePhone; set => mobilePhone = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
        public int Service { get => service; set => service = value; }
        public int Site { get => site; set => site = value; }
        public DateTime CreationDate { get => creationDate; set => creationDate = value; }
        public DateTime UpdateDate { get => updateDate; set => updateDate = value; }
    }
}
