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
    public partial class FRM_VIEW_ALL_BUS : Form
    {
        public FRM_VIEW_ALL_BUS()
        {
            InitializeComponent();
        }

        private void FRM_VIEW_ALL_BUS_Load(object sender, EventArgs e)
        {
            this.init_all();
        }

        private void init_all()
        {
            this._load_datas_to_datagrid(this.dgv_datas);
        }

        private void _load_datas_to_datagrid(DataGridView dgv, string[] arrSearchKeys = null, string[] arrSearchValues = null)
        {
            Classes.Connection Connection = new Classes.Connection();
            using (MySqlConnection conn = new MySqlConnection(Connection.connStr))
            {
                string selected_fields = "`tbl_bus`.`bus_id`, `tbl_bus_class`.`class_name` as `BUS CLASS`, `tbl_bus`.`bus_number` as `BUS NUMBER`, `tbl_bus`.`bus_plate_number` as `PLATE NUMBER`, `tbl_bus`.`bus_created_date` AS `BUS CREATED DATE`";
                string joinStmt = "left join `tbl_bus_class` on `tbl_bus`.`bus_class_id`=`tbl_bus_class`.`class_id`";

                string stmtNormal = "select " + selected_fields + " from  `tbl_bus` " + joinStmt + " where `bus_is_active`=1 order by CAST(`bus_number` as SIGNED INTEGER) ASC";

                string stmtSearch = "select " + selected_fields + " from  `tbl_bus` "  + joinStmt +  " where `bus_is_active`=1 and (";
                if (!Classes.Datatypes.ArrayIsNullOrEmpty(arrSearchKeys) && !Classes.Datatypes.ArrayIsNullOrEmpty(arrSearchValues))
                {
                    for (int i = 0; i < arrSearchKeys.Length; i++)
                    {
                        string commaStr = i >= arrSearchKeys.Length - 1 ? "" : " or ";
                        stmtSearch += string.Format("`{0}` like @{1}{2}", arrSearchKeys[i], arrSearchKeys[i], commaStr);
                    }
                }
                stmtSearch += ")order by CAST(`bus_number` as SIGNED INTEGER) ASC";

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

                    // hide some datagridview columns
                    Classes.Forms._hide_datagridview_column(this.dgv_datas, new string[1] {"bus_id"});

                }

            }
        }

        private void toolStripTxt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            string searchVal = this.toolStripTxt_search.Text;
            this._load_datas_to_datagrid(this.dgv_datas, new string[] { "bus_number", "bus_plate_number" }, new string[] { searchVal, searchVal });
        }

    }
}
