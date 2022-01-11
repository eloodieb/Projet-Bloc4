using Projet_bloc4.GestionServices;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projet_bloc4.Interfaces.InterfaceServices
{
    public partial class InterfaceServices : Form
    {
        //Connexion à la base de données
        static string connexionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elodie\source\repos\Projet-bloc4\Projet-bloc4\projet4.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection con = new SqlConnection(connexionString);

        public InterfaceServices()
        {

            InitializeComponent();

        }


        private void bt_add_Click(object sender, EventArgs e)
        {
            lbl_id.Text = "";
            txt_service.Text = "";

        }

        private void bt_register_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            service.Name = txt_service.Text;
            new GestionnaireServices().AddService(service);
        }


        private void bt_update_Click(object sender, EventArgs e)
        {
            try
            {

                int id = int.Parse(lbl_id.Text);
                Service service = new GestionnaireServices().SearchServiceById(id);
                service.Name = txt_service.Text;
                new GestionnaireServices().UpdateService(service);

            }
            catch
            {
                MessageBox.Show("Le label id est vide");
            }

        }

        private void bt_delete_Click(object sender, EventArgs e)
        {

            try
            {

                int id = int.Parse(lbl_id.Text);
                new GestionnaireServices().DeleteService(id);

        
            }
            catch (FormatException)
            {
                MessageBox.Show("Le label id est vide");
            }

        }

        private void dataGridViewServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewServices.CurrentRow.Index != -1)
            {
                lbl_id.Text = dataGridViewServices.CurrentRow.Cells[0].Value.ToString();
                txt_service.Text = dataGridViewServices.CurrentRow.Cells[1].Value.ToString();

            }
        }

        private void InterfaceServices_Load(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("SELECT Id, name FROM Services", con);
            con.Open();


            //Permet d'afficher la liste des Services dans la dataGrid
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridViewServices.DataSource = dt;

            con.Close();
        }
    }
}
