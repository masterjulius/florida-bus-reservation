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

namespace Florida_Bus_Reservation.SCHEDULES
{
    public partial class FRM_ADD_EDIT_SCHEDULES : Form
    {
        // initialize variables here
        // 1 = add
        // 2 = edit
        private int action = 1;
        Form bus_frm_parent;
        private int bus_schedule_id;

        public FRM_ADD_EDIT_SCHEDULES(Form frmParent, int schedule_id = 0)
        {
            InitializeComponent();
            this.bus_frm_parent = frmParent;
            this.bus_schedule_id = schedule_id;
        }

        private void FRM_ADD_EDIT_SCHEDULES_Load(object sender, EventArgs e)
        {
            this.init_all();
        }

        // initialize all
        private void init_all()
        {
            this._load_bus_numbers_to_combobox(cb_bus_number);
            this._manage_allowed_dates(this.dtp_sched);
            this.chk_auto_departure.Checked = true;

            if (this.bus_schedule_id != 0)
            {
                action = 2;
                object[] obj = this._get_datas(this.bus_schedule_id);
                if (obj != null)
                {
                    this._assign_datas_to_fields(obj);
                }
            }

        }

        // get datas
        private object[] _get_datas(int sched_id)
        {
            Classes.Connection Connection = new Classes.Connection();
            using (MySqlConnection conn = new MySqlConnection(Connection.connStr))
            {
                string stmt = "select `sched_bus_id`, DATE_FORMAT(`sched_date`, '%c/%d/%Y') as `sched_date`, DATE_FORMAT(`sched_departure_time`, '%h:%i:%s %p') as `sched_departure_time`, `sched_name`, `sched_description`, `sched_auto_departure` from `tbl_schedules` where `sched_id`=@sched_id and `sched_is_active`=1";
                using (MySqlCommand cmd = new MySqlCommand(stmt, conn))
                {
                    cmd.Parameters.Add("@sched_id", MySqlDbType.Int32).Value = sched_id;
                    conn.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        object[] returnDatas = new object[6];
                        while (dr.Read())
                        {
                            returnDatas[0] = dr["sched_bus_id"];
                            returnDatas[1] = dr["sched_date"];
                            returnDatas[2] = dr["sched_departure_time"];
                            returnDatas[3] = dr["sched_name"];
                            returnDatas[4] = dr["sched_description"];
                            returnDatas[5] = dr["sched_auto_departure"];
                        }
                        return returnDatas;
                    }
                    dr.Close();
                    conn.Close();
                }
            }
            return null;
        }

        // assign datas to fields
        private void _assign_datas_to_fields(object[] obj)
        {
            this.cb_bus_number.SelectedValue = Convert.ToInt32(obj[0]);
            this.dtp_sched.Value = Convert.ToDateTime(obj[1]);
            this.dtp_departure_time.Value = Convert.ToDateTime(obj[2]);
            this.txt_sched_name.Text = obj[3].ToString();
            this.txt_description.Text = obj[4].ToString();
            this.chk_auto_departure.Checked = Convert.ToBoolean(obj[5]);
        }

