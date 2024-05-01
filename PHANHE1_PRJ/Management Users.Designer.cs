namespace PHANHE1_PRJ
{
    partial class Management_Users
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.P_USERNAME = new System.Windows.Forms.TextBox();
            this.P_PASSWORD = new System.Windows.Forms.TextBox();
            this.btn_CREATEUSER = new System.Windows.Forms.Button();
            this.btn_DROPUSER = new System.Windows.Forms.Button();
            this.btn_ALTERUSER = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "USERS MANAGEMENT";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 104);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(214, 282);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(14, 29);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(84, 16);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "USERNAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "PASSWORD";
            // 
            // P_USERNAME
            // 
            this.P_USERNAME.Location = new System.Drawing.Point(147, 24);
            this.P_USERNAME.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.P_USERNAME.Name = "P_USERNAME";
            this.P_USERNAME.Size = new System.Drawing.Size(166, 22);
            this.P_USERNAME.TabIndex = 4;
            // 
            // P_PASSWORD
            // 
            this.P_PASSWORD.Location = new System.Drawing.Point(147, 79);
            this.P_PASSWORD.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.P_PASSWORD.Name = "P_PASSWORD";
            this.P_PASSWORD.Size = new System.Drawing.Size(166, 22);
            this.P_PASSWORD.TabIndex = 5;
            // 
            // btn_CREATEUSER
            // 
            this.btn_CREATEUSER.Location = new System.Drawing.Point(147, 137);
            this.btn_CREATEUSER.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_CREATEUSER.Name = "btn_CREATEUSER";
            this.btn_CREATEUSER.Size = new System.Drawing.Size(166, 33);
            this.btn_CREATEUSER.TabIndex = 6;
            this.btn_CREATEUSER.Text = "CREATE USER";
            this.btn_CREATEUSER.UseVisualStyleBackColor = true;
            this.btn_CREATEUSER.Click += new System.EventHandler(this.btn_CREATEUSER_Click);
            // 
            // btn_DROPUSER
            // 
            this.btn_DROPUSER.Location = new System.Drawing.Point(147, 191);
            this.btn_DROPUSER.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_DROPUSER.Name = "btn_DROPUSER";
            this.btn_DROPUSER.Size = new System.Drawing.Size(166, 33);
            this.btn_DROPUSER.TabIndex = 7;
            this.btn_DROPUSER.Text = "DELETE USER";
            this.btn_DROPUSER.UseVisualStyleBackColor = true;
            this.btn_DROPUSER.Click += new System.EventHandler(this.btn_DROPUSER_Click);
            // 
            // btn_ALTERUSER
            // 
            this.btn_ALTERUSER.Location = new System.Drawing.Point(147, 246);
            this.btn_ALTERUSER.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_ALTERUSER.Name = "btn_ALTERUSER";
            this.btn_ALTERUSER.Size = new System.Drawing.Size(166, 33);
            this.btn_ALTERUSER.TabIndex = 8;
            this.btn_ALTERUSER.Text = "UPDATE PASSWORD";
            this.btn_ALTERUSER.UseVisualStyleBackColor = true;
            this.btn_ALTERUSER.Click += new System.EventHandler(this.btn_ALTERUSER_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_ALTERUSER);
            this.panel1.Controls.Add(this.btn_DROPUSER);
            this.panel1.Controls.Add(this.btn_CREATEUSER);
            this.panel1.Controls.Add(this.P_PASSWORD);
            this.panel1.Controls.Add(this.P_USERNAME);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Label2);
            this.panel1.Location = new System.Drawing.Point(410, 93);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 298);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(7, 8);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(816, 441);
            this.panel2.TabIndex = 10;
            // 
            // Management_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(925, 545);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Management_Users";
            this.Text = "Management_Users";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox P_USERNAME;
        private System.Windows.Forms.TextBox P_PASSWORD;
        private System.Windows.Forms.Button btn_CREATEUSER;
        private System.Windows.Forms.Button btn_DROPUSER;
        private System.Windows.Forms.Button btn_ALTERUSER;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}