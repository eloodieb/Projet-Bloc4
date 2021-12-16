﻿using Projet_bloc4.Exceptions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_bloc4.GestionServices
{
    public class GestionnaireServices
    {
        //Création d'une liste de services
        static List<Service> list_services = new List<Service>();
        private static int ServicesNumber;
        public int AddService(Service service)
        {
            if (service.Id != 0)
                throw new AddExistingServiceException("Impossible d'ajouter un projet déjà existant");
            else
            {
                service.Id = ++GestionnaireServices.ServicesNumber;
                service.CreationDate = DateTime.Now;
                list_services.Add(service);

                //Connexion à la base de données
                string connexionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elodie\source\repos\Projet-bloc4\Projet-bloc4\projet4.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection con = new SqlConnection(connexionString);

                //Ouverture de la connexion
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Services values (@Id, @name)", con);
                cmd.Parameters.AddWithValue("@Id", service.Id);
                cmd.Parameters.AddWithValue("@name", service.Name);

                //Exécute la requête sql
                cmd.ExecuteNonQuery();

                // Fermeture Connexion
                con.Close();
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

            service.UpdateDate = DateTime.Now;
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

        public Service Start()
        {
            if (list_services.Count > 0)
                return list_services[0];
            else
                return null;
        }

        public Service Next(int id)
        {
            Service service = this.SearchServiceById(id);
            int index = list_services.IndexOf(service);
            if ((list_services.Count - 1) >= (index + 1))
                return list_services[index + 1];
            else
                return null;

        }

        public Service Previous(int id)
        {
            Service service = this.SearchServiceById(id);
            int index = list_services.IndexOf(service);
            if ((list_services.Count - 1) >= (index - 1) && index > 0)
                return list_services[index - 1];
            else
                return null;
        }

        public Service End()
        {
            if (list_services.Count > 0)
                return list_services[list_services.Count - 1];
            else
                return null;
        }
    }
}
