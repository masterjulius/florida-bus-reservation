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
    public partial class FRM_CURRENT_SCHEDULES : Form
    {
        // Variables
        Classes.Connection Connection = new Classes.Connection();
        private Form frmParent;
        private TextBox frmTxtBox;
        public FRM_CURRENT_SCHEDULES(Form frm, TextBox txtBox)
        {
            InitializeComponent();
            this.frmParent = frm;
            this.frmTxtBox = txtBox;
        }

        private void FRM_CURRENT_SCHEDULES_Load(object sender, EventArgs e)
        {
            this.init_all();
        }

        private void init_all()
        {
            this._load_datas_to_datagridview(this.dgv_schedules);
        }

        // -------------------------------------------------------------------------------------------------------------------
        // SQL Block
        private void _load_datas_to_datagridview(DataGridView dgv, string[] arrSearchKeys = null, string[] arrSearchValues = null)
        {
            using (MySqlConnection conn = new MySqlConnection(Connection.connStr))
            {

                string stmtNormal = "SELECT `SCHED_ID`, DATE_FORMAT(`SCHED_DATE`, '%M %d, %Y') as `SCHEDULE DATE`, DATE_FORMAT(`SCHED_DEPARTURE_TIME`, '%h:%i:%s %p') AS `DEPARTURE TIME` FROM `TBL_SCHEDULES` WHERE `SCHED_DATE`>=CURDATE() AND `SCHED_IS_ACTIVE`=1";

                string stmtSearch = "SELECT `SCHED_ID`, DATE_FORMAT(`SCHED_DATE`, '%M %d, %Y') as `SCHEDULE DATE`, DATE_FORMAT(`SCHED_DEPARTURE_TIME`, '%h:%i:%s %p') AS `DEPARTURE TIME` FROM `TBL_SCHEDULES` WHERE `SCHED_DATE`>=CURDATE() AND `SCHED_IS_ACTIVE`=1 AND (";
                if (!Classes.Datatypes.ArrayIsNullOrEmpty(arrSearchKeys) && !Classes.Datatypes.ArrayIsNullOrEmpty(arrSearchValues))
                {
                    for (int i = 0; i < arrSearchKeys.Length; i++)
                    {
                        string commaStr = i >= arrSearchKeys.Length - 1 ? "" : " or ";
                        stmtSearch += string.Format("`{0}` like @{1}{2}", arrSearchKeys[i], arrSearchKeys[i], commaStr);
                    }
                }
                stmtSearch += ")";

                string stmt = (!Classes.Datatypes.ArrayIsNullOrEmpty(arrSearchKeys) && !Classes.Datatypes.ArrayIsNullOrEmpty(arrSearchValues)) ? stmtSearch : stmtNormal;

                using (MySqlCommand cmd = new MySqlCommand(stmt, conn))
                {
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    DataTable dt = new DataTable();

                    if (!Classes.Datatypes.ArrayIsNullOrEmpty(arrSearchKeys) && !Classes.Datatypes.ArrayIsNullOrEmpty(arrSearchValues))
                    {
                        for (int i = 0; i < arrSearchKeys.Length; i++)
                        {
                            cmd.Parameters.AddWithValue("@" + arrSearchKeys[i], "%" + arrSearchValues[i] + "%");
                        }
                    }
                    conn.Open();
                    da.SelectCommand = cmd;
                    conn.Close();

                    da.Fill(dt);

                    dgv.DataSource = dt;

                    // hide some datagridview cells
                    Classes.Forms._hide_datagridview_column(this.dgv_schedules, new string[] { "SCHED_ID" });

                }
            }
        }

        private void toolStripTxt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            string searchValue = this.toolStripTxt_search.Text;
            this._load_datas_to_datagridview(this.dgv_schedules, new string[] { "sched_date", "sched_departure_time" }, new string[] { searchValue, searchValue });
        }

        private void toolStripBtn_accept_Click(object sender, EventArgs e)
        {
            if (this.dgv_schedules.SelectedRows.Count > 0)
            {
                int selectedRowID = Convert.ToInt32(this.dgv_schedules.SelectedRows[0].Cells["SCHED_ID"].Value);
                this.frmTxtBox.Text = this.dgv_schedules.SelectedRows[0].Cells["SCHEDULE DATE"].Value.ToString() + " " + this.dgv_schedules.SelectedRows[0].Cells["DEPARTURE TIME"].Value.ToString();
                this.frmTxtBox.Tag = selectedRowID;
                this.Dispose();
            }
        }

        // -------------------------------------------------------------------------------------------------------
    }
}
