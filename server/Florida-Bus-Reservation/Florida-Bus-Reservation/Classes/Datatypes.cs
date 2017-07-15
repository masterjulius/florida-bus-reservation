using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Florida_Bus_Reservation.Classes
{
    public static class Datatypes
    {
        public static bool ArrayIsNullOrEmpty(this Array array)
        {
            return (array == null || array.Length == 0);
        }

        public static int str_to_int32(string str)
        {
            return Convert.ToInt32(str);
        }
        
    }
}
