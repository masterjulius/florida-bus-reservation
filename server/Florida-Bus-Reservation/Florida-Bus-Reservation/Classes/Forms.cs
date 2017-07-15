using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Florida_Bus_Reservation.Classes
{
    public static class Forms
    {
        // datagrid creation
        public static void _create_datagrid_columns(DataGridView dgv, string[] columnHeaders)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();
            dgv.ColumnCount = columnHeaders.Length;
            for (int i = 0; i < columnHeaders.Length; i++)
            {
                dgv.Columns[i].HeaderText = columnHeaders[i];
            }
        }

        public static void _add_rows(DataGridView dgv, string[] arrayValues)
        {
            dgv.Rows.Add(arrayValues);
        }

        // hiding a datagridview column
        public static void _hide_datagridview_column(DataGridView dgv, string[] arrColumns)
        {
            for (int i = 0; i < arrColumns.Length; i++)
            {
                dgv.Columns[i].Visible = false;
            }
        }

        public static void _strict_char_encoding(KeyPressEventArgs e, int strict_lvl = 1)
        {
            /**
             * Strict levels
             * 1 = exclude character
             * 2 = exclude alphabet letters
             * 3 = exclude numbers only
             * 2 = exclude character & alphabet letters
             * 3 = exclude character & number
             * 4 = exclude alphabet letters & number
             * 5 = exclude character & number 
             */
            if (strict_lvl == 1)
            {

            }
            else if (strict_lvl == 2)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
             }
        }

    }
}
