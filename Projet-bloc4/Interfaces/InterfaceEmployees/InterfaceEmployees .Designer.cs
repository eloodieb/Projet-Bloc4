
namespace Projet_bloc4.Interfaces.InterfaceEmployees
{
    partial class InterfaceEmployees
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_id = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.listViewSites = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sitesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projet4DataSet = new Projet_bloc4.projet4DataSet();
            this.lbl_site = new System.Windows.Forms.Label();
            this.listViewServices = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_service = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.txt_phoneNumber = new System.Windows.Forms.TextBox();
            this.lbl_mobil_phone = new System.Windows.Forms.Label();
            this.txt_mobileNumber = new System.Windows.Forms.TextBox();
            this.lbl_firstname = new System.Windows.Forms.Label();
            this.txt_firstname = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.sitesTableAdapter = new Projet_bloc4.projet4DataSetTableAdapters.SitesTableAdapter();
            this.dataGridViewEmployeesAdmin = new System.Windows.Forms.DataGridView();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_register = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.btn_deconnexion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.projet4DataSet1 = new Projet_bloc4.projet4DataSet1();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new Projet_bloc4.projet4DataSet1TableAdapters.EmployeesTableAdapter();
            this.siteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sitesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projet4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeesAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projet4DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(459, 382);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(14, 20);
            this.lbl_id.TabIndex = 14;
            this.lbl_id.Text = "-";
            this.lbl_id.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_email);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.listViewSites);
            this.groupBox1.Controls.Add(this.lbl_site);
            this.groupBox1.Controls.Add(this.listViewServices);
            this.groupBox1.Controls.Add(this.lbl_service);
            this.groupBox1.Controls.Add(this.lbl_phone);
            this.groupBox1.Controls.Add(this.txt_phoneNumber);
            this.groupBox1.Controls.Add(this.lbl_mobil_phone);
            this.groupBox1.Controls.Add(this.txt_mobileNumber);
            this.groupBox1.Controls.Add(this.lbl_firstname);
            this.groupBox1.Controls.Add(this.txt_firstname);
            this.groupBox1.Controls.Add(this.lbl_name);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Location = new System.Drawing.Point(427, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 368);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Détails Salarié";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(32, 214);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(48, 20);
            this.lbl_email.TabIndex = 16;
            this.lbl_email.Text = "Email";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(224, 214);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(164, 26);
            this.txt_email.TabIndex = 17;
            // 
            // listViewSites
            // 
            this.listViewSites.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listViewSites.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.sitesBindingSource, "city", true));
            this.listViewSites.FullRowSelect = true;
            this.listViewSites.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewSites.HideSelection = false;
            this.listViewSites.Location = new System.Drawing.Point(224, 301);
            this.listViewSites.Name = "listViewSites";
            this.listViewSites.Size = new System.Drawing.Size(164, 32);
            this.listViewSites.TabIndex = 24;
            this.listViewSites.UseCompatibleStateImageBehavior = false;
            this.listViewSites.View = System.Windows.Forms.View.Details;
            // 
            // sitesBindingSource
            // 
            this.sitesBindingSource.DataMember = "Sites";
            this.sitesBindingSource.DataSource = this.projet4DataSet;
            // 
            // projet4DataSet
            // 
            this.projet4DataSet.DataSetName = "projet4DataSet";
            this.projet4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_site
            // 
            this.lbl_site.AutoSize = true;
            this.lbl_site.Location = new System.Drawing.Point(32, 289);
            this.lbl_site.Name = "lbl_site";
            this.lbl_site.Size = new System.Drawing.Size(45, 20);
            this.lbl_site.TabIndex = 14;
            this.lbl_site.Text = "Sites";
            // 
            // listViewServices
            // 
            this.listViewServices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewServices.FullRowSelect = true;
            this.listViewServices.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewServices.HideSelection = false;
            this.listViewServices.Location = new System.Drawing.Point(224, 251);
            this.listViewServices.MultiSelect = false;
            this.listViewServices.Name = "listViewServices";
            this.listViewServices.Size = new System.Drawing.Size(164, 32);
            this.listViewServices.TabIndex = 21;
            this.listViewServices.UseCompatibleStateImageBehavior = false;
            this.listViewServices.View = System.Windows.Forms.View.Details;
            // 
            // lbl_service
            // 
            this.lbl_service.AutoSize = true;
            this.lbl_service.Location = new System.Drawing.Point(32, 251);
            this.lbl_service.Name = "lbl_service";
            this.lbl_service.Size = new System.Drawing.Size(61, 20);
            this.lbl_service.TabIndex = 12;
            this.lbl_service.Text = "Service";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(32, 174);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(112, 20);
            this.lbl_phone.TabIndex = 10;
            this.lbl_phone.Text = "Téléphone fixe";
            // 
            // txt_phoneNumber
            // 
            this.txt_phoneNumber.Location = new System.Drawing.Point(224, 174);
            this.txt_phoneNumber.Name = "txt_phoneNumber";
            this.txt_phoneNumber.Size = new System.Drawing.Size(164, 26);
            this.txt_phoneNumber.TabIndex = 11;
            // 
            // lbl_mobil_phone
            // 
            this.lbl_mobil_phone.AutoSize = true;
            this.lbl_mobil_phone.Location = new System.Drawing.Point(32, 129);
            this.lbl_mobil_phone.Name = "lbl_mobil_phone";
            this.lbl_mobil_phone.Size = new System.Drawing.Size(134, 20);
            this.lbl_mobil_phone.TabIndex = 8;
            this.lbl_mobil_phone.Text = "Téléphone mobile";
            // 
            // txt_mobileNumber
            // 
            this.txt_mobileNumber.Location = new System.Drawing.Point(224, 129);
            this.txt_mobileNumber.Name = "txt_mobileNumber";
            this.txt_mobileNumber.Size = new System.Drawing.Size(164, 26);
            this.txt_mobileNumber.TabIndex = 9;
            // 
            // lbl_firstname
            // 
            this.lbl_firstname.AutoSize = true;
            this.lbl_firstname.Location = new System.Drawing.Point(32, 84);
            this.lbl_firstname.Name = "lbl_firstname";
            this.lbl_firstname.Size = new System.Drawing.Size(64, 20);
            this.lbl_firstname.TabIndex = 6;
            this.lbl_firstname.Text = "Prénom";
            // 
            // txt_firstname
            // 
            this.txt_firstname.Location = new System.Drawing.Point(224, 84);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(164, 26);
            this.txt_firstname.TabIndex = 7;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(32, 41);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(42, 20);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Nom";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(224, 41);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(164, 26);
            this.txt_name.TabIndex = 3;
            // 
            // sitesTableAdapter
            // 
            this.sitesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewEmployeesAdmin
            // 
            this.dataGridViewEmployeesAdmin.AllowUserToAddRows = false;
            this.dataGridViewEmployeesAdmin.AllowUserToDeleteRows = false;
            this.dataGridViewEmployeesAdmin.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewEmployeesAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEmployeesAdmin.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEmployeesAdmin.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewEmployeesAdmin.Location = new System.Drawing.Point(427, 436);
            this.dataGridViewEmployeesAdmin.MultiSelect = false;
            this.dataGridViewEmployeesAdmin.Name = "dataGridViewEmployeesAdmin";
            this.dataGridViewEmployeesAdmin.ReadOnly = true;
            this.dataGridViewEmployeesAdmin.RowHeadersWidth = 62;
            this.dataGridViewEmployeesAdmin.RowTemplate.Height = 28;
            this.dataGridViewEmployeesAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmployeesAdmin.Size = new System.Drawing.Size(1284, 430);
            this.dataGridViewEmployeesAdmin.TabIndex = 25;
            this.dataGridViewEmployeesAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployeesAdmin_CellContentClick);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // bt_delete
            // 
            this.bt_delete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_delete.Location = new System.Drawing.Point(94, 411);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(148, 46);
            this.bt_delete.TabIndex = 21;
            this.bt_delete.Text = "Supprimer";
            this.bt_delete.UseVisualStyleBackColor = false;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_register
            // 
            this.bt_register.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_register.Location = new System.Drawing.Point(96, 279);
            this.bt_register.Name = "bt_register";
            this.bt_register.Size = new System.Drawing.Size(146, 48);
            this.bt_register.TabIndex = 19;
            this.bt_register.Text = "Enregistrer";
            this.bt_register.UseVisualStyleBackColor = false;
            this.bt_register.Click += new System.EventHandler(this.bt_register_Click);
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_add.Location = new System.Drawing.Point(94, 217);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(148, 47);
            this.bt_add.TabIndex = 18;
            this.bt_add.Text = "Ajouter";
            this.bt_add.UseVisualStyleBackColor = false;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_update
            // 
            this.bt_update.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_update.Location = new System.Drawing.Point(96, 347);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(146, 46);
            this.bt_update.TabIndex = 20;
            this.bt_update.Text = "Modifier";
            this.bt_update.UseVisualStyleBackColor = false;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // btn_deconnexion
            // 
            this.btn_deconnexion.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_deconnexion.Location = new System.Drawing.Point(94, 555);
            this.btn_deconnexion.Name = "btn_deconnexion";
            this.btn_deconnexion.Size = new System.Drawing.Size(148, 46);
            this.btn_deconnexion.TabIndex = 22;
            this.btn_deconnexion.Text = "Se déconnecter";
            this.btn_deconnexion.UseVisualStyleBackColor = false;
            this.btn_deconnexion.Click += new System.EventHandler(this.btn_deconnexion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 35);
            this.label1.TabIndex = 27;
            this.label1.Text = "Espace Administrateur ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "Gestion des salariés";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_deconnexion);
            this.panel1.Controls.Add(this.bt_update);
            this.panel1.Controls.Add(this.bt_add);
            this.panel1.Controls.Add(this.bt_register);
            this.panel1.Controls.Add(this.bt_delete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 963);
            this.panel1.TabIndex = 26;
            // 
            // projet4DataSet1
            // 
            this.projet4DataSet1.DataSetName = "projet4DataSet1";
            this.projet4DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.projet4DataSet1;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // siteBindingSource
            // 
            this.siteBindingSource.DataSource = typeof(Projet_bloc4.GestionSites.Site);
            // 
            // InterfaceEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2706, 963);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewEmployeesAdmin);
            this.Controls.Add(this.groupBox1);
            this.Name = "InterfaceEmployees";
            this.Text = "Gérer les salariés";
            this.Load += new System.EventHandler(this.InterfaceEmployees_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sitesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projet4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeesAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projet4DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_site;
        private System.Windows.Forms.Label lbl_service;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.TextBox txt_phoneNumber;
        private System.Windows.Forms.Label lbl_mobil_phone;
        private System.Windows.Forms.TextBox txt_mobileNumber;
        private System.Windows.Forms.Label lbl_firstname;
        private System.Windows.Forms.TextBox txt_firstname;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.BindingSource siteBindingSource;
        private projet4DataSet projet4DataSet;
        private System.Windows.Forms.BindingSource sitesBindingSource;
        private projet4DataSetTableAdapters.SitesTableAdapter sitesTableAdapter;
        private System.Windows.Forms.ListView listViewServices;
        private System.Windows.Forms.ListView listViewSites;
        private System.Windows.Forms.DataGridView dataGridViewEmployeesAdmin;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_deconnexion;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_register;
        private System.Windows.Forms.Button bt_delete;
        private projet4DataSet1 projet4DataSet1;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private projet4DataSet1TableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}