using Projet_bloc4.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_bloc4.GestionSites
{
    public class GestionnairesSites
    {
        static List<Site> list_sites = new List<Site>();

    
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
