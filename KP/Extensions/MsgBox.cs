using System.Windows.Forms;

namespace KP.Extension
{
    internal static class MsgBox
    {
        public static void ErrorShow(string str)
        {
            MessageBox.Show(str, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void InformationShow(string str)
        {
            MessageBox.Show(str, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool Remove(KP.DataBase.Models.ICharacteristics characteristics)
        {
            DialogResult dialogResult = MessageBox.Show($"Вы уверены что хотите удалить: \n{characteristics.GetCharacteristics()} ?",
                                                         "Потвердите действие!", MessageBoxButtons.YesNo);
            if (dialogResult.Equals(DialogResult.Yes))
            {
                return true;
            }

            return false;
        }

        public static bool DoneContinue()
        {
            DialogResult dialogResult = MessageBox.Show("Вы хотите продолжить изменения или добавления?", "Готово!", MessageBoxButtons.YesNo);

            if (dialogResult.Equals(DialogResult.Yes))
            {
                return true;
            }

            return false;

        }
    }
}
