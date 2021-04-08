using KP.DataBase;
using KP.Extension;
using System.Windows.Forms;

namespace KP.Forms
{
    public partial class BodyCars : Form
    {
        public BodyCars()
        {
            InitializeComponent();

            dataGridView1.Load(DB.BodyCars);
            dataGridView1.Columns[dataGridView1.Columns.Count - 1].Visible = false;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text.Equals("Обновить"))
            {
                dataGridView1.Load(DB.BodyCars);
            }
            else if (e.ClickedItem.Text.Equals("Добавить"))
            {
                new BodyCar().Show();
            }
            else if (e.ClickedItem.Text.Equals("Изменить"))
            {
                int id = dataGridView1.GetSellectedFirstCoulumn();
                new BodyCar(DB.Find.BodyCar(id)).Show();
            }
            else if (e.ClickedItem.Text.Equals("Удалить"))
            {
                int Id = dataGridView1.GetSellectedFirstCoulumn();

                DataBase.Models.BodyCar bc = DB.Find.BodyCar(Id);

                if (MsgBox.Remove(bc))
                {
                    DB.Remove(bc);

                    dataGridView1.Load(DB.BodyCars);
                }
            }
        }

    }
}
