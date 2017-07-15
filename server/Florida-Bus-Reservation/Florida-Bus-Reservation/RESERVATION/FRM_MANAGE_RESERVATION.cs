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
    public partial class FRM_MANAGE_RESERVATION : Form
    {
        // initialize local variables
        /** Actions
         * 1 = Add
         * 2 = Edit
         * 3 = Delete
         */
        private int action = 1;
        private Form frmParent;
        private Boolean reservation_type = true;

        // database config variables
        Classes.Connection Connection = new Classes.Connection();

        public FRM_MANAGE_RESERVATION(Form frm)
        {
            InitializeComponent();
            this.frmParent = frm;
        }

        private void FRM_MANAGE_RESERVATION_Load(object sender, EventArgs e)
        {
            this.init_all();
        }

        private void init_all()
        {
            this._set_action_buttons();
            this._clear_input_fields();
            this._action_panel(this.panel_main, false);
            //this._load_autocomplete(this.toolStripTxt_search);
        }

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
            this.txt_bus_class.Clear();
            this.txt_bus_number.Clear();
            this.txt_seat_numbers.Clear();
            this.txt_passenger_name.Clear();
            this.txt_passenger_address.Clear();
            this.txt_passenger_contact.Clear();
        }

        // ---------------------------------------- SQL BLOCK -----------------------------------------------------------
        // saving the data

        /**
         * !
         * !
         * !
         * Update the adding of data later on. There should be no duplications
         * !
         * !
         * !
         */ 
        private Boolean _save_data(int? reservation_id = null)
        {
            using (MySqlConnection conn = new MySqlConnection(Connection.connStr))
            {
                string stmtInsert = "INSERT INTO `tbl_reservations` (`res_sched_id`, `res_type`, `res_code`, `res_bus_class_id`, `res_bus_id`, `res_seat_numbers`, `res_client_id`) values(@res_sched_id, @res_type, @res_code, @res_bus_class_id, @res_bus_id, @res_seat_numbers, @res_client_id)";
                string stmtUpdate = "";
                string stmt = reservation_id != null ? stmtUpdate : stmtInsert;

                string reservation_code = "CONCAT( 'GV', DATE_FORMAT(current_timestamp(), '%y%m%d%h%m%s'), CONCAT( FLOOR(RAND()*(9-0+1))+0, FLOOR(RAND()*(9-0+1))+0, FLOOR(RAND()*(9-0+1))+0) )";
                using (MySqlCommand cmd = new MySqlCommand(stmt, conn))
                {
                    cmd.Parameters.Add("@res_sched_id", MySqlDbType.Int32).Value = Convert.ToInt32(this.txt_schedule.Tag);
                    cmd.Parameters.Add("@res_type", MySqlDbType.Binary).Value = reservation_type;
                    cmd.Parameters.Add("@res_code", MySqlDbType.VarChar).Value = reservation_code;
                    cmd.Parameters.Add("@res_bus_class_id", MySqlDbType.Int32).Value = Convert.ToInt32(this.txt_bus_class.Tag);
                    cmd.Parameters.Add("@res_bus_id", MySqlDbType.Int32).Value = Convert.ToInt32(this.txt_bus_number.Tag);
                    cmd.Parameters.Add("@res_seat_numbers", MySqlDbType.VarChar).Value = this.txt_seat_numbers.Text;
                    cmd.Parameters.Add("@res_client_id", MySqlDbType.Int32).Value = Convert.ToInt32(this.txt_passenger_name.Tag);

                    if (reservation_id != null)
                    {
                        cmd.Parameters.Add("@res_id", MySqlDbType.Int32).Value = reservation_id;
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

        private void btn_passenger_info_Click(object sender, EventArgs e)
        {
            FRM_CLIENTS frmClients = new FRM_CLIENTS(this, this.txt_passenger_name);
            frmClients.ShowDialog(this);

        }

        private void btn_schedule_Click(object sender, EventArgs e)
        {
            FRM_CURRENT_SCHEDULES frmCurrentSchedules = new FRM_CURRENT_SCHEDULES(this, this.txt_schedule);
            frmCurrentSchedules.ShowDialog(this);
        }

        private void toolStripBtn_new_Click(object sender, EventArgs e)
        {
            this.action = 1;
            this._set_action_buttons("new");
            this._action_panel(this.panel_main);
            this._clear_input_fields();
        }

    }
}
