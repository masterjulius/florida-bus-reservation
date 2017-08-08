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

namespace Florida_Bus_Reservation.TRANSACTIONS
{
    public partial class FRM_PAYMENTS : Form
    {
        // Variables
        private Classes.Connection Connection = new Classes.Connection();
        public FRM_PAYMENTS()
        {
            InitializeComponent();
        }

        private void FRM_PAYMENTS_Load(object sender, EventArgs e)
        {
            this.init_all();
        }

        private void init_all()
        {
            this._load_datas_to_datagridview(this.dgv_bills);
        }

        // --------------------------------------------------------------------------------------------------------------------------
        private void _load_datas_to_datagridview(DataGridView dgv, string[] searchKeys = null, string[] searchValues = null)
        {
            using (MySqlConnection conn = new MySqlConnection(Connection.connStr))
            {
                string stmt = "SELECT `TBL_TRANSACTIONS`.`TRANS_ID`, `TBL_TRANSACTIONS`.`TRANS_RESERVATION_ID`, `TBL_RESERVATIONS`.`RES_CODE` AS `RESERVATION CODE`, `TBL_TRANSACTIONS`.`TRANS_TOTAL_PAYMENT` AS `TOTAL BILL`, `TBL_TRANSACTIONS`.`TRANS_EDITED_DATE` AS `RESERVATION DATE` FROM `TBL_TRANSACTIONS` LEFT JOIN `TBL_RESERVATIONS` ON `TBL_TRANSACTIONS`.`TRANS_RESERVATION_ID`=`TBL_RESERVATIONS`.`RES_ID` WHERE `TBL_RESERVATIONS`.`RES_IS_CANCELLED`=0 AND `TBL_TRANSACTIONS`.`TRANS_IS_PAID`=0 AND `TBL_TRANSACTIONS`.`TRANS_IS_ACTIVE`=1";
                using (MySqlCommand cmd = new MySqlCommand(stmt, conn))
                {
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    DataTable dt = new DataTable();
                    conn.Open();
                    da.SelectCommand = cmd;
                    conn.Close();

                    da.Fill(dt);

                    dgv.DataSource = dt;

                    // hide datagridview columns
                    Classes.Forms._hide_datagridview_column(dgv, new string[] { "TRANS_ID", "TRANS_RESERVATION_ID" });

                }
            }
        }

        private void toolStripBtn_accept_Click(object sender, EventArgs e)
        {
            if (this.dgv_bills.SelectedRows.Count > 0)
            {
                int trans_id = Convert.ToInt32(this.dgv_bills.SelectedRows[0].Cells["TRANS_ID"].Value);
                FRM_PAY_BILL frmPayBill = new FRM_PAY_BILL(this, trans_id);
                frmPayBill.ShowDialog(this);
            }
        }

        private void FRM_PAYMENTS_Activated(object sender, EventArgs e)
        {
            this._load_datas_to_datagridview(this.dgv_bills);
        }
        // --------------------------------------------------------------------------------------------------------------------------
    }
}
