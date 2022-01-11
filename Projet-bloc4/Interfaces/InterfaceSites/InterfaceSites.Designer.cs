
namespace Projet_bloc4.Interfaces.InterfaceSites
{
    partial class InterfaceSites
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_register = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.dataGridViewSites = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSites)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ville";
            // 
            // txt_city
            // 
            this.txt_city.Location = new System.Drawing.Point(305, 59);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(100, 26);
            this.txt_city.TabIndex = 4;
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(577, 47);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(102, 50);
            this.bt_add.TabIndex = 8;
            this.bt_add.Text = "Ajouter";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_register
            // 
            this.bt_register.Location = new System.Drawing.Point(577, 115);
            this.bt_register.Name = "bt_register";
            this.bt_register.Size = new System.Drawing.Size(102, 50);
            this.bt_register.TabIndex = 9;
            this.bt_register.Text = "Enregistrer";
            this.bt_register.UseVisualStyleBackColor = true;
            this.bt_register.Click += new System.EventHandler(this.bt_register_Click);
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(577, 267);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(103, 50);
            this.bt_update.TabIndex = 10;
            this.bt_update.Text = "Modifier";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(577, 189);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(103, 50);
            this.bt_delete.TabIndex = 11;
            this.bt_delete.Text = "Supprimer";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(119, 115);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(14, 20);
            this.lbl_id.TabIndex = 19;
            this.lbl_id.Text = "-";
            // 
            // dataGridViewSites
            // 
            this.dataGridViewSites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSites.Location = new System.Drawing.Point(123, 174);
            this.dataGridViewSites.Name = "dataGridViewSites";
            this.dataGridViewSites.RowHeadersWidth = 62;
            this.dataGridViewSites.RowTemplate.Height = 28;
            this.dataGridViewSites.Size = new System.Drawing.Size(388, 179);
            this.dataGridViewSites.TabIndex = 20;
            this.dataGridViewSites.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSites_CellContentClick);
            // 
            // InterfaceSites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewSites);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.bt_register);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.txt_city);
            this.Controls.Add(this.label1);
            this.Name = "InterfaceSites";
            this.Text = "Gérer les sites";
            this.Load += new System.EventHandler(this.InterfaceSites_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSites)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_register;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.DataGridView dataGridViewSites;
    }
}