using System;
using System.Windows.Forms;

namespace KP.Extension
{
    internal static class KeyPressExtension
    {
        public static void CharIsDigitHandled(this KeyPressEventArgs e)
        {
            if (KeyIsBackspace(e))
            {
                e.Handled = false;
            }
            else if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static void CharIsLetterHandled(this KeyPressEventArgs e)
        {
            if (KeyIsBackspace(e))
            {
                e.Handled = false;
            }
            else if (!Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private static bool KeyIsBackspace(KeyPressEventArgs e)
        {
            return e.KeyChar.Equals((char)Keys.Back);
        }

    }
}
