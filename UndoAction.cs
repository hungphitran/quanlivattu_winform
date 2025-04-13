using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyvattu
{
    public enum ActionType
    {
        Insert,
        Update,
        Delete
    }

    public class UndoAction
    {
        public ActionType Action { get; set; }
        public object[] OldItemArray { get; set; }
        public object[] NewItemArray { get; set; }
        public int index { get; set; } // Chỉ số của item trong danh sách
    }
}
