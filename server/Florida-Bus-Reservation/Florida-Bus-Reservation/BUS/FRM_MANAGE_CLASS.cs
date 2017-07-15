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

namespace Florida_Bus_Reservation.BUS
{
    public partial class FRM_MANAGE_CLASS : Form
    {

        // Variables
        private Boolean has_aircon = true;
        // actions
        // 1 = new
        // 2 = edit
        // 3 = delete
        // 4 = search
        private int action = 1;
        private int bus_class_id;

        public FRM_MANAGE_CLASS()
        {
            InitializeComponent();
        }

        private void FRM_MANAGE_CLASS_Load(object sender, EventArgs e)
        {
            this.init_all();
        }

        private void init_all()
        {
            this._set_action_buttons();
            this._clear_input_fields();
            this._action_panel(this.panel1, false);
            this._load_autocomplete(this.toolStripTxt_search);
        }

        // populate datas to the toolstriptextbox
        private void _load_autocomplete(ToolStripTextBox txtbox)
        {
            Classes.Connection Connection = new Classes.Connection();
            // init textbox autocomplete properties
            this.toolStripTxt_search.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            using (MySqlConnection conn = new MySqlConnection(Connection.connStr))
            {
                string stmt = "select `class_name` from `tbl_bus_class` where `class_is_active`=1 order by `class_name` ASC";
                using (MySqlCommand cmd = new MySqlCommand(stmt, conn))
                {
                    conn.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            collection.Add(dr["class_name"].ToString());
                        }
                    }
                    dr.Close();
                    conn.Close();

                }
            }
            // finally add to the textbox collection
            txtbox.AutoCompleteCustomSource = collection;
        }
        /**/

        // -----------------------------------------------------------------------------------------------
        // action menus
        private void _set_action_buttons(string action = "default")
        {
            this.toolStripBtn_new.Enabled = false;
            this.toolStripBtn_edit.Enabled = false;
            this.toolStripBtn_delete.Enabled = false;
            this.toolStripBtn_save.Enabled = false;
            this.toolStripBtn_cancel.Enabled = false;
            this.toolStripBtn_view_all.Enabled = true;

            if (action == "new")
            {
                this.toolStripBtn_save.Enabled = true;
                this.toolStripBtn_cancel.Enabled = true;
            }
            else if (action == "edit")
            {
                this.toolStripBtn_save.Enabled = true;
                this.toolStripBtn_cancel.Enabled = true;
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

        private void _action_panel(Panel panel, Boolean enabled = true)
        {
            if (enabled == true)
            {
                panel.Enabled = true;
            }
            else
            {
                panel.Enabled = false;
            }
        }

        // clearing all the input fields
        private void _clear_input_fields()
        {
            this.txt_class_name.Clear();
            this.txt_number_of_seats.Clear();
            this.rdioYES.Enabled = true;
            this.txt_remarks.Clear();
        }

        private Boolean _check_field_requirements()
        {
            if (!string.IsNullOrEmpty(this.txt_class_name.Text) && !string.IsNullOrEmpty(this.txt_number_of_seats.Text))
            {
                return true;
            }
            return false;
        }

        private void _assign_datas_to_fields(object[] obj)
        {
            this.bus_class_id = Convert.ToInt32(obj[0]);
            this.txt_class_name.Text = obj[1].ToString();
            this.txt_number_of_seats.Text = obj[2].ToString();
            this.has_aircon = Convert.ToBoolean(obj[3]);
            if (Convert.ToBoolean(obj[3]) == true)
            {
                rdioYES.Checked = true;
            }
            else
            {
                rdioNO.Checked = true;
            }
            this.txt_remarks.Text = obj[4].ToString();
        }

        // -----------------------------------------------------------------------------------------------
        // get the data via class name
        private object[] _get_class_info(string class_name)
        {
            Classes.Connection Connection = new Classes.Connection();
            using (MySqlConnection conn = new MySqlConnection(Connection.connStr))
            {
                string stmt = "select `class_id`, `class_name`, `class_seat_count`, `class_has_aircon`, `class_remarks`, `class_edited_date` from `tbl_bus_class` where `class_name`=@class_name and `class_is_active`=1";
                using (MySqlCommand cmd = new MySqlCommand(stmt, conn))
                {
                    cmd.Parameters.Add("@class_name", MySqlDbType.VarChar).Value = class_name;
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    DataSet ds = new DataSet();
                    conn.Open();
                    da.SelectCommand = cmd;
                    conn.Close();

                    da.Fill(ds, "tbl_bus_class");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        DataRow row = ds.Tables[0].Rows[0];
                        object[] returnDatas = new object[6];
                        returnDatas[0] = row.ItemArray[0];
                        returnDatas[1] = row.ItemArray[1];
                        returnDatas[2] = row.ItemArray[2];
                        returnDatas[3] = row.ItemArray[3];
                        returnDatas[4] = row.ItemArray[4];
                        returnDatas[5] = row.ItemArray[5];

                        return returnDatas;

                    }
                    return null;

                }
            }
        }

        private Boolean _save_data(int class_id = 0)
        {
            if (this._check_field_requirements() == true)
            {
                Classes.Connection Connection = new Classes.Connection();

                using (MySqlConnection conn = new MySqlConnection(Connection.connStr))
                {
                    string stmtInsert = "insert into `tbl_bus_class` (`class_name`, `class_seat_count`, `class_has_aircon`, `class_remarks`, `class_created_by`) values (@class_name, @class_seat_count, @class_has_aircon, @class_remarks, @class_created_by)";
                    string stmtUpdate = "update `tbl_bus_class` set `class_name`=@class_name, `class_seat_count`=@class_seat_count, `class_has_aircon`=@class_has_aircon, `class_remarks`=@class_remarks, `class_edited_by`=@class_edited_by where `class_id`=@class_id";
                    string stmt = class_id != 0 ? stmtUpdate : stmtInsert;
                    using (MySqlCommand cmd = new MySqlCommand(stmt, conn))
                    {
                        cmd.Parameters.Add("@class_name", MySqlDbType.VarChar).Value = this.txt_class_name.Text;
                        cmd.Parameters.Add("@class_seat_count", MySqlDbType.Int32).Value = this.txt_number_of_seats.Text;
                        cmd.Parameters.Add("@class_has_aircon", MySqlDbType.Bit).Value = this.has_aircon;
                        cmd.Parameters.Add("@class_remarks", MySqlDbType.Text).Value = this.txt_remarks.Text;
                        if (0 != class_id)
                        {
                            cmd.Parameters.Add("@class_edited_by", MySqlDbType.Int32).Value = Classes.Globals.user_control_id;
                            cmd.Parameters.Add("@class_id", MySqlDbType.Int32).Value = class_id;
                        }
                        else
                        {
                            cmd.Parameters.Add("@class_created_by", MySqlDbType.Int32).Value = Classes.Globals.user_control_id;
                        }
                        conn.Open();
                        int affectedRows = Convert.ToInt32(cmd.ExecuteNonQuery());
                        conn.Close();
                        if (affectedRows > 0)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        // remove data
        private Boolean _remove_data(int class_id)
        {
            Classes.Connection Connection = new Classes.Connection();
            using (MySqlConnection conn = new MySqlConnection(Connection.connStr))
            {
                string stmt = "update `tbl_bus_class` set `class_is_active`=0, `class_edited_by`=@class_edited_by where `class_id`=@class_id";
                using (MySqlCommand cmd = new MySqlCommand(stmt, conn))
                {
                    cmd.Parameters.Add("@class_edited_by", MySqlDbType.Int32).Value = Classes.Globals.user_control_id;
                    cmd.Parameters.Add("@class_id", MySqlDbType.Int32).Value = class_id;
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

        // full extraction of data method
        public void _full_data_extraction(object[] objectDatas)
        {
            if (objectDatas != null)
            {
                this._assign_datas_to_fields(objectDatas);
                this.action = 4; // search
                this._set_action_buttons("search");
                this._action_panel(this.panel1, false);
            }
        }

        private void toolStripBtn_new_Click_1(object sender, EventArgs e)
        {
            this.action = 1;
            this._set_action_buttons("new");
            this._action_panel(this.panel1);
            this._clear_input_fields();
        }

        private void toolStripBtn_edit_Click_1(object sender, EventArgs e)
        {
            this.action = 2;
            this._set_action_buttons("edit");
            this._action_panel(this.panel1);
        }

        private void toolStripTxt_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                if (!string.IsNullOrEmpty(this.toolStripTxt_search.Text))
                {
                    object[] objectDatas = this._get_class_info(this.toolStripTxt_search.Text);
                    this._full_data_extraction(objectDatas);
                }
            }
        }

        private void toolStripBtn_delete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to delete this class?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                if (this._remove_data(this.bus_class_id) == true)
                {
                    MessageBox.Show("Successfully deleted bus class.", "Additional Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.init_all();
                }
            }
        }

        // save trigger
        private void toolStripBtn_save_Click(object sender, EventArgs e)
        {
            if (this.action == 1)
            {
                if (this._save_data() == true)
                {
                    MessageBox.Show("Successfully added new bus class", "Additional Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.init_all();
                }
            }
            else if (this.action == 2)
            {
                if (this._save_data(this.bus_class_id) == true)
                {
                    MessageBox.Show("Successfully update bus class", "Additional Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.init_all();
                }
            }
        }

        private void toolStripBtn_cancel_Click(object sender, EventArgs e)
        {
            this.init_all();
        }

        private void toolStripBtn_view_all_Click(object sender, EventArgs e)
        {
            FRM_VIEW_ALL_BUS_CLASS frmViewAll = new FRM_VIEW_ALL_BUS_CLASS(this);
            frmViewAll.ShowDialog(this);
        }

        // -----------------------------------------------------------------------------------------------
    }
}
