
namespace Projet_bloc4.Interfaces.InterfaceServices
{
    partial class InterfaceServices
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
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_register = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.dataGridViewServices = new System.Windows.Forms.DataGridView();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_service = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(576, 47);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(106, 32);
            this.bt_add.TabIndex = 6;
            this.bt_add.Text = "Ajouter";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_register
            // 
            this.bt_register.Location = new System.Drawing.Point(576, 99);
            this.bt_register.Name = "bt_register";
            this.bt_register.Size = new System.Drawing.Size(106, 32);
            this.bt_register.TabIndex = 7;
            this.bt_register.Text = "Enregistrer";
            this.bt_register.UseVisualStyleBackColor = true;
            this.bt_register.Click += new System.EventHandler(this.bt_register_Click);
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(576, 153);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(106, 32);
            this.bt_update.TabIndex = 8;
            this.bt_update.Text = "Modifier";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(576, 214);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(106, 32);
            this.bt_delete.TabIndex = 9;
            this.bt_delete.Text = "Supprimer";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(73, 99);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(14, 20);
            this.lbl_id.TabIndex = 15;
            this.lbl_id.Text = "-";
            this.lbl_id.Visible = false;
            // 
            // dataGridViewServices
            // 
            this.dataGridViewServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServices.Location = new System.Drawing.Point(77, 142);
            this.dataGridViewServices.Name = "dataGridViewServices";
            this.dataGridViewServices.RowHeadersWidth = 62;
            this.dataGridViewServices.RowTemplate.Height = 28;
            this.dataGridViewServices.Size = new System.Drawing.Size(423, 136);
            this.dataGridViewServices.TabIndex = 17;
            this.dataGridViewServices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewServices_CellContentClick);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(73, 53);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(61, 20);
            this.lbl_name.TabIndex = 4;
            this.lbl_name.Text = "Service";
            // 
            // txt_service
            // 
            this.txt_service.Location = new System.Drawing.Point(238, 53);
            this.txt_service.Name = "txt_service";
            this.txt_service.Size = new System.Drawing.Size(164, 26);
            this.txt_service.TabIndex = 5;
            // 
            // InterfaceServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 567);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.dataGridViewServices);
            this.Controls.Add(this.txt_service);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.bt_register);
            this.Controls.Add(this.bt_add);
            this.Name = "InterfaceServices";
            this.Text = "Gérer les services";
            this.Load += new System.EventHandler(this.InterfaceServices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_register;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.DataGridView dataGridViewServices;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_service;
    }
}