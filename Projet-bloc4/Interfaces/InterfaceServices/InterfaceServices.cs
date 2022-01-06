using Projet_bloc4.GestionServices;
using System;
using System.Windows.Forms;

namespace Projet_bloc4.Interfaces.InterfaceServices
{
    public partial class InterfaceServices : Form
    {


        public InterfaceServices()
        {

            InitializeComponent();

        }


        private void bt_add_Click(object sender, EventArgs e)
        {
            lbl_id.Text = "";
            txt_service.Text = "";
            lbl_creation_date.Text = "";
            lbl_update_date.Text = DateTime.Now.ToShortDateString();


        }

        private void bt_register_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            service.Name = txt_service.Text;
            new GestionnaireServices().AddService(service);
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            Service service = new GestionnaireServices().Start();
            this.Display(service);

        }

        private void Display(Service service)
        {
            if (service != null)
            {
                lbl_id.Text = service.Id.ToString();
                txt_service.Text = service.Name;
                lbl_creation_date.Text = service.CreationDate.ToString();

                if (service.UpdateDate.Year != 1)
                    lbl_update_date.Text = service.UpdateDate.ToShortDateString();
            }
        }

        private void bt_previous_Click(object sender, EventArgs e)
        {
            if (lbl_id.Text != "" && lbl_id.Text != "-")
            {
                Service service = new GestionnaireServices().Previous(int.Parse(lbl_id.Text));
                this.Display(service);
            }

        }

        private void bt_next_Click(object sender, EventArgs e)
        {
            if (lbl_id.Text != "" && lbl_id.Text != "-")
            {
                Service service = new GestionnaireServices().Next(int.Parse(lbl_id.Text));
                this.Display(service);
            }
        }

        private void bt_end_Click(object sender, EventArgs e)
        {
            Service service = new GestionnaireServices().End();
            this.Display(service);
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

                bt_start_Click(this, null);

            }
            catch (FormatException)
            {
                MessageBox.Show("Le label id est vide");
            }

        }
    }
}
