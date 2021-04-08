using KP.DataBase;
using KP.Extension;
using System;
using System.Windows.Forms;

namespace KP.Forms
{
    public partial class CarsPuckUp : Form
    {
        DataBase.Models.CarPickup cpu;

        public CarsPuckUp()
        {
            InitializeComponent();
            textBoxAuto.Enabled = false;
            textBoxClient.Enabled = false;


            //textBoxIdContract.Enabled = false;
            //textBoxAcceptor.Enabled = false;
            //dateTimePicker.Enabled = false;
            groupBox1.Enabled = false;
        }

        public CarsPuckUp(int id)
           : this()
        {
            cpu = DB.Find.CarPickup(id);
            textBoxIdContract.Text = cpu.Idcontract.ToString();
            textBoxAcceptor.Text = cpu.FullNameAcceptor;
            dateTimePicker.Value = cpu.Holding.Value.Date;

            DataBase.Models.Contract contract = DB.Find.Contract(cpu.Idcontract);
            textBoxAuto.Text = contract.Vinauto;
            textBoxClient.Text = contract.Idclient.ToString();


            textBoxIdContract.Enabled = false;
            textBoxAcceptor.Enabled = false;
            dateTimePicker.Enabled = false;

            dataGridView1.Load(DB.DamageTypesFromCarPuckUp(cpu));
            groupBox1.Enabled = true;

        }


        private void buttonEditDT_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count <= 0)
            {
                return;
            }
            int id = dataGridView1.GetSellectedFirstCoulumn();

            new DamageType(id, cpu).Show();
        }

        private void textBoxIdContract_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.CharIsDigitHandled();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count <= 0)
            {
                return;
            }

            int id = dataGridView1.GetSellectedFirstCoulumn();
            DataBase.Models.DamageType dt = DB.Find.DamageType(id);

            textBoxDTName.Text = dt.Name;
            numericUpDown1.Value = (decimal)dt.Damage;
            textBoxPrice.Text = dt.FixPrice.ToString();
            richTextBox1.Text = dt.Comment;
        }

        private void buttonReloadDT_Click(object sender, EventArgs e)
        {
            if (cpu == null)
            {
                return;
            }
            dataGridView1.Load(DB.DamageTypesFromCarPuckUp(cpu));
        }

        private void buttonAddDT_Click(object sender, EventArgs e)
        {
            new DamageType(cpu).Show();
        }

        private void buttonRemoveDT_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count <= 0)
            {
                return;
            }
            int id = dataGridView1.GetSellectedFirstCoulumn();

            var dt = DB.Find.DamageType(id);

            

            if (MsgBox.Remove(dt))
            {
                foreach (var item in DB.VerDetails)
                {
                    if (item.IddamageType == id)
                    {
                        DB.Remove(item);
                        break;
                    }
                }
            }

        }

        private void CarsPuckUp_Load(object sender, EventArgs e)
        {

        }

        private void buttonCreateCarPickUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxIdContract.Text))
            {
                MsgBox.ErrorShow("Не верныо указан id контракта.");
                return;
            }
            int idcontr = int.Parse(textBoxIdContract.Text);

            DataBase.Models.Contract c = DB.Find.Contract(idcontr);
            if (c == null)
            {
                MsgBox.ErrorShow("Не найден контракт.");
                return;
            }
            if (c.Start > dateTimePicker.Value.Date)
            {
                MsgBox.ErrorShow("Неверная дата приёмки.");
                return;
            }

            cpu = DB.CreateAndGetCarPickUp(new DataBase.Models.CarPickup()
            {
                FullNameAcceptor = textBoxAcceptor.Text,
                Holding = dateTimePicker.Value.Date,
                Idcontract = int.Parse(textBoxIdContract.Text)
            });

            if (cpu == null)
            {
                MsgBox.ErrorShow("Ошибка!");
                return;
            }

            buttonCreateCarPickUp.Enabled = false;
            groupBox1.Enabled = true;
            buttonEditCPU.Enabled = true;
            textBoxAuto.Text = c.Vinauto;
            textBoxClient.Text = c.Idclient.ToString();

        }

        private void buttonEditCPU_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxIdContract.Text))
            {
                MsgBox.ErrorShow("Не верныо указан id контракта.");
                return;
            }
            int idcontr = int.Parse(textBoxIdContract.Text);

            DataBase.Models.Contract c = DB.Find.Contract(idcontr);
            if (c == null)
            {
                MsgBox.ErrorShow("Не найден контракт.");
                return;
            }
            if (c.Start > dateTimePicker.Value.Date)
            {
                MsgBox.ErrorShow("Неверная дата приёмки.");
                return;
            }
            DB.Edit.CarPickup(cpu.Id, new DataBase.Models.CarPickup()
            {

                FullNameAcceptor = textBoxAcceptor.Text,
                Holding = dateTimePicker.Value.Date,
                Idcontract = int.Parse(textBoxIdContract.Text)
            });

            cpu = DB.Find.CarPickup(cpu.Id);
            textBoxAcceptor.Text = cpu.FullNameAcceptor;
            textBoxIdContract.Text = cpu.Idcontract.ToString();
            dateTimePicker.Value = cpu.Holding.Value;
        }

        private void onDone_Click(object sender, EventArgs e)
        {
            if (!MsgBox.DoneContinue())
            {
                this.Close();
            }
        }
    }
}
