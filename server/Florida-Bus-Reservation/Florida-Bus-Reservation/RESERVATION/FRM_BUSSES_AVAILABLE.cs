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
    public partial class FRM_BUSSES_AVAILABLE : Form
    {
        // variables
        private Form frmParent;
        private TextBox frmTxtBox;
        private int frm_class_id;
        private Classes.Connection Connection = new Classes.Connection();
        public FRM_BUSSES_AVAILABLE(Form frm, TextBox txtBox, int class_id)
        {
            InitializeComponent();
            this.frmParent = frm;
            this.frmTxtBox = txtBox;
            this.frm_class_id = class_id;
        }

        private void FRM_BUSSES_AVAILABLE_Load(object sender, EventArgs e)
        {
            this.init_all();
        }

        // initialize all
        private void init_all()
        {
            this._load_data_to_datagridview(this.dgv_BUSES);
        }

        // -------------------------------------------------------------------------------------------------------------------
        // SQL Block
        private void _load_data_to_datagridview(DataGridView dgv, string[] arrSearchKeys = null, string[] arrSearchValues = null)
        {
            using (MySqlConnection conn = new MySqlConnection(this.Connection.connStr))
            {
                string stmtNormal = "SELECT `TBL_SCHEDULES`.`SCHED_ID` AS `SCHED_ID`, `TBL_BUS`.`BUS_NUMBER` AS `BUS NUMBER`, `TBL_SCHEDULES`.`SCHED_DATE` AS `SCHEDULE DATE`, `TBL_SCHEDULES`.`SCHED_DEPARTURE_TIME` AS `DEPARTURE TIME` FROM `TBL_SCHEDULES` LEFT JOIN `TBL_BUS` ON `TBL_SCHEDULES`.`SCHED_BUS_ID`=`TBL_BUS`.`BUS_ID` WHERE `TBL_SCHEDULES`.`SCHED_DATE`>=CURDATE() AND `TBL_BUS`.`BUS_CLASS_ID`=@BUS_CLASS_ID AND `TBL_SCHEDULES`.`SCHED_IS_ACTIVE`=1";
                string stmtSearch = "SELECT `TBL_SCHEDULES`.`SCHED_ID` AS `SCHED_ID`, `TBL_BUS`.`BUS_NUMBER` AS `BUS NUMBER`, `TBL_SCHEDULES`.`SCHED_DATE` AS `SCHEDULE DATE`, `TBL_SCHEDULES`.`SCHED_DEPARTURE_TIME` AS `DEPARTURE TIME` FROM `TBL_SCHEDULES` LEFT JOIN `TBL_BUS` ON `TBL_SCHEDULES`.`SCHED_BUS_ID`=`TBL_BUS`.`BUS_ID` WHERE `TBL_SCHEDULES`.`SCHED_DATE`>=CURDATE() AND `TBL_BUS`.`BUS_CLASS_ID`=@BUS_CLASS_ID AND `TBL_SCHEDULES`.`SCHED_IS_ACTIVE`=1 AND (";

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

                    cmd.Parameters.Add("@BUS_CLASS_ID", MySqlDbType.Int32).Value = this.frm_class_id;

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
                    Classes.Forms._hide_datagridview_column(dgv, new string[] { "SCHED_ID" });

                }

            }
        }

        private void toolStripBtn_accept_Click(object sender, EventArgs e)
        {
            if (this.dgv_BUSES.SelectedRows.Count > 0)
            {
                this.frmTxtBox.Text = this.dgv_BUSES.SelectedRows[0].Cells["BUS NUMBER"].Value.ToString();
                this.frmTxtBox.Tag = this.dgv_BUSES.SelectedRows[0].Cells["SCHED_ID"].Value;
                this.Dispose();
            }
        }

        // -------------------------------------------------------------------------------------------------------------------

    }
}
