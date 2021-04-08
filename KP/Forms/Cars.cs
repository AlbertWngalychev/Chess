using KP.DataBase;
using KP.Extension;
using System.Windows.Forms;

namespace KP.Forms
{
    public partial class Cars : Form
    {
        public Cars()
        {
            InitializeComponent();

            dataGridView1.Load(DB.Cars);
        }

        private void KeyPressTextBox(object sender, KeyPressEventArgs e)
        {
            e.CharIsDigitHandled();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text.Equals("Обновить"))
            {
                dataGridView1.Load(DB.Cars);
            }
            else if (e.ClickedItem.Text.Equals("Добавить"))
            {
                new Car().Show();
            }
            else if (e.ClickedItem.Text.Equals("Изменить"))
            {
                new Car(dataGridView1.GetSellectedFirstCoulumnStr()).Show();
            }
            else if (e.ClickedItem.Text.Equals("Удалить"))
            {
                string vin = dataGridView1.GetSellectedFirstCoulumnStr();
                DataBase.Models.Car c = DB.Find.Car(vin);

                if (MsgBox.Remove(c))
                {
                    DB.Remove(c);
                    dataGridView1.Load(DB.Cars);
                }
            }
            else if (e.ClickedItem.Text.Equals("Найти"))
            {
                dataGridView1.Load(DB.Find.Cars(toolStripTextBoxSearchVIN.Text));
            }

        }

    }
}

