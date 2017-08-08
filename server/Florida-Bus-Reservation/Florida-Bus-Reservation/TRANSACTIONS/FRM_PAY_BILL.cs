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
    public partial class FRM_PAY_BILL : Form
    {
        // Variables
        private Form frm_parent;
        private int frm_bill_id = 0;
        private double frm_total_payment = 0;
        Classes.Connection Connection = new Classes.Connection();
        public FRM_PAY_BILL(Form frm,int bill_id)
        {
            InitializeComponent();
            this.frm_parent = frm;
            this.frm_bill_id = bill_id;
        }

        private void FRM_PAY_BILL_Load(object sender, EventArgs e)
        {
            this.init_all();
        }

        private void init_all()
        {
            if (this.frm_bill_id != 0)
            {
                this._assign_to_fields(this._get_datas(this.frm_bill_id));
                this.btn_accept.Enabled = false;
            }
        }

        // 
        private void _assign_to_fields(object[] obj)
        {
            object[] obs = this._get_datas(this.frm_bill_id);
            this.frm_total_payment = Convert.ToDouble(obj[0]);
            this.lbl_res_code.Text = "RESERVATION CODE: " + obj[1].ToString();
            this.lbl_client.Text = "CLIENT: " + obj[2].ToString() + " " + obj[3].ToString() + " " + obj[4].ToString();
            this.lbl_total.Text = "TOTAL PAYMENT: " + obj[0].ToString();
        }

        private object[] _get_datas(int transaction_id)
        {
            using (MySqlConnection conn = new MySqlConnection(Connection.connStr))
            {
                string stmt = "SELECT `TBL_TRANSACTIONS`.`TRANS_TOTAL_PAYMENT`, `TBL_RESERVATIONS`.`RES_CODE`, `TBL_CLIENTS`.`CLIENT_FIRST_NAME`, `TBL_CLIENTS`.`CLIENT_MIDDLE_NAME`, `TBL_CLIENTS`.`CLIENT_LAST_NAME` FROM `TBL_TRANSACTIONS` LEFT JOIN `TBL_RESERVATIONS` ON `TBL_TRANSACTIONS`.`TRANS_RESERVATION_ID`=`TBL_RESERVATIONS`.`RES_ID` LEFT JOIN `TBL_CLIENTS` ON `TBL_RESERVATIONS`.`RES_CLIENT_ID`=`TBL_CLIENTS`.`CLIENT_ID` WHERE `TBL_TRANSACTIONS`.`TRANS_ID`=@TRANS_ID AND `TBL_TRANSACTIONS`.`TRANS_IS_PAID`=0 AND `TBL_TRANSACTIONS`.`TRANS_IS_ACTIVE`=1";
                using (MySqlCommand cmd = new MySqlCommand(stmt,conn))
                {
                    cmd.Parameters.Add("@TRANS_ID", MySqlDbType.Int32).Value = transaction_id;
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    DataSet ds = new DataSet();
                    conn.Open();
                    da.SelectCommand = cmd;
                    conn.Close();

                    da.Fill(ds, "TBL_TRANSACTIONS");

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        object[] obj = new object[5];
                        DataRow row = ds.Tables[0].Rows[0];
                        obj[0] = row["TRANS_TOTAL_PAYMENT"];
                        obj[1] = row["RES_CODE"];
                        obj[2] = row["CLIENT_FIRST_NAME"];
                        obj[3] = row["CLIENT_MIDDLE_NAME"];
                        obj[4] = row["CLIENT_LAST_NAME"];
                        return obj;
                    }

                    return null;
                }
            }
        }

        // save
        private Boolean _save_data(int transaction_id)
        {
            using (MySqlConnection conn = new MySqlConnection(Connection.connStr))
            {
                string stmt = "UPDATE `TBL_TRANSACTIONS` SET `TRANS_IS_PAID`=1 WHERE `TRANS_ID`=@TRANS_ID AND `TRANS_IS_ACTIVE`=1";
                using (MySqlCommand cmd = new MySqlCommand(stmt,conn))
                {
                    cmd.Parameters.Add("@TRANS_ID", MySqlDbType.Int32).Value = transaction_id;
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

        //
        private Boolean _compare_payments(double total, double amount)
        {
            //if (amount >= total) {
            //    return true; 
            //}
            //return false;
            return amount >= total;
        }

        // interact payment
        private void _interact_payment()
        {
            try
            {
                if (this._compare_payments(this.frm_total_payment, Convert.ToDouble(this.txt_amount.Text)) == true)
                {
                    this.btn_accept.Enabled = true;
                }
                else
                {
                    this.btn_accept.Enabled = false;
                }
            }
            catch (Exception)
            {
                
                //throw;
            }
        }

        private void txt_amount_KeyDown(object sender, KeyEventArgs e)
        {
            this._interact_payment();
        }

        private void txt_amount_KeyUp(object sender, KeyEventArgs e)
        {
            this._interact_payment();
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            if (this._save_data(this.frm_bill_id) == true)
            {
                MessageBox.Show("Successfully paid reservation", "Additional Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.frm_parent.Refresh();
                this.Dispose();
            }
        }

    }
}
