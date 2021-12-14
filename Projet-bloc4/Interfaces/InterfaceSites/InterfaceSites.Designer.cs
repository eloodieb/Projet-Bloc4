
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ville = new System.Windows.Forms.TextBox();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_register = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_start = new System.Windows.Forms.Button();
            this.bt_previous = new System.Windows.Forms.Button();
            this.bt_following = new System.Windows.Forms.Button();
            this.bt_end = new System.Windows.Forms.Button();
            this.lbl_date_creation = new System.Windows.Forms.Label();
            this.lbl_date_modification = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date de création";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date de modification";
            // 
            // txt_ville
            // 
            this.txt_ville.Location = new System.Drawing.Point(305, 59);
            this.txt_ville.Name = "txt_ville";
            this.txt_ville.Size = new System.Drawing.Size(100, 26);
            this.txt_ville.TabIndex = 4;
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(445, 59);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(90, 28);
            this.bt_add.TabIndex = 8;
            this.bt_add.Text = "Ajouter";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_register
            // 
            this.bt_register.Location = new System.Drawing.Point(445, 107);
            this.bt_register.Name = "bt_register";
            this.bt_register.Size = new System.Drawing.Size(90, 28);
            this.bt_register.TabIndex = 9;
            this.bt_register.Text = "Enregistrer";
            this.bt_register.UseVisualStyleBackColor = true;
            this.bt_register.Click += new System.EventHandler(this.bt_register_Click);
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(445, 148);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(90, 28);
            this.bt_update.TabIndex = 10;
            this.bt_update.Text = "Modifier";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(445, 194);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(90, 28);
            this.bt_delete.TabIndex = 11;
            this.bt_delete.Text = "Supprimer";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(15, 49);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(90, 28);
            this.bt_start.TabIndex = 12;
            this.bt_start.Text = "Début";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // bt_previous
            // 
            this.bt_previous.Location = new System.Drawing.Point(123, 49);
            this.bt_previous.Name = "bt_previous";
            this.bt_previous.Size = new System.Drawing.Size(90, 28);
            this.bt_previous.TabIndex = 13;
            this.bt_previous.Text = "Précédent";
            this.bt_previous.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bt_previous.UseVisualStyleBackColor = true;
            this.bt_previous.Click += new System.EventHandler(this.bt_previous_Click);
            // 
            // bt_following
            // 
            this.bt_following.Location = new System.Drawing.Point(230, 49);
            this.bt_following.Name = "bt_following";
            this.bt_following.Size = new System.Drawing.Size(90, 28);
            this.bt_following.TabIndex = 14;
            this.bt_following.Text = "Suivant";
            this.bt_following.UseVisualStyleBackColor = true;
            this.bt_following.Click += new System.EventHandler(this.bt_following_Click);
            // 
            // bt_end
            // 
            this.bt_end.Location = new System.Drawing.Point(337, 49);
            this.bt_end.Name = "bt_end";
            this.bt_end.Size = new System.Drawing.Size(90, 28);
            this.bt_end.TabIndex = 15;
            this.bt_end.Text = "Fin";
            this.bt_end.UseVisualStyleBackColor = true;
            this.bt_end.Click += new System.EventHandler(this.bt_end_Click);
            // 
            // lbl_date_creation
            // 
            this.lbl_date_creation.AutoSize = true;
            this.lbl_date_creation.Location = new System.Drawing.Point(301, 115);
            this.lbl_date_creation.Name = "lbl_date_creation";
            this.lbl_date_creation.Size = new System.Drawing.Size(14, 20);
            this.lbl_date_creation.TabIndex = 16;
            this.lbl_date_creation.Text = "-";
            this.lbl_date_creation.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_date_modification
            // 
            this.lbl_date_modification.AutoSize = true;
            this.lbl_date_modification.Location = new System.Drawing.Point(301, 161);
            this.lbl_date_modification.Name = "lbl_date_modification";
            this.lbl_date_modification.Size = new System.Drawing.Size(14, 20);
            this.lbl_date_modification.TabIndex = 17;
            this.lbl_date_modification.Text = "-";
            this.lbl_date_modification.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(442, 53);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(14, 20);
            this.lbl_id.TabIndex = 18;
            this.lbl_id.Text = "-";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_start);
            this.groupBox1.Controls.Add(this.lbl_id);
            this.groupBox1.Controls.Add(this.bt_previous);
            this.groupBox1.Controls.Add(this.bt_following);
            this.groupBox1.Controls.Add(this.bt_end);
            this.groupBox1.Location = new System.Drawing.Point(114, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 101);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // InterfaceSites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_date_modification);
            this.Controls.Add(this.lbl_date_creation);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.bt_register);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.txt_ville);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "InterfaceSites";
            this.Text = "Gérer les sites";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ville;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_register;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Button bt_previous;
        private System.Windows.Forms.Button bt_following;
        private System.Windows.Forms.Button bt_end;
        private System.Windows.Forms.Label lbl_date_creation;
        private System.Windows.Forms.Label lbl_date_modification;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}