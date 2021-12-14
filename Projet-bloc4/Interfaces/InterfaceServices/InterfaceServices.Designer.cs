
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_creationDate = new System.Windows.Forms.Label();
            this.lbl_updateDate = new System.Windows.Forms.Label();
            this.txt_service = new System.Windows.Forms.TextBox();
            this.lbl_creation_date = new System.Windows.Forms.Label();
            this.lbl_update_date = new System.Windows.Forms.Label();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_register = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_start = new System.Windows.Forms.Button();
            this.bt_previous = new System.Windows.Forms.Button();
            this.bt_next = new System.Windows.Forms.Button();
            this.bt_end = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(32, 41);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(61, 20);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Service";
            // 
            // lbl_creationDate
            // 
            this.lbl_creationDate.AutoSize = true;
            this.lbl_creationDate.Location = new System.Drawing.Point(32, 99);
            this.lbl_creationDate.Name = "lbl_creationDate";
            this.lbl_creationDate.Size = new System.Drawing.Size(127, 20);
            this.lbl_creationDate.TabIndex = 1;
            this.lbl_creationDate.Text = "Date de création";
            // 
            // lbl_updateDate
            // 
            this.lbl_updateDate.AutoSize = true;
            this.lbl_updateDate.Location = new System.Drawing.Point(32, 153);
            this.lbl_updateDate.Name = "lbl_updateDate";
            this.lbl_updateDate.Size = new System.Drawing.Size(155, 20);
            this.lbl_updateDate.TabIndex = 2;
            this.lbl_updateDate.Text = "Date de modification";
            // 
            // txt_service
            // 
            this.txt_service.Location = new System.Drawing.Point(197, 41);
            this.txt_service.Name = "txt_service";
            this.txt_service.Size = new System.Drawing.Size(164, 26);
            this.txt_service.TabIndex = 3;
            // 
            // lbl_creation_date
            // 
            this.lbl_creation_date.AutoSize = true;
            this.lbl_creation_date.Location = new System.Drawing.Point(195, 99);
            this.lbl_creation_date.Name = "lbl_creation_date";
            this.lbl_creation_date.Size = new System.Drawing.Size(14, 20);
            this.lbl_creation_date.TabIndex = 4;
            this.lbl_creation_date.Text = "-";
            // 
            // lbl_update_date
            // 
            this.lbl_update_date.AutoSize = true;
            this.lbl_update_date.Location = new System.Drawing.Point(195, 153);
            this.lbl_update_date.Name = "lbl_update_date";
            this.lbl_update_date.Size = new System.Drawing.Size(14, 20);
            this.lbl_update_date.TabIndex = 5;
            this.lbl_update_date.Text = "-";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_name);
            this.groupBox1.Controls.Add(this.lbl_creationDate);
            this.groupBox1.Controls.Add(this.lbl_updateDate);
            this.groupBox1.Controls.Add(this.txt_service);
            this.groupBox1.Controls.Add(this.lbl_creation_date);
            this.groupBox1.Controls.Add(this.lbl_update_date);
            this.groupBox1.Location = new System.Drawing.Point(67, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 196);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Service";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(535, 295);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(14, 20);
            this.lbl_id.TabIndex = 15;
            this.lbl_id.Text = "-";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_end);
            this.groupBox2.Controls.Add(this.bt_start);
            this.groupBox2.Controls.Add(this.bt_previous);
            this.groupBox2.Controls.Add(this.bt_next);
            this.groupBox2.Location = new System.Drawing.Point(67, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 91);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // InterfaceServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 567);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.bt_register);
            this.Controls.Add(this.bt_add);
            this.Name = "InterfaceServices";
            this.Text = "Gérer les services";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_creationDate;
        private System.Windows.Forms.Label lbl_updateDate;
        private System.Windows.Forms.TextBox txt_service;
        private System.Windows.Forms.Label lbl_creation_date;
        private System.Windows.Forms.Label lbl_update_date;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_register;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Button bt_previous;
        private System.Windows.Forms.Button bt_next;
        private System.Windows.Forms.Button bt_end;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}