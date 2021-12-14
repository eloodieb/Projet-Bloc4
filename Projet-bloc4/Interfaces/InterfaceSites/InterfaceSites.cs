using Projet_bloc4.GestionSites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_bloc4.Interfaces.InterfaceSites
{
    public partial class InterfaceSites : Form
    {
        public InterfaceSites()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            Site site = new GestionnairesSites().Start();
            this.Display(site);
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            lbl_id.Text = "";
            txt_ville.Text = "";
            lbl_date_creation.Text = "";
            lbl_date_modification.Text = DateTime.Now.ToShortDateString();
        }

        private void bt_register_Click(object sender, EventArgs e)
        {
            Site site = new Site();
            site.Name = txt_ville.Text;
            new GestionnairesSites().AddSite(site);
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(lbl_id.Text);
                Site site = new GestionnairesSites().SearchSiteById(id);
                site.Name = txt_ville.Text;
                new GestionnairesSites().UpdateSite(site);
            }
            catch (FormatException)
            {
                MessageBox.Show("Veuillez choisir un site à modifier");
            }

            
        }

        private void bt_previous_Click(object sender, EventArgs e)
        {
            if (lbl_id.Text !="" && lbl_id.Text != "-")
            {
                Site site = new GestionnairesSites().Previous(int.Parse(lbl_id.Text));
                this.Display(site);
            }
        }

        private void bt_following_Click(object sender, EventArgs e)
        {
            if (lbl_id.Text != "" && lbl_id.Text != "-")
            {
                Site site = new GestionnairesSites().Following(int.Parse(lbl_id.Text));
                this.Display(site);
            }
        }

        private void bt_end_Click(object sender, EventArgs e)
        {
            Site site = new GestionnairesSites().End();
            this.Display(site);
        }

        private void Display(Site site)
        {
            if(site != null)
            {
                lbl_id.Text = site.Id.ToString();
                txt_ville.Text = site.Name;
                lbl_date_creation.Text = site.CreationDate.ToString();

                if (site.UpdateDate.Year != 1)
                lbl_date_modification.Text = site.UpdateDate.ToShortDateString();
            }
  
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(lbl_id.Text);
                new GestionnairesSites().DeleteSiteById(id);
                bt_start_Click(this, null);

            }
            catch
            {
                MessageBox.Show("Veuillez choisir un site à supprimer");
            }
        }
    }
}
