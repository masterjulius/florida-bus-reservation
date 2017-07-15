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

namespace Florida_Bus_Reservation.RESERVATION
{
    public partial class FRM_ADD_EDIT_CLIENT : Form
    {
        // Variables
        private Form frmParent;
        private int? frm_client_id = null;
        Classes.Connection Connection = new Classes.Connection();
        public FRM_ADD_EDIT_CLIENT(Form frm, int? client_id = null)
        {
            InitializeComponent();
            this.frmParent = frm;
            this.frm_client_id = client_id;
        }

        private void FRM_ADD_EDIT_CLIENT_Load(object sender, EventArgs e)
        {
            this.init_all();
        }

        private void init_all()
        {
            if (this.frm_client_id != null)
            {
                // get datas
                this._assign_data_to_fields(this._get_datas(this.frm_client_id));
            }
        }

        //

        private void _clear_entries()
        {
            this.txt_first_name.Clear();
            this.txt_middle_name.Clear();
            this.txt_last_name.Clear();
            this.txt_contact.Clear();
            this.txt_address.Clear();
        }

        // asigning fetched datas to fields
        private void _assign_data_to_fields(object[] obj)
        {
            if (obj != null)
            {
                this.txt_first_name.Text = obj[0].ToString();
                this.txt_middle_name.Text = obj[1].ToString();
                this.txt_last_name.Text = obj[2].ToString();
                this.txt_contact.Text = obj[3].ToString();
                this.txt_address.Text = obj[4].ToString();
            }
        }

        // ---------------------------------------------------------------------------------------------------------------------
        // SQL Block
        // get datas
        private object[] _get_datas(int? client_id)
        {
            using (MySqlConnection conn = new MySqlConnection(Connection.connStr))
            {
                string stmt = "SELECT `client_first_name`, `client_middle_name`, `client_last_name`, `client_contact`, `client_address` FROM `tbl_clients` WHERE `client_id`=@client_id AND `client_is_active`=1";
                using (MySqlCommand cmd = new MySqlCommand(stmt, conn))
                {
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    DataSet ds = new DataSet();

                    cmd.Parameters.Add("@client_id", MySqlDbType.Int32).Value = client_id;
                    conn.Open();
                    da.SelectCommand = cmd;
                    conn.Close();

                    da.Fill(ds, "tbl_clients");

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        object[] obj = new object[5];
                        DataRow row = ds.Tables[0].Rows[0];
                        obj[0] = row["client_first_name"];
                        obj[1] = row["client_middle_name"];
                        obj[2] = row["client_last_name"];
                        obj[3] = row["client_contact"];
                        obj[4] = row["client_address"];

                        return obj;
                    }
                    return null;

                }
            }
        }

        // save data
        private Boolean _save_client(int? client_id = null) {
            using (MySqlConnection conn = new MySqlConnection(Connection.connStr))
            {
                string stmtAdd = "INSERT INTO `tbl_clients` (`client_first_name`, `client_middle_name`, `client_last_name`, `client_contact`, `client_address`) VALUES (@client_first_name, @client_middle_name, @client_last_name, @client_contact, @client_address)";
                string stmtUpdate = "UPDATE `tbl_clients` SET `client_first_name`=@client_first_name, `client_middle_name`=@client_middle_name, `client_last_name`=@client_last_name, `client_contact`=@client_contact, `client_address`=@client_address WHERE `client_id`=@client_id AND `client_is_active`=1";
                string stmt = client_id != null ? stmtUpdate : stmtAdd;
                using (MySqlCommand cmd = new MySqlCommand(stmt,conn)) {
                    cmd.Parameters.Add("@client_first_name", MySqlDbType.VarChar).Value = this.txt_first_name.Text;
                    cmd.Parameters.Add("@client_middle_name", MySqlDbType.VarChar).Value = this.txt_middle_name.Text;
                    cmd.Parameters.Add("@client_last_name", MySqlDbType.VarChar).Value = this.txt_last_name.Text;
                    cmd.Parameters.Add("@client_contact", MySqlDbType.VarChar).Value = this.txt_contact.Text;
                    cmd.Parameters.Add("@client_address", MySqlDbType.VarChar).Value = this.txt_address.Text;
                    if (client_id != null)
                    {
                        cmd.Parameters.Add("@client_id", MySqlDbType.Int32).Value = client_id;
                    }
                    conn.Open();
                    int affectedRows = Convert.ToInt32(cmd.ExecuteNonQuery());
                    conn.Close();
                    if (affectedRows > 0)
                    {
                        return true;
                    }

                    return false;
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (this.frm_client_id != null)
            {
                if (this._save_client(this.frm_client_id) == true)
                {
                    MessageBox.Show("Successfully updated client.", "Additional Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.frmParent.Refresh();
                }
            }
            else
            {
                if (this._save_client() == true)
                {
                    MessageBox.Show("Successfully added new client.", "Additional Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this._clear_entries();
                    this.frmParent.Refresh();
                }
            }
        }

    }
}