        private void _load_bus_numbers_to_combobox(ComboBox cmb)
        {
            Classes.Connection Connection = new Classes.Connection();
            using (MySqlConnection conn = new MySqlConnection(Connection.connStr))
            {
                string stmt = "select `tbl_bus`.`bus_id`, `tbl_bus`.`bus_number` from `tbl_bus` where `tbl_bus`.`bus_is_active`=1 and `tbl_bus`.`bus_id` not in (select `tbl_schedules`.`sched_bus_id` from `tbl_schedules` where `tbl_schedules`.`sched_is_active`=1 and TIMESTAMP(`tbl_schedules`.`sched_date`, `tbl_schedules`.`sched_departure_time`)>=CURRENT_TIMESTAMP()) order by CAST(`bus_number` as SIGNED INTEGER) ASC";
                using (MySqlCommand cmd = new MySqlCommand(stmt, conn))
                {
                    Dictionary<int, string> listItems = new Dictionary<int, string>();
                    listItems.Add(0, "— Select Bus Number —");
                    conn.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            listItems.Add(Convert.ToInt32(dr["bus_id"]), dr["bus_number"].ToString());
                        }
                    }
                    else
                    {
                        this.cb_bus_number.Enabled = false;
                        this.btn_save.Enabled = false;
                    }
                    dr.Close();
                    conn.Close();

                    // finalize the dictionary
                    cmb.DisplayMember = "Value";
                    cmb.ValueMember = "Key";
                    cmb.DataSource = new BindingSource(listItems, null);

                }
            }
        }

        // saving the bus schedule
        private Boolean _save_bus_schedule(int schedule_id = 0)
        {
            Classes.Connection Connection = new Classes.Connection();
            using (MySqlConnection conn = new MySqlConnection(Connection.connStr))
            {
                string stmtAdd = "insert into `tbl_schedules` (`sched_bus_id`, `sched_date`, `sched_departure_time`, `sched_name`, `sched_description`, `sched_created_by`, `sched_auto_departure`) values (@sched_bus_id, @sched_date, @sched_departure_time, @sched_name, @sched_description, @sched_created_by, @sched_auto_departure)";

                string stmtUpdate = "update `tbl_schedules` set `sched_bus_id`=@sched_bus_id, `sched_date`=@sched_date, `sched_departure_time`=@sched_departure_time, `sched_name`=@sched_name, `sched_description`=@sched_description, `sched_auto_departure`=@sched_auto_departure, `sched_edited_by`=@sched_edited_by where `sched_id`=@sched_id and `sched_is_active`=1";

                string stmt = schedule_id != 0 ? stmtUpdate : stmtAdd;
                using (MySqlCommand cmd = new MySqlCommand(stmt, conn))
                {
                    cmd.Parameters.Add("@sched_bus_id", MySqlDbType.Int32).Value = this.cb_bus_number.SelectedValue;
                    cmd.Parameters.Add("@sched_date", MySqlDbType.DateTime).Value = this.dtp_sched.Value;
                    cmd.Parameters.Add("@sched_departure_time", MySqlDbType.DateTime).Value = this.dtp_departure_time.Value;
                    cmd.Parameters.Add("@sched_name", MySqlDbType.Text).Value = this.txt_sched_name.Text;
                    cmd.Parameters.Add("@sched_description", MySqlDbType.Text).Value = this.txt_description.Text;
                    cmd.Parameters.Add("@sched_auto_departure", MySqlDbType.Bit).Value = this.chk_auto_departure.Checked;

                    if (0 != schedule_id)
                    {
                        cmd.Parameters.Add("@sched_edited_by", MySqlDbType.Int32).Value = Classes.Globals.user_control_id;
                        cmd.Parameters.Add("@sched_id", MySqlDbType.Int32).Value = schedule_id;
                    }
                    else
                    {
                        cmd.Parameters.Add("@sched_created_by", MySqlDbType.Int32).Value = Classes.Globals.user_control_id;
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
            return false;
        }

        // clear data entries
        private void _clear_entries()
        {
            DateTime dtime = DateTime.Now;
            this.cb_bus_number.SelectedValue = 0;
            this.dtp_sched.Value = Convert.ToDateTime(dtime.ToString("M/d/yyyy"));
            this.dtp_departure_time.Value = Convert.ToDateTime(dtime.ToString("h:mm:ss tt"));
            this.txt_sched_name.Clear();
            this.txt_description.Clear();
            this.chk_auto_departure.Checked = true;
        }

        // managing min and max dates
        private void _manage_allowed_dates(DateTimePicker dtp)
        {
            DateTime currDate = DateTime.Now;
            dtp.MinDate = Convert.ToDateTime(currDate.AddDays(-3).ToString("M/d/yyyy"));
            dtp.MaxDate = Convert.ToDateTime(currDate.AddDays(3).ToString("M/d/yyyy"));
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (this.action == 1)
            {
                if (this._save_bus_schedule() == true)
                {
                    MessageBox.Show("Successfully added bus schedule.", "Additional Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this._clear_entries();
                }
            }
            else
            {
                if (this._save_bus_schedule(this.bus_schedule_id) == true)
                {
                    MessageBox.Show("Successfully updated bus schedule.", "Additional Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.bus_frm_parent.Refresh();
                }
            }
        }

        // ----------------------------------------------------------------------------------------
    }
}
