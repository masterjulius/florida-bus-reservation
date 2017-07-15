using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Florida_Bus_Reservation.Classes
{
    public static class Globals
    {
        public static int user_control_id { get; set; }

        public static void catch_connection(MySqlConnection conn)
        {
            
        }
    }
}
