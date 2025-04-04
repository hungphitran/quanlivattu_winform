using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlyvattu
{
    internal class FormManager
    {
        public static void switchForm(Form curr, Form next)
        {
            curr.Close();
            next.Show();
        }
    }
}
