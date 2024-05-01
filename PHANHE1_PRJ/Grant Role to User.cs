using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace PHANHE1_PRJ
{
    public partial class Grant_Role_to_User : Form
    {
        OracleConnection con = new OracleConnection(new CONNECTIONSTRING().getString());
        OracleCommand command = null;
        public Grant_Role_to_User()
        {
            InitializeComponent(); 
            initdata();
        }

        private void initdata ()
        {
            // dataGridView1

            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                {
                    con.Open();
                }
                DataTable dt = new DataTable();
                OracleDataAdapter adpt = new OracleDataAdapter("SELECT * FROM DBA_ROLE_PRIVS where GRANTED_ROLE like 'RL_TRUONGHOC_%'", con);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_GrantRoletoUser_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                command = new OracleCommand("BEGIN\nQL_TRUONGHOC_X.GRANT_ROLE_TO_USER(:P_ROLENAME,:P_USERNAME);\nEND;", con);
                command.Parameters.Add(new OracleParameter("P_ROLENAME", P_ROLENAME.Text));
                command.Parameters.Add(new OracleParameter("P_USERNAME", P_USERNAME.Text));
                
                command.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("GRANT ROLE TO USER SUCESSFULLY");
                initdata();

            }

            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void button_revoke_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                command = new OracleCommand("BEGIN\nQL_TRUONGHOC_X.REVOKE_ROLE_TO_USER(:P_ROLENAME,:P_USERNAME);\nEND;", con);
                command.Parameters.Add(new OracleParameter("P_ROLENAME", P_ROLENAME.Text));
                command.Parameters.Add(new OracleParameter("P_USERNAME", P_USERNAME.Text));

                command.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("REVOKE ROLE TO USER SUCESSFULLY");
                initdata();

            }

            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
