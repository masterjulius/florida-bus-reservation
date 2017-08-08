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
            this.rdio_walk_in.Checked = true;
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

        // getting the datas
        private object[] _get_datas_by_id(int reservation_id)
        {
            using (MySqlConnection conn = new MySqlConnection(Connection.connStr))
            {
                string stmt = "SELECT `TBL_RESERVATIONS`.`RES_SCHED_ID`, `TBL_RESERVATIONS`.`RES_TYPE`, `TBL_RESERVATIONS`.`RES_CODE`, `TBL_RESERVATIONS`.`RES_BUS_CLASS_ID`, `TBL_RESERVATIONS`.`RES_BUS_ID`, `TBL_RESERVATIONS`.`RES_SEAT_NUMBERS`, `TBL_BUS_CLASS`.`CLASS_SEAT_PRICE` FROM `TBL_RESERVATIONS` LEFT JOIN `TBL_BUS_CLASS` ON `TBL_RESERVATIONS`.`RES_BUS_CLASS_ID`=`TBL_BUS_CLASS`.`CLASS_ID` WHERE `TBL_RESERVATIONS`.`RES_ID`=@RES_ID AND `TBL_RESERVATIONS`.`RES_IS_CANCELLED`=0 AND `TBL_RESERVATIONS`.`RES_IS_ACTIVE`=1";
                using (MySqlCommand cmd = new MySqlCommand(stmt, conn))
                {
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    DataSet ds = new DataSet();
                    cmd.Parameters.Add("@RES_ID", MySqlDbType.Int32).Value = reservation_id;
                    conn.Open();
                    da.SelectCommand = cmd;
                    conn.Close();

                    da.Fill(ds, "TBL_RESERVATIONS");
                    int rowCount = ds.Tables[0].Rows.Count;
                    if (rowCount > 0)
                    {
                        object[] obj = new object[7];
                        DataRow row = ds.Tables[0].Rows[0];
                        obj[0] = row["RES_SCHED_ID"];
                        obj[1] = row["RES_TYPE"];
                        obj[2] = row["RES_CODE"];
                        obj[3] = row["RES_BUS_CLASS_ID"];
                        obj[4] = row["RES_BUS_ID"];
                        obj[5] = row["RES_SEAT_NUMBERS"];
                        obj[6] = row["CLASS_SEAT_PRICE"];
                        return obj;
                    }

                    return null;

                }

            }
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
        private int? _save_data(int? reservation_id = null)
        {
            using (MySqlConnection conn = new MySqlConnection(Connection.connStr))
            {
                string stmtInsert = "INSERT INTO `tbl_reservations` (`res_sched_id`, `res_type`, `res_code`, `res_bus_class_id`, `res_bus_id`, `res_seat_numbers`, `res_client_id`) values(@res_sched_id, @res_type, CONCAT( 'GV-', DATE_FORMAT(current_timestamp(), '%y%m%d%h%m%s'), '-', CONCAT( FLOOR(RAND()*(9-0+1))+0, FLOOR(RAND()*(9-0+1))+0, FLOOR(RAND()*(9-0+1))+0) ), @res_bus_class_id, @res_bus_id, @res_seat_numbers, @res_client_id);select last_insert_id()";
                string stmtUpdate = "";
                string stmt = reservation_id != null ? stmtUpdate : stmtInsert;

                using (MySqlCommand cmd = new MySqlCommand(stmt, conn))
                {
                    cmd.Parameters.Add("@res_sched_id", MySqlDbType.Int32).Value = Convert.ToInt32(this.txt_schedule.Tag);
                    cmd.Parameters.Add("@res_type", MySqlDbType.Bit).Value = reservation_type;
                    cmd.Parameters.Add("@res_bus_class_id", MySqlDbType.Int32).Value = Convert.ToInt32(this.txt_bus_class.Tag);
                    cmd.Parameters.Add("@res_bus_id", MySqlDbType.Int32).Value = Convert.ToInt32(this.txt_bus_number.Tag);
                    cmd.Parameters.Add("@res_seat_numbers", MySqlDbType.VarChar).Value = this.txt_seat_numbers.Text;
                    cmd.Parameters.Add("@res_client_id", MySqlDbType.Int32).Value = Convert.ToInt32(this.txt_passenger_name.Tag);

                    if (reservation_id != null)
                    {
                        cmd.Parameters.Add("@res_id", MySqlDbType.Int32).Value = reservation_id;
                    }

                    conn.Open();
                    int last_id = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();

                    if (last_id != 0)
                    {
                        return last_id;
                    }
                    return null;

                }
            }
        }

        //

        // save to transactions
        private Boolean _save_to_transactions(int last_id)
        {
            using (MySqlConnection conn = new MySqlConnection(Connection.connStr))
            {
                string stmt = "INSERT INTO `TBL_TRANSACTIONS` (`TRANS_RESERVATION_ID`, `TRANS_TOTAL_PAYMENT`) VALUES (@TRANS_RESERVATION_ID, @TRANS_TOTAL_PAYMENT)";
                using (MySqlCommand cmd = new MySqlCommand(stmt, conn))
                {
                    cmd.Parameters.Add("@TRANS_RESERVATION_ID", MySqlDbType.Int32).Value = last_id;
                    
                    // Compute for the total payment
                    string seats = this.txt_seat_numbers.Text;
                    string[] splittedChars = seats.Split(':');

                    // get the seat price
                    object[] obj = this._get_datas_by_id(last_id);
                    double seatPrice = Convert.ToDouble(obj[6]);
                    double totalPrice = 0;
                    //MessageBox.Show("Seat Price is: " + seatPrice.ToString());

                    for (int i = 0; i < splittedChars.Length; i++)
                    {
                        totalPrice += seatPrice;
                    }
                    //MessageBox.Show("Total is: " + totalPrice.ToString());

                    cmd.Parameters.Add("@TRANS_TOTAL_PAYMENT", MySqlDbType.Double).Value = totalPrice;
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
            FRM_CLIENTS frmClients = new FRM_CLIENTS(this, this.txt_passenger_name, this.txt_passenger_contact, this.txt_passenger_address);
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

        private void btn_bus_class_Click(object sender, EventArgs e)
        {
            BUS.FRM_VIEW_ALL_BUS_CLASS frmViewClasses = new BUS.FRM_VIEW_ALL_BUS_CLASS(this, this.txt_bus_class);
            frmViewClasses.ShowDialog(this);
        }

        private void btn_bus_number_Click(object sender, EventArgs e)
        {
            FRM_BUSSES_AVAILABLE frmBusesAvailable = new FRM_BUSSES_AVAILABLE(this, this.txt_bus_number, Convert.ToInt32(this.txt_bus_class.Tag));
            frmBusesAvailable.ShowDialog(this);
        }

        private void rdio_walk_in_CheckedChanged(object sender, EventArgs e)
        {
            this.reservation_type = true;
        }

        private void rdio_online_CheckedChanged(object sender, EventArgs e)
        {
            this.reservation_type = false;
        }

        private void toolStripBtn_save_Click(object sender, EventArgs e)
        {
            if (this.action == 1)
            {
                int? reservation_last_id = this._save_data();
                if (reservation_last_id != null)
                {
                    if (this._save_to_transactions(Convert.ToInt32(reservation_last_id)) == true)
                    {
                        MessageBox.Show("Successsfully added reservation", "Additional Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this._clear_input_fields();
                    }
                }
            }
            else if (this.action == 2)
            {

            }
        }

    }
}
