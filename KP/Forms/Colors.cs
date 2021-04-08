using KP.DataBase;
using KP.Extension;
using System.Windows.Forms;

namespace KP.Forms
{
    public partial class Colors : Form
    {
        public Colors()
        {
            InitializeComponent();

            dataGridView1.Load(DB.Colors);
            dataGridView1.Columns[dataGridView1.Columns.Count - 1].Visible = false;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "Обновить":
                    dataGridView1.Load(DB.Colors);
                    break;

                case "Добавить":
                    new Color().Show();
                    break;

                case "Изменить":
                    new Color(dataGridView1.GetSellectedFirstCoulumn()).Show();
                    break;

                case "Удалить":
                    int clrid = dataGridView1.GetSellectedFirstCoulumn();
                    DataBase.Models.Color clr = DB.Find.Color(clrid);

                    if (MsgBox.Remove(clr))
                    {
                        DB.Remove(clr);
                        dataGridView1.Load(DB.Colors);
                    }

                    break;


                default:
                    break;
            }
        }


    }
}
