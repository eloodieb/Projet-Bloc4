using Projet_bloc4.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_bloc4.GestionServices
{
    public class GestionnaireServices
    {
        //Création d'une liste de services
        List<Service> list_services = new List<Service>();
        private static int ServicesNumber;
        public int AddService(Service service)
        {
            if (service.Id != 0)
                throw new AddExistingServiceException("Impossible d'ajouter un projet déjà existant");
            else
            {
                service.Id = ++GestionnaireServices.ServicesNumber;
                list_services.Add(service);
            }
            return service.Id;
        }

        public void DeleteService(int id)
        {
            Service service = this.SearchServiceById(id);
            list_services.Remove(service);
        }

        public void UpdateService(Service service)
        {
            if (service.Id == 0)
                throw new UpdateInexistingService("Vous essayez de modifier un service inexistant");
          
            Service s = this.SearchServiceById(service.Id);

            list_services.Insert(list_services.IndexOf(s), service);
            
           
        }
        public Service SearchServiceById(int id)
        {
            foreach (var item in list_services)
            {
                if (item.Id == id)
                    return item;
            }
            return null;
        }
        public List<Service> GetServices()
        {
            return list_services;
        }
    }
}
