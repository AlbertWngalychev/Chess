using KP.DataBase;
using KP.Extension;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace KP.Forms
{
    public partial class Main : Form
    {
        private KP.DataBase.Models.Car car;
        private List<Bitmap> img;
        private int iterator = 0;

        public Main()
        {
            InitializeComponent();

            var cars = DB.FreeCars(0, AutoTrans.AllTrans);
            dataGridView1.Load(cars);
            dataGridView1.Columns[0].Visible = false;


            dataGridViewClients.Load(DB.Clients);
            dataGridViewClients.Columns[dataGridViewClients.Columns.Count - 1].Visible = false;

            img = new List<Bitmap>();

            label13.Text = "";


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            car = DB.Find.Car(dataGridView1.GetSellectedFirstCoulumnStr());

            DirectoryInfo directoryInfo = new DirectoryInfo(car.PathImg);

            foreach (var file in directoryInfo.GetFiles())
            {
                if (Path.GetExtension(file.FullName) == ".jpg" || Path.GetExtension(file.FullName) == ".png"
                    || Path.GetExtension(file.FullName) == ".jpeg")
                {
                    img.Add(new Bitmap(file.FullName));
                }
            }
            if (img.Count == 0)
            {
                return;
            }
            pictureBox1.Image = img[iterator];
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.CharIsDigitHandled();
        }

        #region buttonClick
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxVIN.Text))
            {
                MsgBox.ErrorShow("Не выбран автомобиль");
                return;
            }
            else if (string.IsNullOrEmpty(textBoxSNPasport.Text))
            {
                MsgBox.ErrorShow("Не выбран клиент");
                return;
            }
            else if (dateTimePicker1.Value.Date > dateTimePicker2.Value.Date)
            {
                MsgBox.ErrorShow("Не верная дата аренды");
                return;
            }

            DB.Add(new DataBase.Models.Contract()
            {
                Idclient = int.Parse(textBoxSNPasport.Text),
                Vinauto = textBoxVIN.Text,
                Start = dateTimePicker1.Value.Date,
                End = dateTimePicker2.Value.Date
            });

            DB.Edit.Car(textBoxVIN.Text, DB.Find.Car(textBoxVIN.Text).changeFreedom());

        }

        private void takeCar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = CarsPage;
        }

        private void buttonOpenFD_Click(object sender, EventArgs e)
        {
            if (car == null)
            {
                car = DB.Find.Car(dataGridView1.GetSellectedFirstCoulumnStr());
            }

            Process.Start("explorer.exe", car.PathImg);

        }

        private void buttonBodyCars_Click(object sender, EventArgs e)
        {
            new BodyCars().Show();
        }

        private void buttonColors_Click(object sender, EventArgs e)
        {
            new Colors().Show();
        }

        private void buttonModels_Click(object sender, EventArgs e)
        {
            new Forms.Models().Show();
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            new Clients().Show();
        }

        private void buttonCars_Click(object sender, EventArgs e)
        {
            new Cars().Show();
        }

        private void buttonContracts_Click(object sender, EventArgs e)
        {
            new Contracts().Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (img.Count == 0)
            {
                return;
            }

            iterator--;

            if (iterator < 0)
            {
                iterator = img.Count - 1;
            }

            pictureBox1.Image = img[iterator];

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {

            if (img.Count == 0)
            {
                return;
            }

            iterator++;

            if (iterator > img.Count - 1)
            {
                iterator = 0;
            }

            pictureBox1.Image = img[iterator];
        }

        private void buttonCarPuckUp_Click(object sender, EventArgs e)
        {
            new CarsPuckUp().Show();
        }
        private void buttonHistoryCarPickUp_Click(object sender, EventArgs e)
        {
            new HistoryCarsPickUp().Show();
        }
        #endregion

        #region toolStripItemClicked
        private void toolStripCar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text.Equals("Сбросить"))
            {
                reset();
            }
            else if (e.ClickedItem.Text.Equals("Обновить"))
            {
                Reload();
            }
            else if (e.ClickedItem.Text.Equals("Выбрать"))
            {
                choose();
            }
        }

        private void Reload()
        {
            if (toolStripTextBoxPower.Text.ToLower().Contains('м'))
            {
                toolStripTextBoxPower.Text = "0";
            }

            int pwr = int.Parse(toolStripTextBoxPower.Text);
            AutoTrans trns = AutoTrans.AllTrans;

            if (toolStripComboBoxTrnas.Text == "Автомат")
            {
                trns = AutoTrans.AutoTrans;
            }
            else if (toolStripComboBoxTrnas.Text == "Механика")
            {
                trns = AutoTrans.MechTrans;
            }

            dataGridView1.Load(DB.FreeCars(pwr, trns));
        }

        private void reset()
        {
            dataGridView1.Load(DB.FreeCars(0, AutoTrans.AllTrans));
            toolStripTextBoxPower.Text = "0";
            toolStripComboBoxTrnas.Text = "КП";
        }

        private void choose()
        {
            car = DB.Find.Car(dataGridView1.GetSellectedFirstCoulumnStr());
            DataBase.Models.Model model = DB.Find.Model(car.Idmodel);
            DataBase.Models.Color clr = DB.Find.Color(car.Idcolor);
            DataBase.Models.BodyCar bc = DB.Find.BodyCar(car.IdbodyCar);

            textBoxVIN.Text = car.Vin;
            textBoxBody.Text = $"{bc.Name}  Закрытый: {bc.Closed}";
            textBoxModel.Text = $"{model.Manufacturer}  {model.Name}";
            textBoxColor.Text = $"{clr.Name}  Металик: {clr.Metallic}";

            tabControl1.SelectedTab = AddContractPage;
        }

        private void toolStripClient_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "Обновить":
                    dataGridViewClients.Load(DB.Clients);
                    break;

                case "Добавить":
                    new AddEditClient().Show();
                    break;

                case "Найти":
                    if (checkSearchTextBoxClient())
                    {
                        dataGridViewClients.Load(DB.Find.Clients(int.Parse(textBoxSearch.Text)));
                    }
                    else
                    {
                        MsgBox.ErrorShow("Не верно заполнено поле.");
                    }
                    break;

                case "Выбрать":
                    chooseClient();
                    break;

                default:
                    break;
            }
        }

        private bool checkSearchTextBoxClient()
        {
            string txt = textBoxSearch.Text;

            if (txt.Length < 10 || int.Parse(txt) >= Int32.MaxValue)
            {
                return false;
            }

            return true;
        }

        public void chooseClient()
        {
            DataBase.Models.Client client = DB.Find.Client(dataGridViewClients.GetSellectedFirstCoulumn());

            textBoxSNPasport.Text = client.Snpasport.ToString();
            textBoxSName.Text = client.Sname;
            textBoxName.Text = client.Name;
            textBoxLName.Text = client.Lname;
            textBoxDateDL.Text = client.StartTimeDl.Date.ToShortDateString();
            textBoxDriverL.Text = client.DriverLicense.ToString();

            tabControl1.SelectedTab = AddContractPage;

        }


        #endregion

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (car==null)
            {
                return;
            }
            if (dateTimePicker1.Value.Date>dateTimePicker2.Value.Date 
                || dateTimePicker1.Value.Date<DateTime.Now.Date)
            {
                label13.Text = "Не верная дата";
                return;
            }

            DataBase.Models.Model m = DB.Find.Model(car.Idmodel);

            int days = (dateTimePicker2.Value.Year - dateTimePicker1.Value.Year) * 365
                      + (dateTimePicker2.Value.Month - dateTimePicker1.Value.Month) * 30
                      + (dateTimePicker2.Value.Day - dateTimePicker1.Value.Day);
            decimal dayprice;

            if (days<30)
            {
                dayprice = m.PriceIn1moth/30;
            } 
            else if (days<30*6+1)
            {
                dayprice = m.PriceUpto6mth / 30*6+1;
            }
            else if (days < 365+1)
            {
                dayprice = m.PriceUpto1year / 365;
            }
            else if(days < 365*2+1)
            {
                dayprice = m.PriceFrom1year/ 365 * 2;
            }
            else
            {
                dayprice = 1000;
            }

            label13.Text = $"-за месяц: {m.PriceIn1moth}\n рублей" +
                $"-за полгода: {m.PriceUpto6mth}\n рублей" +
                $"-за года: {m.PriceUpto1year}\n рублей" +
                $"-свыше года: {m.PriceFrom1year}\n рублей" +
                $"Количество выбранных дней: {days}\n" +
                $"Цена за сутки: {dayprice}\n  рублей" +
                $"Сумма: {dayprice*days}  рублей";

        }
    }
}
