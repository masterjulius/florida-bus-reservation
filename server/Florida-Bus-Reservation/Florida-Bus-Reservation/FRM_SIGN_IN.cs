using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Florida_Bus_Reservation
{
    public partial class FRM_SIGN_IN : Form
    {
        // initialize variable here
        private Form frmParent;
        public FRM_SIGN_IN(Form frm)
        {
            InitializeComponent();
            this.frmParent = frm;
        }

        private void FRM_SIGN_IN_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_sign_in_Click(object sender, EventArgs e)
        {
            this.sign_in_action();
        }

        private void sign_in_action()
        {
            if (this._user_sign_in(this.txt_username.Text, this.txt_password.Text) == true)
            {
                frmParent.Text = this.txt_username.Text + "@FLORIDA BUS RESERVATION SYSTEM";
                frmParent.Refresh();
                this.Dispose();
                
            }
        }

        private Boolean _user_sign_in(string username, string password)
        {
            if (!string.IsNullOrEmpty(this.txt_username.Text) && !string.IsNullOrEmpty(this.txt_password.Text))
            {
                Classes.Connection Connection = new Classes.Connection();
                using (MySqlConnection conn = new MySqlConnection(Connection.connStr))
                {
                    string stmt = "select `user_id`, `user_name`, `user_password`, `user_role` from `tbl_users` where `user_name`=@user_name and `user_password`=@user_password and `user_is_active`=1";
                    using (MySqlCommand cmd = new MySqlCommand(stmt, conn))
                    {
                        cmd.Parameters.Add("@user_name", MySqlDbType.VarChar).Value = username;
                        cmd.Parameters.Add("@user_password", MySqlDbType.VarChar).Value = password;
                        conn.Open();
                        MySqlDataReader dr = cmd.ExecuteReader();

                        if (dr.HasRows)
                        {
                            // get the username and password for case sensitivity comparing
                            dr.Read();
                            string _g_username = dr["user_name"].ToString();
                            string _g_password = dr["user_password"].ToString();
                            if (username != _g_username || password != _g_password)
                            {
                                MessageBox.Show("Invalid username or password. \n Please try again or check the lower or uppercase characters.");
                            }
                            else
                            {
                                Classes.Globals.user_control_id = Convert.ToInt32(dr["user_id"]);
                                return true;
                            }

                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password. Please try again.");
                        }
                        dr.Close();
                        conn.Close();

                    }
                }
            }
            return false;
        }

        private void FRM_SIGN_IN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.sign_in_action();
            }
        }

    }
}
