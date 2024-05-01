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
    public partial class Management_User_Privs : Form
    {
        OracleConnection con = new OracleConnection(new CONNECTIONSTRING().getString());
        OracleCommand command = null;
        public Management_User_Privs()
        {
            InitializeComponent();
            display_user_privs();
        }

        private void display_user_privs()
        {
            try
            {
                DataTable dt = new DataTable();
                con.Open();
                OracleDataAdapter adpt = new OracleDataAdapter("SELECT * FROM USER_SYS_PRIVS where username like 'QL_TRUONGHOC_%' or username like 'NS%' or username like 'SV%'", con);
                adpt.Fill(dt);
                dgtv_UserPrivs.DataSource = dt;
                con.Close();

                DataTable dt2 = new DataTable();
                con.Open();
                OracleDataAdapter adpt2 = new OracleDataAdapter("SELECT * FROM USER_TAB_PRIVS", con);
                adpt2.Fill(dt2);
                dataGridView_tab_role.DataSource = dt2;
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Grant_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                command = new OracleCommand("BEGIN\nQL_TRUONGHOC_X.GRANT_PRIVS_USER(:P_USERNAME,:P_PRIVSNAME,:P_OBJECTNAME,:GRANT_OPTION);\nEND;", con);
                command.Parameters.Add(new OracleParameter("P_USERNAME", P_USERNAME.Text));
                command.Parameters.Add(new OracleParameter("P_PRIVSNAME", P_PRIVSNAME.Text));
                command.Parameters.Add(new OracleParameter("P_OBJECTNAME", P_OBJECTNAME.Text));
                command.Parameters.Add(new OracleParameter("GRANT_OPTION", GRANT_OPTION.Text));

                command.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("GRANT PRIVS SUCESSFULLY");
                //clearUserInput();
                //display_users();
                display_user_privs();
            }

            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_Revoke_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                command = new OracleCommand("BEGIN\nQL_TRUONGHOC_X.REVOKE_PRIVS_USER(:P_USERNAME,:P_PRIVSNAME,:P_OBJECTNAME);\nEND;", con);
                command.Parameters.Add(new OracleParameter("P_USERNAME", P_USERNAME.Text));
                command.Parameters.Add(new OracleParameter("P_PRIVSNAME", P_PRIVSNAME.Text));
                command.Parameters.Add(new OracleParameter("P_OBJECTNAME", P_OBJECTNAME.Text));

                command.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("REVOKE PRIVS SUCESSFULLY");
                //clearUserInput();
                //display_users();
                display_user_privs();

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
