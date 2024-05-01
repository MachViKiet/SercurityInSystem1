namespace PHANHE1_PRJ
{
    partial class Management_User_Privs
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
            this.dgtv_UserPrivs = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.P_USERNAME = new System.Windows.Forms.TextBox();
            this.P_PRIVSNAME = new System.Windows.Forms.TextBox();
            this.P_OBJECTNAME = new System.Windows.Forms.TextBox();
            this.btn_Grant = new System.Windows.Forms.Button();
            this.btn_Revoke = new System.Windows.Forms.Button();
            this.GRANT_OPTION = new System.Windows.Forms.TextBox();
            this.dataGridView_tab_role = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgtv_UserPrivs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tab_role)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "USER PRIVS MANAGEMENT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgtv_UserPrivs
            // 
            this.dgtv_UserPrivs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtv_UserPrivs.Location = new System.Drawing.Point(6, 54);
            this.dgtv_UserPrivs.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgtv_UserPrivs.Name = "dgtv_UserPrivs";
            this.dgtv_UserPrivs.RowHeadersWidth = 62;
            this.dgtv_UserPrivs.RowTemplate.Height = 28;
            this.dgtv_UserPrivs.Size = new System.Drawing.Size(832, 173);
            this.dgtv_UserPrivs.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "USERNAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "PRIVSNAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "OBJECTNAME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "GRANT OPTION";
            // 
            // P_USERNAME
            // 
            this.P_USERNAME.Location = new System.Drawing.Point(112, 11);
            this.P_USERNAME.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.P_USERNAME.Name = "P_USERNAME";
            this.P_USERNAME.Size = new System.Drawing.Size(229, 22);
            this.P_USERNAME.TabIndex = 7;
            // 
            // P_PRIVSNAME
            // 
            this.P_PRIVSNAME.Location = new System.Drawing.Point(112, 12);
            this.P_PRIVSNAME.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.P_PRIVSNAME.Name = "P_PRIVSNAME";
            this.P_PRIVSNAME.Size = new System.Drawing.Size(229, 22);
            this.P_PRIVSNAME.TabIndex = 8;
            // 
            // P_OBJECTNAME
            // 
            this.P_OBJECTNAME.Location = new System.Drawing.Point(127, 12);
            this.P_OBJECTNAME.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.P_OBJECTNAME.Name = "P_OBJECTNAME";
            this.P_OBJECTNAME.Size = new System.Drawing.Size(312, 22);
            this.P_OBJECTNAME.TabIndex = 9;
            // 
            // btn_Grant
            // 
            this.btn_Grant.Location = new System.Drawing.Point(405, 116);
            this.btn_Grant.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Grant.Name = "btn_Grant";
            this.btn_Grant.Size = new System.Drawing.Size(102, 32);
            this.btn_Grant.TabIndex = 10;
            this.btn_Grant.Text = "GRANT";
            this.btn_Grant.UseVisualStyleBackColor = true;
            this.btn_Grant.Click += new System.EventHandler(this.btn_Grant_Click);
            // 
            // btn_Revoke
            // 
            this.btn_Revoke.Location = new System.Drawing.Point(228, 116);
            this.btn_Revoke.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Revoke.Name = "btn_Revoke";
            this.btn_Revoke.Size = new System.Drawing.Size(102, 32);
            this.btn_Revoke.TabIndex = 11;
            this.btn_Revoke.Text = "REVOKE";
            this.btn_Revoke.UseVisualStyleBackColor = true;
            this.btn_Revoke.Click += new System.EventHandler(this.btn_Revoke_Click);
            // 
            // GRANT_OPTION
            // 
            this.GRANT_OPTION.Location = new System.Drawing.Point(127, 10);
            this.GRANT_OPTION.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.GRANT_OPTION.Name = "GRANT_OPTION";
            this.GRANT_OPTION.Size = new System.Drawing.Size(312, 22);
            this.GRANT_OPTION.TabIndex = 12;
            // 
            // dataGridView_tab_role
            // 
            this.dataGridView_tab_role.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_tab_role.Location = new System.Drawing.Point(6, 241);
            this.dataGridView_tab_role.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_tab_role.Name = "dataGridView_tab_role";
            this.dataGridView_tab_role.RowHeadersWidth = 102;
            this.dataGridView_tab_role.RowTemplate.Height = 40;
            this.dataGridView_tab_role.Size = new System.Drawing.Size(832, 262);
            this.dataGridView_tab_role.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dataGridView_tab_role);
            this.panel2.Controls.Add(this.dgtv_UserPrivs);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(897, 682);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.btn_Revoke);
            this.panel3.Controls.Add(this.btn_Grant);
            this.panel3.Location = new System.Drawing.Point(6, 519);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(832, 162);
            this.panel3.TabIndex = 15;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.GRANT_OPTION);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(376, 65);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(444, 39);
            this.panel7.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.P_OBJECTNAME);
            this.panel6.Location = new System.Drawing.Point(376, 10);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(444, 39);
            this.panel6.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.P_PRIVSNAME);
            this.panel5.Location = new System.Drawing.Point(16, 65);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(349, 39);
            this.panel5.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.P_USERNAME);
            this.panel4.Location = new System.Drawing.Point(16, 10);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(349, 39);
            this.panel4.TabIndex = 0;
            // 
            // Management_User_Privs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(925, 545);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Management_User_Privs";
            this.Text = "Quản Lý Quyền Của User";
            ((System.ComponentModel.ISupportInitialize)(this.dgtv_UserPrivs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tab_role)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgtv_UserPrivs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox P_USERNAME;
        private System.Windows.Forms.TextBox P_PRIVSNAME;
        private System.Windows.Forms.TextBox P_OBJECTNAME;
        private System.Windows.Forms.Button btn_Grant;
        private System.Windows.Forms.Button btn_Revoke;
        private System.Windows.Forms.TextBox GRANT_OPTION;
        private System.Windows.Forms.DataGridView dataGridView_tab_role;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
    }
}