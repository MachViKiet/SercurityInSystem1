namespace PHANHE1_PRJ
{
    partial class Management_Role_Privs
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
            this.btn_Revoke = new System.Windows.Forms.Button();
            this.btn_Grant = new System.Windows.Forms.Button();
            this.P_OBJECTNAME = new System.Windows.Forms.TextBox();
            this.P_PRIVSNAME = new System.Windows.Forms.TextBox();
            this.P_ROLENAME = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgtv_RolePrivs = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_tab_role = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgtv_RolePrivs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tab_role)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Revoke
            // 
            this.btn_Revoke.Location = new System.Drawing.Point(500, 62);
            this.btn_Revoke.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Revoke.Name = "btn_Revoke";
            this.btn_Revoke.Size = new System.Drawing.Size(102, 32);
            this.btn_Revoke.TabIndex = 23;
            this.btn_Revoke.Text = "REVOKE";
            this.btn_Revoke.UseVisualStyleBackColor = true;
            this.btn_Revoke.Click += new System.EventHandler(this.btn_Revoke_Click);
            // 
            // btn_Grant
            // 
            this.btn_Grant.Location = new System.Drawing.Point(500, 18);
            this.btn_Grant.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Grant.Name = "btn_Grant";
            this.btn_Grant.Size = new System.Drawing.Size(102, 32);
            this.btn_Grant.TabIndex = 22;
            this.btn_Grant.Text = "GRANT";
            this.btn_Grant.UseVisualStyleBackColor = true;
            this.btn_Grant.Click += new System.EventHandler(this.btn_Grant_Click);
            // 
            // P_OBJECTNAME
            // 
            this.P_OBJECTNAME.Location = new System.Drawing.Point(128, 82);
            this.P_OBJECTNAME.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.P_OBJECTNAME.Name = "P_OBJECTNAME";
            this.P_OBJECTNAME.Size = new System.Drawing.Size(282, 22);
            this.P_OBJECTNAME.TabIndex = 21;
            // 
            // P_PRIVSNAME
            // 
            this.P_PRIVSNAME.Location = new System.Drawing.Point(128, 45);
            this.P_PRIVSNAME.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.P_PRIVSNAME.Name = "P_PRIVSNAME";
            this.P_PRIVSNAME.Size = new System.Drawing.Size(282, 22);
            this.P_PRIVSNAME.TabIndex = 20;
            // 
            // P_ROLENAME
            // 
            this.P_ROLENAME.Location = new System.Drawing.Point(128, 7);
            this.P_ROLENAME.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.P_ROLENAME.Name = "P_ROLENAME";
            this.P_ROLENAME.Size = new System.Drawing.Size(282, 22);
            this.P_ROLENAME.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "OBJECTNAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "PRIVSNAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "ROLENAME";
            // 
            // dgtv_RolePrivs
            // 
            this.dgtv_RolePrivs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtv_RolePrivs.Location = new System.Drawing.Point(14, 62);
            this.dgtv_RolePrivs.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgtv_RolePrivs.Name = "dgtv_RolePrivs";
            this.dgtv_RolePrivs.RowHeadersWidth = 62;
            this.dgtv_RolePrivs.RowTemplate.Height = 28;
            this.dgtv_RolePrivs.Size = new System.Drawing.Size(1006, 204);
            this.dgtv_RolePrivs.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "ROLE PRIVS MANAGEMENT ";
            // 
            // dataGridView_tab_role
            // 
            this.dataGridView_tab_role.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_tab_role.Location = new System.Drawing.Point(14, 287);
            this.dataGridView_tab_role.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_tab_role.Name = "dataGridView_tab_role";
            this.dataGridView_tab_role.RowHeadersWidth = 102;
            this.dataGridView_tab_role.RowTemplate.Height = 40;
            this.dataGridView_tab_role.Size = new System.Drawing.Size(1006, 306);
            this.dataGridView_tab_role.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridView_tab_role);
            this.panel1.Controls.Add(this.dgtv_RolePrivs);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 738);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Revoke);
            this.panel2.Controls.Add(this.btn_Grant);
            this.panel2.Controls.Add(this.P_OBJECTNAME);
            this.panel2.Controls.Add(this.P_PRIVSNAME);
            this.panel2.Controls.Add(this.P_ROLENAME);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(178, 612);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(663, 118);
            this.panel2.TabIndex = 25;
            // 
            // Management_Role_Privs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(962, 545);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Management_Role_Privs";
            this.Text = "MANAGEMENT ROLE PRIVS";
            ((System.ComponentModel.ISupportInitialize)(this.dgtv_RolePrivs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tab_role)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Revoke;
        private System.Windows.Forms.Button btn_Grant;
        private System.Windows.Forms.TextBox P_OBJECTNAME;
        private System.Windows.Forms.TextBox P_PRIVSNAME;
        private System.Windows.Forms.TextBox P_ROLENAME;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgtv_RolePrivs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_tab_role;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}