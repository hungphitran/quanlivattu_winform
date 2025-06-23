using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using DevExpress.XtraEditors;

namespace quanlyvattu
{
    internal class KeyPressConstraint
    {
        public static void KeyPress_OnlyAsciiLettersAndDigits_NoSpace(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra là chữ hoặc số ASCII (loại bỏ Unicode như tiếng Việt)
            if (!char.IsControl(e.KeyChar) &&
                !(e.KeyChar >= 'A' && e.KeyChar <= 'Z') &&
                !(e.KeyChar >= 'a' && e.KeyChar <= 'z') &&
                !(e.KeyChar >= '0' && e.KeyChar <= '9'))
            {
                e.Handled = true;
            }
        }
        public static void KeyPress_OnlyAsciiLettersAndDigits_ToLowercase_NoSpace(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                     !(e.KeyChar >= 'A' && e.KeyChar <= 'Z') &&
                     !(e.KeyChar >= 'a' && e.KeyChar <= 'z') &&
                     !(e.KeyChar >= '0' && e.KeyChar <= '9')) 
            {
                // Reject any other characters
                e.Handled = true;
            }
            else
            {
                if (char.IsUpper(e.KeyChar))
                {
                    e.KeyChar = char.ToLower(e.KeyChar);
                }
            }
        }

        public static void KeyPress_OnlyAsciiLettersAndDigits_ToUppercase_NoSpace(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !(e.KeyChar >= 'A' && e.KeyChar <= 'Z') &&
                !(e.KeyChar >= 'a' && e.KeyChar <= 'z') &&
                !(e.KeyChar >= '0' && e.KeyChar <= '9'))
            {
                // Reject any other characters
                e.Handled = true;
            }
            else
            {
                if (char.IsLower(e.KeyChar))
                {
                    e.KeyChar = char.ToUpper(e.KeyChar);
                }
            }
        }

        public static void KeyPress_OnlyDigits(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public static void KeyPress_OnlyLetters(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) )
            {
                e.Handled = true;
            }
        }
        public static void KeyPress_LettersDigitsSpace(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsLetterOrDigit(e.KeyChar) &&
                e.KeyChar != ' ')
            {
                e.Handled = true;
            }
            else
            {
                Console.WriteLine(sender);
                if ((sender is TextBox textBox && e.KeyChar == ' ' && (textBox.Text.EndsWith(" ")||textBox.Text.Length==0)) || (sender is TextEdit textEdit && e.KeyChar == ' ' && (textEdit.Text.EndsWith(" ") || textEdit.Text.Length==0)))
                {
                    e.Handled = true;
                }
            }
        }

        //constraint cho Họ
        public static void KeyPress_OnlyLettersAndSpace(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsLetter(e.KeyChar) &&
                e.KeyChar != ' ')
            {
                e.Handled = true;
            }
            else
            {
                if ((sender is TextBox textBox && e.KeyChar == ' ' && (textBox.Text.EndsWith(" ") || textBox.Text.Length == 0)) || (sender is TextEdit textEdit && e.KeyChar == ' ' && (textEdit.Text.EndsWith(" ") || textEdit.Text.Length == 0)))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
