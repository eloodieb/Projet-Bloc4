using Projet_bloc4.GestionSites;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projet_bloc4.Interfaces.InterfaceSites
{
    public partial class InterfaceSites : Form
    {
        //Connexion à la base de données
        static string connexionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elodie\source\repos\Projet-bloc4\Projet-bloc4\projet4.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection con = new SqlConnection(connexionString);
        public InterfaceSites()
        {
            InitializeComponent();
        }


        private void bt_start_Click(object sender, EventArgs e)
        {
            Site site = new GestionnairesSites().Start();
            this.Display(site);
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            lbl_id.Text = "";
            txt_city.Text = "";
        }

        private void bt_register_Click(object sender, EventArgs e)
        {
            Site site = new Site();
            site.Name = txt_city.Text;
            new GestionnairesSites().AddSite(site);
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(lbl_id.Text);
                Site site = new GestionnairesSites().SearchSiteById(id);
                site.Name = txt_city.Text;
                new GestionnairesSites().UpdateSite(site);
            }
            catch (FormatException)
            {
                MessageBox.Show("Veuillez choisir un site à modifier");
            }


        }

        private void bt_previous_Click(object sender, EventArgs e)
        {
            if (lbl_id.Text != "" && lbl_id.Text != "-")
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
            if (site != null)
            {
                lbl_id.Text = site.Id.ToString();
                txt_city.Text = site.Name;
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

        private void dataGridViewSites_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewSites.CurrentRow.Index != -1)
            {
                lbl_id.Text = dataGridViewSites.CurrentRow.Cells[0].Value.ToString();
                txt_city.Text = dataGridViewSites.CurrentRow.Cells[1].Value.ToString();

            }
        }

        private void InterfaceSites_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT Id, city FROM Sites", con);
            con.Open();


            //Permet d'afficher la liste des Sites dans la dataGrid
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridViewSites.DataSource = dt;

            con.Close();
        }
    }
}
