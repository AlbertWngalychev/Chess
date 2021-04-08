using KP.DataBase;
using KP.Extension;
using System.Windows.Forms;

namespace KP.Forms
{
    public partial class Contracts : Form
    {
        public Contracts()
        {
            InitializeComponent();
            dataGridView1.Load(DB.Contracts);
        }

        private void toolStripTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.CharIsDigitHandled();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string str = e.ClickedItem.Text;

            if (str.Equals("Обновить"))
            {
                dataGridView1.Load(DB.Contracts);
            }
            else if (str.Equals("Добавить"))
            {
                new Contract().Show();
            }
            else if (str.Equals("Измениить"))
            {
                new Contract(dataGridView1.GetSellectedFirstCoulumn()).Show();
            }
            else if (str.Equals("Удалить"))
            {
                int id = dataGridView1.GetSellectedFirstCoulumn();
                DataBase.Models.Contract c = DB.Find.Contract(id);

                if (MsgBox.Remove(c))
                {
                    DB.Remove(c);

                    dataGridView1.Load(DB.Contracts);
                }
            }
            else if (str.Equals("Найти"))
            {
                int id = int.Parse(toolStripTextBox1.Text);

                dataGridView1.Load(DB.Find.Contracts(id));
            }
        }
    }
}
