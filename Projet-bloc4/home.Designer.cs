
namespace Projet_bloc4
{
    partial class home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesSitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salariésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesSalariésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewSites = new System.Windows.Forms.ListView();
            this.listViewServices = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sitesToolStripMenuItem,
            this.servicesToolStripMenuItem,
            this.salariésToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1884, 54);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sitesToolStripMenuItem
            // 
            this.sitesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerLesSitesToolStripMenuItem});
            this.sitesToolStripMenuItem.Name = "sitesToolStripMenuItem";
            this.sitesToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.sitesToolStripMenuItem.Text = "Sites";
            // 
            // gérerLesSitesToolStripMenuItem
            // 
            this.gérerLesSitesToolStripMenuItem.Name = "gérerLesSitesToolStripMenuItem";
            this.gérerLesSitesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.gérerLesSitesToolStripMenuItem.Text = "Gérer  les sites";
            this.gérerLesSitesToolStripMenuItem.Click += new System.EventHandler(this.gérerLesSitesToolStripMenuItem_Click);
            // 
            // servicesToolStripMenuItem
            // 
            this.servicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerLesServicesToolStripMenuItem});
            this.servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            this.servicesToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.servicesToolStripMenuItem.Text = "Services";
            // 
            // gérerLesServicesToolStripMenuItem
            // 
            this.gérerLesServicesToolStripMenuItem.Name = "gérerLesServicesToolStripMenuItem";
            this.gérerLesServicesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.gérerLesServicesToolStripMenuItem.Text = "Gérer les services";
            this.gérerLesServicesToolStripMenuItem.Click += new System.EventHandler(this.gérerLesServicesToolStripMenuItem_Click);
            // 
            // salariésToolStripMenuItem
            // 
            this.salariésToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerLesSalariésToolStripMenuItem});
            this.salariésToolStripMenuItem.Name = "salariésToolStripMenuItem";
            this.salariésToolStripMenuItem.Size = new System.Drawing.Size(87, 29);
            this.salariésToolStripMenuItem.Text = "Salariés";
            // 
            // gérerLesSalariésToolStripMenuItem
            // 
            this.gérerLesSalariésToolStripMenuItem.Name = "gérerLesSalariésToolStripMenuItem";
            this.gérerLesSalariésToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.gérerLesSalariésToolStripMenuItem.Text = "Gérer les salariés";
            this.gérerLesSalariésToolStripMenuItem.Click += new System.EventHandler(this.gérerLesSalariésToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1256, 106);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(465, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(320, 32);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Gestionnaire de salariés";
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.AllowUserToAddRows = false;
            this.dataGridViewEmployees.AllowUserToDeleteRows = false;
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(0, 231);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.ReadOnly = true;
            this.dataGridViewEmployees.RowHeadersWidth = 62;
            this.dataGridViewEmployees.RowTemplate.Height = 28;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(751, 370);
            this.dataGridViewEmployees.TabIndex = 2;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(150, 181);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(170, 26);
            this.txt_search.TabIndex = 3;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rechercher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filtrer";
            // 
            // listViewSites
            // 
            this.listViewSites.HideSelection = false;
            this.listViewSites.Location = new System.Drawing.Point(442, 181);
            this.listViewSites.Name = "listViewSites";
            this.listViewSites.Size = new System.Drawing.Size(143, 27);
            this.listViewSites.TabIndex = 6;
            this.listViewSites.UseCompatibleStateImageBehavior = false;
            this.listViewSites.SelectedIndexChanged += new System.EventHandler(this.listViewSites_SelectedIndexChanged);
            // 
            // listViewServices
            // 
            this.listViewServices.HideSelection = false;
            this.listViewServices.Location = new System.Drawing.Point(608, 181);
            this.listViewServices.Name = "listViewServices";
            this.listViewServices.Size = new System.Drawing.Size(143, 27);
            this.listViewServices.TabIndex = 7;
            this.listViewServices.UseCompatibleStateImageBehavior = false;
            this.listViewServices.SelectedIndexChanged += new System.EventHandler(this.listViewServices_SelectedIndexChanged);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 843);
            this.Controls.Add(this.listViewServices);
            this.Controls.Add(this.listViewSites);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "home";
            this.Text = "home";
            this.Load += new System.EventHandler(this.home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sitesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLesSitesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLesServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salariésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLesSalariésToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewSites;
        private System.Windows.Forms.ListView listViewServices;
    }
}