namespace PHANHE1_PRJ
{
    partial class QUANTRI_CONSOLE
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
            this.btn_MngUsers = new System.Windows.Forms.Button();
            this.btn_MngRoles = new System.Windows.Forms.Button();
            this.btn_GrantRoletoUser = new System.Windows.Forms.Button();
            this.btn_MngUserPrivs = new System.Windows.Forms.Button();
            this.btn_MngRolePrivs = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_MngUsers
            // 
            this.btn_MngUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MngUsers.Location = new System.Drawing.Point(21, 34);
            this.btn_MngUsers.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_MngUsers.Name = "btn_MngUsers";
            this.btn_MngUsers.Size = new System.Drawing.Size(348, 124);
            this.btn_MngUsers.TabIndex = 5;
            this.btn_MngUsers.Text = "Danh Sách Người Dùng (Users)";
            this.btn_MngUsers.UseVisualStyleBackColor = true;
            this.btn_MngUsers.Click += new System.EventHandler(this.btn_MngUsers_Click);
            // 
            // btn_MngRoles
            // 
            this.btn_MngRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MngRoles.Location = new System.Drawing.Point(439, 34);
            this.btn_MngRoles.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_MngRoles.Name = "btn_MngRoles";
            this.btn_MngRoles.Size = new System.Drawing.Size(348, 124);
            this.btn_MngRoles.TabIndex = 6;
            this.btn_MngRoles.Text = "Danh Sách Vai Trò   (Role)";
            this.btn_MngRoles.UseVisualStyleBackColor = true;
            this.btn_MngRoles.Click += new System.EventHandler(this.btn_MngRoles_Click);
            // 
            // btn_GrantRoletoUser
            // 
            this.btn_GrantRoletoUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GrantRoletoUser.Location = new System.Drawing.Point(439, 199);
            this.btn_GrantRoletoUser.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_GrantRoletoUser.Name = "btn_GrantRoletoUser";
            this.btn_GrantRoletoUser.Size = new System.Drawing.Size(348, 124);
            this.btn_GrantRoletoUser.TabIndex = 9;
            this.btn_GrantRoletoUser.Text = "Gán Quyền Cho Users";
            this.btn_GrantRoletoUser.UseVisualStyleBackColor = true;
            this.btn_GrantRoletoUser.Click += new System.EventHandler(this.btn_GrantRoletoUser_Click);
            // 
            // btn_MngUserPrivs
            // 
            this.btn_MngUserPrivs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MngUserPrivs.Location = new System.Drawing.Point(30, 199);
            this.btn_MngUserPrivs.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_MngUserPrivs.Name = "btn_MngUserPrivs";
            this.btn_MngUserPrivs.Size = new System.Drawing.Size(348, 124);
            this.btn_MngUserPrivs.TabIndex = 10;
            this.btn_MngUserPrivs.Text = "Quản Lý Quyền    (User\'s Privilege)";
            this.btn_MngUserPrivs.UseVisualStyleBackColor = true;
            this.btn_MngUserPrivs.Click += new System.EventHandler(this.btn_MngUserPrivs_Click);
            // 
            // btn_MngRolePrivs
            // 
            this.btn_MngRolePrivs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MngRolePrivs.Location = new System.Drawing.Point(843, 34);
            this.btn_MngRolePrivs.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_MngRolePrivs.Name = "btn_MngRolePrivs";
            this.btn_MngRolePrivs.Size = new System.Drawing.Size(348, 124);
            this.btn_MngRolePrivs.TabIndex = 11;
            this.btn_MngRolePrivs.Text = "Quản Lý Quyền    (Role\'s Privilege)";
            this.btn_MngRolePrivs.UseVisualStyleBackColor = true;
            this.btn_MngRolePrivs.Click += new System.EventHandler(this.btn_MngRolePrivs_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_MngRolePrivs);
            this.panel1.Controls.Add(this.btn_MngUserPrivs);
            this.panel1.Controls.Add(this.btn_GrantRoletoUser);
            this.panel1.Controls.Add(this.btn_MngRoles);
            this.panel1.Controls.Add(this.btn_MngUsers);
            this.panel1.Location = new System.Drawing.Point(6, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1221, 377);
            this.panel1.TabIndex = 12;
            // 
            // QUANTRI_CONSOLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 410);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "QUANTRI_CONSOLE";
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.QUANTRI_CONSOLE_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_MngUsers;
        private System.Windows.Forms.Button btn_MngRoles;
        private System.Windows.Forms.Button btn_GrantRoletoUser;
        private System.Windows.Forms.Button btn_MngUserPrivs;
        private System.Windows.Forms.Button btn_MngRolePrivs;
        private System.Windows.Forms.Panel panel1;
    }
}