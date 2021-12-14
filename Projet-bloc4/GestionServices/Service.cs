using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_bloc4.GestionServices
{
    public class Service
    {
        int id;
        string name;
        DateTime creationDate;
        DateTime updateTime;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime CreationDate { get => creationDate; set => creationDate = value; }
        public DateTime UpdateTime { get => updateTime; set => updateTime = value; }
    }
}
