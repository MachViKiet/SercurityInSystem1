namespace PHANHE1_PRJ
{
    partial class Management_Roles
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
            this.dtgv_ROLE = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.P_ROLENAME = new System.Windows.Forms.TextBox();
            this.P_PASSWORD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_CreateRole = new System.Windows.Forms.Button();
            this.btn_DropRole = new System.Windows.Forms.Button();
            this.btn_AlterRole = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ROLE)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgv_ROLE
            // 
            this.dtgv_ROLE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_ROLE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ROLE.Location = new System.Drawing.Point(2, 44);
            this.dtgv_ROLE.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtgv_ROLE.Name = "dtgv_ROLE";
            this.dtgv_ROLE.RowHeadersWidth = 62;
            this.dtgv_ROLE.RowTemplate.Height = 28;
            this.dtgv_ROLE.Size = new System.Drawing.Size(428, 298);
            this.dtgv_ROLE.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Role Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Role Password";
            // 
            // P_ROLENAME
            // 
            this.P_ROLENAME.Location = new System.Drawing.Point(592, 54);
            this.P_ROLENAME.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.P_ROLENAME.Name = "P_ROLENAME";
            this.P_ROLENAME.Size = new System.Drawing.Size(198, 22);
            this.P_ROLENAME.TabIndex = 3;
            // 
            // P_PASSWORD
            // 
            this.P_PASSWORD.Location = new System.Drawing.Point(592, 103);
            this.P_PASSWORD.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.P_PASSWORD.Name = "P_PASSWORD";
            this.P_PASSWORD.Size = new System.Drawing.Size(198, 22);
            this.P_PASSWORD.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(280, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "ROLES MANAGEMENT";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_CreateRole
            // 
            this.btn_CreateRole.Location = new System.Drawing.Point(592, 157);
            this.btn_CreateRole.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_CreateRole.Name = "btn_CreateRole";
            this.btn_CreateRole.Size = new System.Drawing.Size(198, 40);
            this.btn_CreateRole.TabIndex = 6;
            this.btn_CreateRole.Text = "CREATE ROLE";
            this.btn_CreateRole.UseVisualStyleBackColor = true;
            this.btn_CreateRole.Click += new System.EventHandler(this.btn_CreateRole_Click);
            // 
            // btn_DropRole
            // 
            this.btn_DropRole.Location = new System.Drawing.Point(592, 228);
            this.btn_DropRole.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_DropRole.Name = "btn_DropRole";
            this.btn_DropRole.Size = new System.Drawing.Size(198, 40);
            this.btn_DropRole.TabIndex = 7;
            this.btn_DropRole.Text = "DROP ROLE";
            this.btn_DropRole.UseVisualStyleBackColor = true;
            this.btn_DropRole.Click += new System.EventHandler(this.btn_DropRole_Click);
            // 
            // btn_AlterRole
            // 
            this.btn_AlterRole.Location = new System.Drawing.Point(592, 287);
            this.btn_AlterRole.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_AlterRole.Name = "btn_AlterRole";
            this.btn_AlterRole.Size = new System.Drawing.Size(198, 40);
            this.btn_AlterRole.TabIndex = 8;
            this.btn_AlterRole.Text = "ALTER ROLE";
            this.btn_AlterRole.UseVisualStyleBackColor = true;
            this.btn_AlterRole.Click += new System.EventHandler(this.btn_AlterRole_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_AlterRole);
            this.panel1.Controls.Add(this.dtgv_ROLE);
            this.panel1.Controls.Add(this.btn_DropRole);
            this.panel1.Controls.Add(this.btn_CreateRole);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.P_PASSWORD);
            this.panel1.Controls.Add(this.P_ROLENAME);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 345);
            this.panel1.TabIndex = 9;
            // 
            // Management_Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(962, 376);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Management_Roles";
            this.Text = "Management_Roles";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ROLE)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_ROLE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox P_ROLENAME;
        private System.Windows.Forms.TextBox P_PASSWORD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_CreateRole;
        private System.Windows.Forms.Button btn_DropRole;
        private System.Windows.Forms.Button btn_AlterRole;
        private System.Windows.Forms.Panel panel1;
    }
}