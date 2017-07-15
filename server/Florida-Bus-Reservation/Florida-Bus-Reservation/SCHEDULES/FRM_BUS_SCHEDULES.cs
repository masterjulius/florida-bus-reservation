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
    public partial class FRM_BUS_SCHEDULES : Form
    {
        public FRM_BUS_SCHEDULES()
        {
            InitializeComponent();
        }

        private void FRM_BUS_SCHEDULES_Load(object sender, EventArgs e)
        {
            this.init_all();
        }

        private void init_all()
        {
            this._init_legend_colors();
            this._load_schedules_to_datagridview(this.dgv_schedules, dtp_sched.Value.ToString("M/dd/yyyy"));
            this._manage_allowed_dates(this.dtp_sched);
            t1.Start();
        }

        // initialize colors
        private void _init_legend_colors()
        {
            this.panel_available.BackColor = Color.FromArgb(233, 30, 99);
            this.panel_departed.BackColor = Color.FromArgb(0, 150, 136);
            // datagridview selection color
            this.dgv_schedules.DefaultCellStyle.SelectionBackColor = Color.FromArgb(38, 50, 56);
        }

        // SQL Methods
        private void _load_schedules_to_datagridview(DataGridView dgv, string selectedDate)
        {
            Classes.Connection Connection = new Classes.Connection();
            using (MySqlConnection conn = new MySqlConnection(Connection.connStr))
            {
                string stmt = "select `tbl_schedules`.`sched_id`, `tbl_bus`.`bus_number` as `BUS NUMBER`, DATE_FORMAT(`tbl_schedules`.`sched_departure_time`, '%h:%i:%s %p') as `DEPARTURE TIME` from `tbl_schedules` left join `tbl_bus` on `tbl_schedules`.`sched_bus_id`=`tbl_bus`.`bus_id` where DATE_FORMAT(`sched_date`, '%c/%d/%Y')=@sched_date and `sched_is_active`=1 order by `sched_departure_time` ASC";

                using (MySqlCommand cmd = new MySqlCommand(stmt, conn))
                {
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    DataTable dt = new DataTable();
                    cmd.Parameters.Add("@sched_date", MySqlDbType.VarChar).Value = selectedDate;
                    conn.Open();
                    da.SelectCommand = cmd;
                    conn.Close();

                    da.Fill(dt);
                    dgv.DataSource = dt;

                    // hide datagridview columns
                    Classes.Forms._hide_datagridview_column(this.dgv_schedules, new string[] { "sched_id" });

                    // call the format dgv method
                    this._format_datagridview(this.dgv_schedules);

                }
            }
        }

        // remove data
        private Boolean _remove_data(int sched_id)
        {
            Classes.Connection Connection = new Classes.Connection();
            using (MySqlConnection conn = new MySqlConnection(Connection.connStr))
            {
                string stmt = "update `tbl_schedules` set `sched_is_active`=0 where `sched_id`=@sched_id";
                using (MySqlCommand cmd = new MySqlCommand(stmt,conn))
                {
                    cmd.Parameters.Add("@sched_id", MySqlDbType.Int32).Value = sched_id;
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

        // generate datagridview shedules view
        // create headers
        private void _create_column_headers(DataGridView dgv, string[] columnHeaders)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            dgv.ColumnCount = columnHeaders.Length;

            for (int i = 0; i < columnHeaders.Length; i++)
            {
                dgv.Columns[i].HeaderText = columnHeaders[i];
            }

        }

        // format the datagridview
        private void _format_datagridview(DataGridView dgv)
        {
            dgv.DefaultCellStyle.BackColor = Color.FromArgb(233, 30, 99);
            dgv.DefaultCellStyle.ForeColor = Color.White;
            for (int i = 0; i < dgv.RowCount; i++)
            {
                DateTime dtime = DateTime.Now;
                string currTime = dtime.ToString("h:mm:ss tt"), dgvCellTime = dgv.Rows[i].Cells["DEPARTURE TIME"].Value.ToString();
                double diff = (Convert.ToDateTime(dgvCellTime) - Convert.ToDateTime(currTime)).TotalMinutes;
                
                if (diff <= 0)
                {
                    dgv.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(0, 150, 136);
                }

            }
        }

        // managing min and max dates
        private void _manage_allowed_dates(DateTimePicker dtp)
        {
            DateTime currDate = DateTime.Now;
            dtp.MinDate = Convert.ToDateTime(currDate.AddDays(-3).ToString("M/d/yyyy"));
            dtp.MaxDate = Convert.ToDateTime(currDate.AddDays(3).ToString("M/d/yyyy"));
        }

        private void toolStripBtn_new_Click(object sender, EventArgs e)
        {
            SCHEDULES.FRM_ADD_EDIT_SCHEDULES frmAddEditSchedues = new FRM_ADD_EDIT_SCHEDULES(this);
            frmAddEditSchedues.ShowDialog();
        }

        private void t1_Tick(object sender, EventArgs e)
        {
            this._load_schedules_to_datagridview(this.dgv_schedules, dtp_sched.Value.ToString("M/dd/yyyy"));
        }

        private void dtp_sched_ValueChanged(object sender, EventArgs e)
        {
            this._load_schedules_to_datagridview(this.dgv_schedules, dtp_sched.Value.ToString("M/dd/yyyy"));
        }

        private void toolStripBtn_edit_Click(object sender, EventArgs e)
        {
            int selected_id = Convert.ToInt32(this.dgv_schedules.SelectedRows[0].Cells["sched_id"].Value);
            FRM_ADD_EDIT_SCHEDULES frmAddEditSchedules = new FRM_ADD_EDIT_SCHEDULES(this, selected_id);
            frmAddEditSchedules.ShowDialog(this);
        }

        private void toolStripBtn_delete_Click(object sender, EventArgs e)
        {
            int selectedRow = Convert.ToInt32(dgv_schedules.SelectedRows[0].Cells["sched_id"].Value);
            if (selectedRow > 0)
            {
                DialogResult res = MessageBox.Show("Are you sure you want to delete this schedule?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    if (this._remove_data(selectedRow) == true)
                    {
                        MessageBox.Show("Successfully removed schedule", "Additional Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.init_all();
                    }
                    else
                    {
                        MessageBox.Show("Problem deleting the schedule", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // -----------------------------------------------------------------------------------------------

    }
}
