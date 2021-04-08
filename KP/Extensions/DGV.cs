using System.Collections;
using System.Windows.Forms;

namespace KP.Extension
{
    internal static class DGV
    {
        public static int GetSellectedFirstCoulumn(this DataGridView dataGridView)
        {
            return int.Parse(dataGridView.SelectedRows[0].Cells[0].Value.ToString());
        }

        public static string GetSellectedFirstCoulumnStr(this DataGridView dataGridView)
        {
            return dataGridView.SelectedRows[0].Cells[0].Value.ToString();
        }

        public static void Load(this DataGridView dataGridView, IList list)
        {

            if (list == null)
            {
                return;
            }

            dataGridView.DataSource = list;
        }

    }
}
