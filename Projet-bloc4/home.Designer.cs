
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
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
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
            this.gérerLesSitesToolStripMenuItem.Size = new System.Drawing.Size(227, 34);
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
            this.gérerLesServicesToolStripMenuItem.Size = new System.Drawing.Size(248, 34);
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
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "home";
            this.Text = "home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}