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
    public partial class FRM_VIEW_ALL_BUS_CLASS : Form
    {
        //initialize variables here
        private Form frmParent;
        private TextBox frmTxtBox;
        public FRM_VIEW_ALL_BUS_CLASS(Form frm, TextBox txtBox)
        {
            InitializeComponent();
            this.frmParent = frm;
            this.frmTxtBox = txtBox;
        }

        private void FRM_VIEW_ALL_BUS_CLASS_Load(object sender, EventArgs e)
        {
            this._load_datas(this.dgv_datas );
        }

        // ------------------------------------------------------------------------
        private void _load_datas(DataGridView dgv, string[] arrSearchKeys = null, string[] arrSearchValues = null)
        {
            Classes.Connection Connection = new Classes.Connection();
            using (MySqlConnection conn = new MySqlConnection(Connection.connStr)) {

                string stmtNormal = "select `class_id`, `class_name`, `class_seat_count`, `class_has_aircon`, `class_remarks` from  `tbl_bus_class` where `class_is_active`=1";

                string stmtSearch = "select `class_id`, `class_name`, `class_seat_count`, `class_has_aircon`, `class_remarks` from  `tbl_bus_class` where `class_is_active`=1 and (";
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
                    DataSet ds = new DataSet();
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

                    da.Fill(ds, "tbl_bus_class");

                    string[] arrColumns = new string[] { "ID", "CLASS NAME", "NUMBER OF SEATS", "AIR-CONDITIONED", "REMARKS" };
                    Classes.Forms._create_datagrid_columns(this.dgv_datas, arrColumns);
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        DataRow row = ds.Tables[0].Rows[i];
                        string[] arrDatas = new string[5];
                        arrDatas[0] = row["class_id"].ToString();
                        arrDatas[1] = row["class_name"].ToString();
                        arrDatas[2] = row["class_seat_count"].ToString();
                        arrDatas[3] = row["class_has_aircon"].ToString() == "1" ? "YES" : "NO";
                        arrDatas[4] = row["class_remarks"].ToString();
                        Classes.Forms._add_rows(this.dgv_datas, arrDatas);
                    }

                    // hide columns
                    string[] arrHiddenColumns = new string[1] {"ID"};
                    Classes.Forms._hide_datagridview_column(this.dgv_datas,arrHiddenColumns);

                }
            }
        }

        // get meta datas
        private object[] _get_datas(int class_id)
        {
            Classes.Connection Connection = new Classes.Connection();
            using (MySqlConnection conn = new MySqlConnection(Connection.connStr))
            {
                string stmt = "select `class_id`, `class_name`, `class_seat_count`, `class_has_aircon`, `class_remarks`, `class_edited_date` from `tbl_bus_class` where `class_id`=@class_id and `class_is_active`=1";
                using (MySqlCommand cmd = new MySqlCommand(stmt, conn))
                {
                    cmd.Parameters.Add("@class_id", MySqlDbType.VarChar).Value = class_id;
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

        private void toolStripBtn_fetch_Click(object sender, EventArgs e)
        {
            //object[] getObject = this._get_datas(Convert.ToInt32(this.dgv_datas.SelectedRows[0].Cells["ID"].Value));
            //if (getObject != null)
            //{
                this.frmTxtBox.Text = this.dgv_datas.SelectedRows[0].Cells["CLASS NAME"].Value.ToString();
                this.frmTxtBox.Tag = this.dgv_datas.SelectedRows[0].Cells["ID"].Value;
                this.Dispose();
            //}
        }

        private void toolStripTxt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            string searchVal = this.toolStripTxt_search.Text;
            this._load_datas(this.dgv_datas, new string[] { "class_name", "class_remarks" }, new string[] { searchVal, searchVal });
        }

        

        // -------------------------------------------------------------------------------------------------------------

    }
}
