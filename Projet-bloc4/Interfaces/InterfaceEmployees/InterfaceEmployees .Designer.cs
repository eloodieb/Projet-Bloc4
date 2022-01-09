
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.bt_end = new System.Windows.Forms.Button();
            this.bt_start = new System.Windows.Forms.Button();
            this.bt_previous = new System.Windows.Forms.Button();
            this.bt_next = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.listViewSites = new System.Windows.Forms.ListView();
            this.lbl_site = new System.Windows.Forms.Label();
            this.listViewServices = new System.Windows.Forms.ListView();
            this.lbl_service = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.txt_phoneNumber = new System.Windows.Forms.TextBox();
            this.lbl_mobil_phone = new System.Windows.Forms.Label();
            this.txt_mobileNumber = new System.Windows.Forms.TextBox();
            this.lbl_firstname = new System.Windows.Forms.Label();
            this.txt_firstname = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_creationDate = new System.Windows.Forms.Label();
            this.lbl_updateDate = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_creation_date = new System.Windows.Forms.Label();
            this.lbl_update_date = new System.Windows.Forms.Label();
            this.sitesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projet4DataSet = new Projet_bloc4.projet4DataSet();
            this.sitesTableAdapter = new Projet_bloc4.projet4DataSetTableAdapters.SitesTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewEmployeesAdmin = new System.Windows.Forms.DataGridView();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.siteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_register = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sitesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projet4DataSet)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeesAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_id);
            this.groupBox2.Controls.Add(this.bt_end);
            this.groupBox2.Controls.Add(this.bt_start);
            this.groupBox2.Controls.Add(this.bt_previous);
            this.groupBox2.Controls.Add(this.bt_next);
            this.groupBox2.Location = new System.Drawing.Point(995, 414);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 91);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(464, 46);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(14, 20);
            this.lbl_id.TabIndex = 14;
            this.lbl_id.Text = "-";
            // 
            // bt_end
            // 
            this.bt_end.Location = new System.Drawing.Point(354, 40);
            this.bt_end.Name = "bt_end";
            this.bt_end.Size = new System.Drawing.Size(94, 32);
            this.bt_end.TabIndex = 13;
            this.bt_end.Text = "Fin";
            this.bt_end.UseVisualStyleBackColor = true;
            this.bt_end.Click += new System.EventHandler(this.bt_end_Click);
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(12, 40);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(94, 32);
            this.bt_start.TabIndex = 10;
            this.bt_start.Text = "Début";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // bt_previous
            // 
            this.bt_previous.Location = new System.Drawing.Point(127, 40);
            this.bt_previous.Name = "bt_previous";
            this.bt_previous.Size = new System.Drawing.Size(94, 32);
            this.bt_previous.TabIndex = 11;
            this.bt_previous.Text = "Précédent";
            this.bt_previous.UseVisualStyleBackColor = true;
            this.bt_previous.Click += new System.EventHandler(this.bt_previous_Click);
            // 
            // bt_next
            // 
            this.bt_next.Location = new System.Drawing.Point(241, 40);
            this.bt_next.Name = "bt_next";
            this.bt_next.Size = new System.Drawing.Size(94, 32);
            this.bt_next.TabIndex = 12;
            this.bt_next.Text = "Suivant";
            this.bt_next.UseVisualStyleBackColor = true;
            this.bt_next.Click += new System.EventHandler(this.bt_next_Click);
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
            this.groupBox1.Controls.Add(this.lbl_creationDate);
            this.groupBox1.Controls.Add(this.lbl_updateDate);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.lbl_creation_date);
            this.groupBox1.Controls.Add(this.lbl_update_date);
            this.groupBox1.Location = new System.Drawing.Point(427, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 468);
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
            this.listViewSites.FullRowSelect = true;
            this.listViewSites.GridLines = true;
            this.listViewSites.HideSelection = false;
            this.listViewSites.Location = new System.Drawing.Point(224, 289);
            this.listViewSites.Name = "listViewSites";
            this.listViewSites.Size = new System.Drawing.Size(164, 28);
            this.listViewSites.TabIndex = 24;
            this.listViewSites.UseCompatibleStateImageBehavior = false;
            this.listViewSites.View = System.Windows.Forms.View.List;
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
            this.listViewServices.FullRowSelect = true;
            this.listViewServices.GridLines = true;
            this.listViewServices.HideSelection = false;
            this.listViewServices.Location = new System.Drawing.Point(224, 251);
            this.listViewServices.Name = "listViewServices";
            this.listViewServices.Size = new System.Drawing.Size(164, 26);
            this.listViewServices.TabIndex = 21;
            this.listViewServices.UseCompatibleStateImageBehavior = false;
            this.listViewServices.View = System.Windows.Forms.View.List;
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
            // lbl_creationDate
            // 
            this.lbl_creationDate.AutoSize = true;
            this.lbl_creationDate.Location = new System.Drawing.Point(32, 364);
            this.lbl_creationDate.Name = "lbl_creationDate";
            this.lbl_creationDate.Size = new System.Drawing.Size(127, 20);
            this.lbl_creationDate.TabIndex = 1;
            this.lbl_creationDate.Text = "Date de création";
            // 
            // lbl_updateDate
            // 
            this.lbl_updateDate.AutoSize = true;
            this.lbl_updateDate.Location = new System.Drawing.Point(32, 418);
            this.lbl_updateDate.Name = "lbl_updateDate";
            this.lbl_updateDate.Size = new System.Drawing.Size(155, 20);
            this.lbl_updateDate.TabIndex = 2;
            this.lbl_updateDate.Text = "Date de modification";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(224, 41);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(164, 26);
            this.txt_name.TabIndex = 3;
            // 
            // lbl_creation_date
            // 
            this.lbl_creation_date.AutoSize = true;
            this.lbl_creation_date.Location = new System.Drawing.Point(222, 364);
            this.lbl_creation_date.Name = "lbl_creation_date";
            this.lbl_creation_date.Size = new System.Drawing.Size(14, 20);
            this.lbl_creation_date.TabIndex = 4;
            this.lbl_creation_date.Text = "-";
            // 
            // lbl_update_date
            // 
            this.lbl_update_date.AutoSize = true;
            this.lbl_update_date.Location = new System.Drawing.Point(222, 418);
            this.lbl_update_date.Name = "lbl_update_date";
            this.lbl_update_date.Size = new System.Drawing.Size(14, 20);
            this.lbl_update_date.TabIndex = 5;
            this.lbl_update_date.Text = "-";
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
            // sitesTableAdapter
            // 
            this.sitesTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(2706, 34);
            this.fillByToolStrip.TabIndex = 23;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(56, 29);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
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
            this.dataGridViewEmployeesAdmin.Location = new System.Drawing.Point(427, 533);
            this.dataGridViewEmployeesAdmin.MultiSelect = false;
            this.dataGridViewEmployeesAdmin.Name = "dataGridViewEmployeesAdmin";
            this.dataGridViewEmployeesAdmin.ReadOnly = true;
            this.dataGridViewEmployeesAdmin.RowHeadersWidth = 62;
            this.dataGridViewEmployeesAdmin.RowTemplate.Height = 28;
            this.dataGridViewEmployeesAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmployeesAdmin.Size = new System.Drawing.Size(1284, 430);
            this.dataGridViewEmployeesAdmin.TabIndex = 25;
            this.dataGridViewEmployeesAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // siteBindingSource
            // 
            this.siteBindingSource.DataSource = typeof(Projet_bloc4.GestionSites.Site);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(94, 555);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 46);
            this.button1.TabIndex = 22;
            this.button1.Text = "Se déconnecter";
            this.button1.UseVisualStyleBackColor = false;
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
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.bt_update);
            this.panel1.Controls.Add(this.bt_add);
            this.panel1.Controls.Add(this.bt_register);
            this.panel1.Controls.Add(this.bt_delete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 929);
            this.panel1.TabIndex = 26;
            // 
            // InterfaceEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2706, 963);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewEmployeesAdmin);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "InterfaceEmployees";
            this.Text = "Gérer les salariés";
            this.Load += new System.EventHandler(this.InterfaceEmployees_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sitesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projet4DataSet)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeesAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_end;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Button bt_previous;
        private System.Windows.Forms.Button bt_next;
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
        private System.Windows.Forms.Label lbl_creationDate;
        private System.Windows.Forms.Label lbl_updateDate;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_creation_date;
        private System.Windows.Forms.Label lbl_update_date;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.BindingSource siteBindingSource;
        private projet4DataSet projet4DataSet;
        private System.Windows.Forms.BindingSource sitesBindingSource;
        private projet4DataSetTableAdapters.SitesTableAdapter sitesTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.ListView listViewServices;
        private System.Windows.Forms.ListView listViewSites;
        private System.Windows.Forms.DataGridView dataGridViewEmployeesAdmin;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_register;
        private System.Windows.Forms.Button bt_delete;
    }
}