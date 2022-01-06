using System;

namespace Projet_bloc4.GestionSites
{
    public class Site
    {
        int id;
        string name;
        DateTime creationDate;
        DateTime updateDate;
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime CreationDate { get => creationDate; set => creationDate = value; }
        public DateTime UpdateDate { get => updateDate; set => updateDate = value; }
    }
}
