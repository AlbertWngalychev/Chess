using KP.DataBase;
using KP.Extension;
using System.Windows.Forms;

namespace KP.Forms
{
    public partial class Models : Form
    {
        public Models()
        {
            InitializeComponent();

            dataGridView1.Load(DB.Models);

            dataGridView1.Columns[dataGridView1.Columns.Count - 1].Visible = false;

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "Обновить":
                    dataGridView1.Load(DB.Models);
                    break;

                case "Добавить":
                    new Model().Show();
                    break;

                case "Удалить":
                    DataBase.Models.Model m = DB.Find.Model(dataGridView1.GetSellectedFirstCoulumn());

                    if (MsgBox.Remove(m))
                    {
                        DB.Remove(m);
                        dataGridView1.Load(DB.Models);
                    }
                    break;

                case "Изменить":
                    new Model(DB.Find.Model(dataGridView1.GetSellectedFirstCoulumn())).Show();
                    break;

                default:
                    break;
            }
        }
    }
}
