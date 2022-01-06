using Projet_bloc4.Exceptions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projet_bloc4.GestionSites
{
    public class GestionnairesSites
    {
        public List<Site> list_sites = new List<Site>();
        //Connexion à la base de données
        static string connexionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elodie\source\repos\Projet-bloc4\Projet-bloc4\projet4.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection con = new SqlConnection(connexionString);


        // Ajoute un site
        public int AddSite(Site site)
        {
            if (site.Id != 0)
                throw new AddExistingSiteException("Impossible d'ajouter un site déjà existant");
            else
            {

                site.CreationDate = DateTime.Now;

                //Ouverture de la connexion
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Sites Select @city Where not exists(select * from Sites where city=@city)", con);
                cmd.Parameters.AddWithValue("@city", site.Name);

                int res = cmd.ExecuteNonQuery();

                if (res == 1)
                    MessageBox.Show("Site ajouté");

                else
                    MessageBox.Show("Impossible d'ajouter un Site déjà existant");

                // Fermeture Connexion
                con.Close();
                return res;
            }
        }

        //Supprime un site par son Id
        public void DeleteSiteById(int id)
        {

            Site site = this.SearchSiteById(id);

            SqlCommand cmd = new SqlCommand("Delete Sites from Sites LEFT OUTER JOIN  Employees ON (Sites.Id = Employees.idSite) where Employees.idSite IS NULL And Sites.Id = @id", con);
            cmd.Parameters.AddWithValue("@id", site.Id);

            //Exécute la requête sql
            con.Open();
            var result = cmd.ExecuteNonQuery();
            if (result == 1)
                MessageBox.Show("Site supprimé");

            else
                MessageBox.Show("Impossible de supprimer un Site contenant des salariés");

            // Fermeture Connexion
            con.Close();
        }

        //Modifie un site
        public void UpdateSite(Site site)
        {
            if (site.Id == 0)
                throw new UpdateInexistingSite("Vous essayez de modifier un site qui n'existe pas");

            site.UpdateDate = DateTime.Now;

            SqlCommand cmd = new SqlCommand("Update Sites Set city = @newCity from Sites LEFT OUTER JOIN Employees ON(Sites.Id = Employees.idSite) WHERE Employees.idSite IS NULL And Sites.Id = @id", con);

            cmd.Parameters.AddWithValue("@newCity", site.Name);
            cmd.Parameters.AddWithValue("@id", site.Id);

            //Exécute la requête sql
            con.Open();
            var result = cmd.ExecuteNonQuery();
            if (result == 1)
                MessageBox.Show("Site modifié");

            else
                MessageBox.Show("Impossible de modifier un Site contenant des salariés");

            // Fermeture Connexion
            con.Close();
        }

        //Recherche un site par son Id
        public Site SearchSiteById(int id)
        {
            foreach (var item in GetSites())
            {
                if (item.Id == id)
                    return item;
            }
            return null;
        }

        // Récupère la liste des sites existants
        public List<Site> GetSites()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Sites", con);


            SqlDataReader rdr = cmd.ExecuteReader();


            while (rdr.Read())
            {

                Site site = new Site();
                site.Id = rdr.GetInt32(0);
                site.Name = rdr.GetString(1);

                list_sites.Add(site);

            }


            con.Close();
            return list_sites;
        }

        public Site Start()
        {
            if (GetSites().Count > 0)
            {
                return GetSites()[0];
            }


            else
                return null;
        }

        public Site Following(int id)
        {
            Site site = this.SearchSiteById(id);
            int index = GetSites().IndexOf(site);
            Console.WriteLine(index);
            //Bug au niveau de l'index
            if ((GetSites().Count - 1) >= (index + 1))
                return GetSites()[index + 1];
            else
                return null;
        }

        public Site Previous(int id)
        {
            Site site = this.SearchSiteById(id);
            int index = GetSites().IndexOf(site);

            if ((GetSites().Count - 1) >= (index - 1) && index > 0)
                return GetSites()[index - 1];
            else
                return null;
        }

        public Site End()
        {
            if (GetSites().Count > 0)
                return GetSites()[GetSites().Count - 1];

            else
                return null;
        }

    }
}
