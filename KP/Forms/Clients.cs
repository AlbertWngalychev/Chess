using KP.DataBase;
using KP.Extension;
using System;
using System.Windows.Forms;

namespace KP.Forms
{
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();

            dataGridView1.Load(DB.Clients);
            dataGridView1.Columns[dataGridView1.Columns.Count - 1].Visible = false;

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text.Equals("Обновить"))
            {
                dataGridView1.Load(DB.Clients);
            }
            else if (e.ClickedItem.Text.Equals("Добавить"))
            {
                new AddEditClient().Show();
            }
            else if (e.ClickedItem.Text.Equals("Изменить"))
            {
                new AddEditClient(dataGridView1.GetSellectedFirstCoulumn()).Show();
            }
            else if (e.ClickedItem.Text.Equals("Удалить"))
            {
                int client = dataGridView1.GetSellectedFirstCoulumn();
                DataBase.Models.Client c = DB.Find.Client(client);

                if (MsgBox.Remove(c))
                {
                    DB.Remove(c);
                    dataGridView1.Load(DB.Clients);
                }
            }
            else if (e.ClickedItem.Text.Equals("Найти"))
            {
                string txt = toolStripTextBox1.Text;

                if (txt.Length < 10 || int.Parse(txt) >= Int32.MaxValue)
                {
                    MsgBox.ErrorShow("Не верно заполнено поле.");
                    return;
                }

                dataGridView1.DataSource = DB.Find.Clients(int.Parse(toolStripTextBox1.Text));

            }

        }
    }
}
