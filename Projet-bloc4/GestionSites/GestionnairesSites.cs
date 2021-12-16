using Projet_bloc4.Exceptions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_bloc4.GestionSites
{
    public class GestionnairesSites
    {
        static List<Site> list_sites = new List<Site>();
        //Connexion à la base de données
        static string connexionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elodie\source\repos\Projet-bloc4\Projet-bloc4\projet4.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection con = new SqlConnection(connexionString);

        private static int SitesNumber;
 
        // Ajoute un site
        public int AddSite(Site site)
        {
            if (site.Id != 0) 
                throw new AddExistingSiteException("Impossible d'ajouter un site déjà existant");
            else
            {
                site.Id = ++GestionnairesSites.SitesNumber;
                site.CreationDate = DateTime.Now;
                list_sites.Add(site);

                //Ouverture de la connexion
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Sites values (@Id, @city)", con);
                cmd.Parameters.AddWithValue("@Id", site.Id);
                cmd.Parameters.AddWithValue("@name", site.Name);

                //Exécute la requête sql
                cmd.ExecuteNonQuery();

                // Fermeture Connexion
                con.Close();
            }

            return site.Id;
        }

        //Supprime un site par son Id
        public void DeleteSiteById(int id)
        {
            Site site = this.SearchSiteById(id);
            list_sites.Remove(site);
        }

        //Modifie un site
        public void UpdateSite(Site site)
        {
            if (site.Id == 0)
                throw new UpdateInexistingSite("Vous essayez de modifier un site qui n'existe pas");

            Site s = this.SearchSiteById(site.Id);
            site.UpdateDate = DateTime.Now;
            list_sites.Insert(list_sites.IndexOf(s), site);
        }

        //Recherche un site par son Id
        public Site SearchSiteById(int id)
        {
            foreach (var item in list_sites)
            {
                if (item.Id == id)
                    return item;
            }
            return null;
        }

        // Récupère la liste des sites existants
        public List<Site> GetSites()
        {
            return list_sites;
        }

        public Site Start()
        {
            if (list_sites.Count > 0)
                return list_sites[0];
            else
                return null;
        }

        public Site Following(int id)
        {
            Site site = this.SearchSiteById(id);
            int index = list_sites.IndexOf(site);
            if ((list_sites.Count - 1) >= (index + 1))
                return list_sites[index + 1];
            else
                return null;
        }

        public Site Previous(int id)
        {
            Site site = this.SearchSiteById(id);
            int index = list_sites.IndexOf(site);
            if ((list_sites.Count - 1) >= (index - 1) && index > 0)
                return list_sites[index - 1];
            else
                return null;
        }

        public Site End()
        {
            if (list_sites.Count > 0)
                return list_sites[list_sites.Count - 1];
            else
                return null;
        }

    }
}
