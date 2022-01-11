using Projet_bloc4.Exceptions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projet_bloc4.GestionServices
{


    public class GestionnaireServices
    {  
        //Connexion à la BDD
        static string connexionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elodie\source\repos\Projet-bloc4\Projet-bloc4\projet4.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection con = new SqlConnection(connexionString);

        //Création d'une liste de services
        static List<Service> list_services = new List<Service>();

    
        public int AddService(Service service)
        {
  
            SqlCommand cmd = new SqlCommand("insert into Services Select @name Where not exists(select * from Services where name=@name)", con);
            cmd.Parameters.AddWithValue("@name", service.Name);

            //Exécute la requête sql
            con.Open();
            int res = cmd.ExecuteNonQuery();

            if (res == 1)
                MessageBox.Show("Service ajouté");

            else
                MessageBox.Show("Impossible d'ajouter un Service déjà existant");
          
            con.Close();

            return res;


        }

        public void DeleteService(int id)
        {

            Service service = this.SearchServiceById(id);

            //Ouverture de la connexion
            SqlCommand cmd = new SqlCommand("Delete Services from Services LEFT OUTER JOIN  Employees ON (Services.Id = Employees.idService) where Employees.idService IS NULL And Services.Id = @id", con);
            cmd.Parameters.AddWithValue("@id", service.Id);

            //Exécute la requête sql

            con.Open();
            var result = cmd.ExecuteNonQuery();
            if (result == 1)
                MessageBox.Show("Service supprimé");

            else
                MessageBox.Show("Impossible de supprimer un Service contenant des salariés");

            // Fermeture Connexion
            con.Close();


        }

        public void UpdateService(Service service)
        {
            if (service.Id == 0)
                MessageBox.Show("Vous essayez de modifier un service inexistant");

            service.UpdateDate = DateTime.Now;


            SqlCommand cmd = new SqlCommand("Update Services Set name = @newName from Services LEFT OUTER JOIN Employees ON(Services.Id = Employees.idService) WHERE Employees.idService IS NULL And Services.Id = @id", con);

            cmd.Parameters.AddWithValue("@newName", service.Name);
            cmd.Parameters.AddWithValue("@id", service.Id);

            //Exécute la requête sql
            con.Open();
            var result = cmd.ExecuteNonQuery();
            if (result == 1)
                MessageBox.Show("Service modifié");

            else
                MessageBox.Show("Impossible de modifier un Service contenant des salariés");

            // Fermeture Connexion
            con.Close();


        }

        public Service SearchServiceById(int id)
        {
            foreach (var item in GetServices())
            {
                if (item.Id == id)
                    return item;
            }
            return null;

        }

        public List<Service> GetServices()
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Services", con);


            SqlDataReader rdr = cmd.ExecuteReader();


            while (rdr.Read())
            {

                Service service = new Service();
                service.Id = rdr.GetInt32(0);
                service.Name = rdr.GetString(1);

                list_services.Add(service);

            }


            con.Close();

            return list_services;



        }

    }
}
