using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyvattu
{
    internal class validate
    {
        public validate(){}

        public static bool valid_mavt(string mavt)
        {
            mavt = mavt.Trim();
            if (mavt.Length == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool valid_tenvt(string tenvt)
        {
            tenvt = tenvt.Trim();
            if (tenvt.Length == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
