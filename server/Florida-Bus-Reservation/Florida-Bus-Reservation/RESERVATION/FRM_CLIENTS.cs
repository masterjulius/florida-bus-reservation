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
    public partial class FRM_CLIENTS : Form
    {
        // Variables
        private int Action = 1;
        private Form frmParent;
        private TextBox txtBoxParent;
        Classes.Connection Connection = new Classes.Connection();
        public FRM_CLIENTS(Form frm, TextBox txtBox)
        {
            InitializeComponent();
            this.frmParent = frm;
            this.txtBoxParent = txtBox;
        }

        private void FRM_CLIENTS_Load(object sender, EventArgs e)
        {
            this.init_all();
        }

        private void init_all()
        {
            this._load_clients_to_datagridview(this.dgv_clients);
        }

        // ----------------------------------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------------
        // action menus
        private void _set_action_buttons(string action = "default")
        {
            this.toolStripBtn_new.Enabled = false;
            this.toolStripBtn_edit.Enabled = false;
            this.toolStripBtn_delete.Enabled = false;
            this.toolStripBtn_accept.Enabled = false;
            this.toolStripBtn_view_all.Enabled = true;

            if (action == "new")
            {
                this.toolStripBtn_accept.Enabled = true;
            }
            else if (action == "edit")
            {
                this.toolStripBtn_accept.Enabled = true;
            }
            else if (action == "search")
            {
                this.toolStripBtn_edit.Enabled = true;
                this.toolStripBtn_delete.Enabled = true;
            }
            else
            {
                this.toolStripBtn_new.Enabled = true;
            }
        }

        // ----------------------------------------------------------------------------------------------------------------

        public void _load_clients_to_datagridview(DataGridView dgv)
        {
            using (MySqlConnection conn = new MySqlConnection(Connection.connStr))
            {
                string stmt = "select `client_id`, `client_first_name` as `FIRST NAME`, `client_middle_name` as `MIDDLE NAME`, `client_last_name` as `LAST NAME` from `tbl_clients` where `client_is_active`=1 order by `client_last_name` ASC";
                using (MySqlCommand cmd = new MySqlCommand(stmt, conn))
                {
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    DataTable dt = new DataTable();
                    conn.Open();
                    da.SelectCommand = cmd;
                    conn.Close();

                    da.Fill(dt);
                    dgv.DataSource = dt;

                    // hide some datagridview columns
                    Classes.Forms._hide_datagridview_column(this.dgv_clients, new string[] {"client_id"});
                }
            }
        }

        // delete data
        private Boolean _delete_data(int client_id)
        {
            using (MySqlConnection conn = new MySqlConnection(Connection.connStr))
            {
                string stmt = "UPDATE `tbl_clients` SET `client_is_active`=0 WHERE `client_id`=@client_id";
                using (MySqlCommand cmd = new MySqlCommand(stmt, conn))
                {
                    cmd.Parameters.Add("@client_id", MySqlDbType.Int32).Value = client_id;
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

        private void toolStripBtn_new_Click(object sender, EventArgs e)
        {
            FRM_ADD_EDIT_CLIENT frmAddEditClient = new FRM_ADD_EDIT_CLIENT(this);
            frmAddEditClient.ShowDialog(this);
        }

        private void FRM_CLIENTS_Activated(object sender, EventArgs e)
        {
            this._load_clients_to_datagridview(this.dgv_clients);
        }

        private void toolStripBtn_edit_Click(object sender, EventArgs e)
        {
            FRM_ADD_EDIT_CLIENT frmAddEditClient = new FRM_ADD_EDIT_CLIENT(this, Convert.ToInt32(this.dgv_clients.SelectedRows[0].Cells["client_id"].Value));
            frmAddEditClient.ShowDialog(this);
        }

        private void toolStripBtn_delete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to remove this client?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                if (this._delete_data(Convert.ToInt32(this.dgv_clients.SelectedRows[0].Cells["client_id"].Value)) == true)
                {
                    MessageBox.Show("Successfuly deleted client.", "Additional Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Refresh();
                }
            }
            
        }

        private void toolStripBtn_accept_Click(object sender, EventArgs e)
        {
            if (this.dgv_clients.SelectedRows.Count > 0)
            {
                this.txtBoxParent.Text = this.dgv_clients.SelectedRows[0].Cells["LAST NAME"].Value.ToString() + ", " + this.dgv_clients.SelectedRows[0].Cells["FIRST NAME"].Value.ToString() + ", " + this.dgv_clients.SelectedRows[0].Cells["MIDDLE NAME"].Value.ToString();
                this.txtBoxParent.Tag = this.dgv_clients.SelectedRows[0].Cells["client_id"].Value;
                this.Dispose();
            }
        }

        // -------------------------------------------------------------------------------------------------------------------

    }
}
