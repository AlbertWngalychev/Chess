using KP.DataBase;
using KP.Extension;
using System.Windows.Forms;

namespace KP.Forms
{
    public partial class HistoryCarsPickUp : Form
    {
        public HistoryCarsPickUp()
        {
            InitializeComponent();
            dataGridView2.Load(DB.CarPickups);
            dataGridView2.Columns[dataGridView2.Columns.Count - 1].Visible = false;
            dataGridView2.Columns[dataGridView2.Columns.Count - 2].Visible = false;

            richTextBox1.Text = "Choose some thing";
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idCarPickups = dataGridView2.GetSellectedFirstCoulumn();
            DataBase.Models.CarPickup cpu = DB.Find.CarPickup(idCarPickups);


            dataGridView1.Load(DB.DamageTypesFromCarPuckUp(cpu));

            formatRichTextBox(cpu);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text.Equals("Обновить"))
            {
                dataGridView2.Load(DB.CarPickups);
            }
            else if (e.ClickedItem.Text.Equals("Добавить"))
            {
                new CarsPuckUp().Show();
            }
            else if (e.ClickedItem.Text.Equals("Изменить"))
            {
                if (dataGridView2.Rows.Count == 0)
                {
                    return;
                }
                new CarsPuckUp(dataGridView2.GetSellectedFirstCoulumn()).Show();
            }
            else if (e.ClickedItem.Text.Equals("Удалить"))
            {
                int id = dataGridView2.GetSellectedFirstCoulumn();
                DataBase.Models.CarPickup c = DB.Find.CarPickup(id);

                if (MsgBox.Remove(c))
                {
                    DB.Remove(c);
                    dataGridView2.Load(DB.CarPickups);
                }
            }
            else if (e.ClickedItem.Text.Equals("Найти"))
            {
                dataGridView2.Load(DB.Find.CarPickups(int.Parse(toolStripTextBox1.Text)));

            }
        }

        private void toolStripTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.CharIsDigitHandled();
        }

        private void formatRichTextBox(DataBase.Models.CarPickup cpu)
        {
            DataBase.Models.Contract contract = DB.Find.Contract(cpu.Idcontract);
            DataBase.Models.Client client = DB.Find.Client(contract.Idclient);
            DataBase.Models.Car car = DB.Find.Car(contract.Vinauto);

            richTextBox1.Text = $"CONTRACT\n{new string('-', 25)}\n{contract.GetCharacteristics()}\n" +
                $"{new string('-', 25)}\nCLIENT\n{new string('-', 25)}\n{client.GetCharacteristics()}\n" +
                $"{new string('-', 25)}\nCAR\n{new string('-', 25)}\n{car.GetCharacteristics()}";
        }
    }
}
