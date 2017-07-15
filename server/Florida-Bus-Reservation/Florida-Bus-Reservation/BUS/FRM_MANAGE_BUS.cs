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
    public partial class FRM_MANAGE_BUS : Form
    {
        // initialize local variables
        // actions
        // 1 = new
        // 2 = edit
        // 3 = delete
        // 4 = search
        private int action = 1;
        private int bus_id;
        public FRM_MANAGE_BUS()
        {
            InitializeComponent();
        }

        private void FRM_MANAGE_BUS_Load(object sender, EventArgs e)
        {
            this.init_all();
        }

        // -----------------------------------------------------------------------------------
        private void init_all()
        {
            this._set_action_buttons();
            this._clear_input_fields();
            this._action_panel(this.panel1, false);
            this._load_autocomplete(this.toolStripTxt_search);
        }

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
            this.txt_bus_number.Clear();
            this._load_bus_class_to_combobox(this.cb_buss_class);
            this.txt_plate_number.Clear();
        }

        // ---------------------------------------------------------------------------------------------------

        // Load search/autocomplete textbox
        private void _load_autocomplete(ToolStripTextBox txtbox) {
            Classes.Connection Connection = new Classes.Connection();
            // init textbox autocomplete properties
            this.toolStripTxt_search.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            using (MySqlConnection conn = new MySqlConnection(Connection.connStr))
            {
                string stmt = "select `bus_number` from `tbl_bus` where `bus_is_active`=1 order by CAST(`bus_number` as SIGNED INTEGER) ASC";
                using (MySqlCommand cmd = new MySqlCommand(stmt, conn))
                {
                    conn.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            collection.Add(dr["bus_number"].ToString());
                        }
                    }
                    dr.Close();
                    conn.Close();

                }
            }
            // finally add to the textbox collection
            txtbox.AutoCompleteCustomSource = collection;
        }

        // Load/Fill the combobox
        private void _load_bus_class_to_combobox(ComboBox cmb)
        {
            Classes.Connection Connection = new Classes.Connection();
            using (MySqlConnection conn = new MySqlConnection(Connection.connStr)) {

                string stmt = "select `class_id`, `class_name` from `tbl_bus_class` where `class_is_active`=1 order by `class_name` ASC";
                using (MySqlCommand cmd = new MySqlCommand(stmt, conn))
                {
                    Dictionary<int, string> listItems = new Dictionary<int, string>();
                    listItems.Add(0, "— Select Bus Class —");

                    conn.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            listItems.Add(Convert.ToInt32(dr["class_id"]), dr["class_name"].ToString());  
                        }
                    }
                    dr.Close();
                    conn.Close();

                    cmb.DisplayMember = "Value";
                    cmb.ValueMember = "Key";
                    cmb.DataSource = new BindingSource(listItems, null);

                }

            }
        }

        // -------------------------------------- SQL STATEMENTS -----------------------------------------------
        private Boolean _save_data(int bus_id = 0)
        {
            if (this._check_field_requirements() == true)
            {
                Classes.Connection Connection = new Classes.Connection();

                using (MySqlConnection conn = new MySqlConnection(Connection.connStr))
                {
                    string stmtInsert = "insert into `tbl_bus` (`bus_class_id`, `bus_number`, `bus_plate_number`, `bus_created_by`) values (@bus_class_id, @bus_number, @bus_plate_number, @bus_created_by)";
                    string stmtUpdate = "update `tbl_bus` set `bus_class_id`=@bus_class_id, `bus_number`=@bus_number, `bus_plate_number`=@bus_plate_number, `bus_edited_by`=@bus_edited_by where `bus_id`=@bus_id";
                    string stmt = bus_id != 0 ? stmtUpdate : stmtInsert;
                    using (MySqlCommand cmd = new MySqlCommand(stmt, conn))
                    {
                        cmd.Parameters.Add("@bus_class_id", MySqlDbType.VarChar).Value = this.cb_buss_class.SelectedValue;
                        cmd.Parameters.Add("@bus_number", MySqlDbType.VarChar).Value = this.txt_bus_number.Text;
                        cmd.Parameters.Add("@bus_plate_number", MySqlDbType.VarChar).Value = this.txt_plate_number.Text;
                        if (0 != bus_id)
                        {
                            cmd.Parameters.Add("@bus_edited_by", MySqlDbType.Int32).Value = Classes.Globals.user_control_id;
                            cmd.Parameters.Add("@bus_id", MySqlDbType.Int32).Value = bus_id;
                        }
                        else
                        {
                            cmd.Parameters.Add("@bus_created_by", MySqlDbType.Int32).Value = Classes.Globals.user_control_id;
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

        // delete data
        private Boolean _remove_data(int bus_id)
        {
            Classes.Connection Connection = new Classes.Connection();
            using (MySqlConnection conn = new MySqlConnection(Connection.connStr))
            {
                string stmt = "update `tbl_bus` set `bus_is_active`=0 where `bus_id`=@bus_id";
                using (MySqlCommand cmd = new MySqlCommand(stmt, conn))
                {
                    cmd.Parameters.Add("@bus_id", MySqlDbType.Int32).Value = bus_id;
                    conn.Open();
                    int affectedRows = Convert.ToInt32(cmd.ExecuteNonQuery());
                    conn.Close();

                    if (affectedRows > 0)
                    {
                        return true;
                    }
                }
            }
            return false;

        }

        // get the data via class name
        private object[] _get_bus_info(string bus_number)
        {
            Classes.Connection Connection = new Classes.Connection();
            using (MySqlConnection conn = new MySqlConnection(Connection.connStr))
            {
                string stmt = "select `bus_id`, `bus_class_id`, `bus_number`, `bus_plate_number` from `tbl_bus` where `bus_number`=@bus_number";
                using (MySqlCommand cmd = new MySqlCommand(stmt, conn))
                {
                    cmd.Parameters.Add("@bus_number", MySqlDbType.VarChar).Value = bus_number;
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    DataSet ds = new DataSet();
                    conn.Open();
                    da.SelectCommand = cmd;
                    conn.Close();

                    da.Fill(ds, "tbl_bus");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        DataRow row = ds.Tables[0].Rows[0];
                        object[] returnDatas = new object[6];
                        returnDatas[0] = row.ItemArray[0];
                        returnDatas[1] = row.ItemArray[1];
                        returnDatas[2] = row.ItemArray[2];
                        returnDatas[3] = row.ItemArray[3];

                        return returnDatas;

                    }
                }
            }
            return null;
        }

        private void _assign_datas_to_fields(object[] obj)
        {
            this.bus_id = Convert.ToInt32(obj[0]);
            this.cb_buss_class.SelectedValue = Convert.ToInt32(obj[1]);
            this.txt_bus_number.Text = obj[2].ToString();
            this.txt_plate_number.Text = obj[3].ToString();
        }

        // field filling up checker
        private Boolean _check_field_requirements()
        {
            if (!string.IsNullOrEmpty(this.txt_bus_number.Text) && !string.IsNullOrEmpty(this.txt_plate_number.Text) && Convert.ToInt32(this.cb_buss_class.SelectedValue) != 0)
            {
                return true;
            }
            return false;
        }

        // new
        private void toolStripBtn_new_Click(object sender, EventArgs e)
        {
            this.action = 1;
            this._set_action_buttons("new");
            this._action_panel(this.panel1);
            this._clear_input_fields();
        }

        // edit
        private void toolStripBtn_edit_Click(object sender, EventArgs e)
        {
            this.action = 2;
            this._set_action_buttons("edit");
            this._action_panel(this.panel1);
        }

        // enter on the search textbox
        private void toolStripTxt_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(this.toolStripTxt_search.Text))
                {
                    object[] objectDatas = this._get_bus_info(this.toolStripTxt_search.Text);
                    if (objectDatas != null)
                    {
                        this._assign_datas_to_fields(objectDatas);
                        this.action = 4; // search
                        this._set_action_buttons("search");
                        this._action_panel(this.panel1, false);
                    }
                }
            }
        }

        // delete
        private void toolStripBtn_delete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to delete this class?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                if (this._remove_data(this.bus_id) == true)
                {
                    MessageBox.Show("Successfully deleted bus class.", "Additional Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.init_all();
                }
            }
        }

        // sve trigger
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
                if (this._save_data(this.bus_id) == true)
                {
                    MessageBox.Show("Successfully update bus class", "Additional Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.init_all();
                }
            }
        }

        // trigger cancel
        private void toolStripBtn_cancel_Click(object sender, EventArgs e)
        {
            this.init_all();
        }

        private void toolStripBtn_view_all_Click(object sender, EventArgs e)
        {
            BUS.FRM_VIEW_ALL_BUS frmViewAllBus = new FRM_VIEW_ALL_BUS();
            frmViewAllBus.ShowDialog();
        }

        // use strict character encoding
        private void txt_bus_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            Classes.Forms._strict_char_encoding(e, 2);
        }



        // -----------------------------------------------------------------------------------------------------
    }
}
