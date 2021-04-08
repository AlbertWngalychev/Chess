using KP.DataBase;
using KP.Extension;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KP.Forms
{
    public partial class Car : Form
    {
        private readonly DataBase.Models.Car car;
        private readonly List<DataBase.Models.BodyCar> bclist;
        private readonly List<DataBase.Models.Color> clrlist;
        private readonly List<DataBase.Models.Model> mdllist;

        public Car()
        {
            InitializeComponent();
            MaximizeBox = false;
            MaximumSize = Size;
            MinimumSize = Size;

            bclist = DB.BodyCars;
            clrlist = DB.Colors;
            mdllist = DB.Models;

            foreach (DataBase.Models.BodyCar item in bclist)
            {
                comboBoxBodyCar.Items.Add(item.Name);
            }

            foreach (DataBase.Models.Color item in clrlist)
            {
                comboBoxColor.Items.Add(item.Name);
            }

            foreach (DataBase.Models.Model item in mdllist)
            {
                comboBoxModel.Items.Add(GetManufAndName(item));
            }

        }

        public Car(string vin)
            : this()
        {
            car = DB.Find.Car(vin);

            for (int i = 0; i < bclist.Count; i++)
            {
                if (bclist[i].Id == car.IdbodyCar)
                {
                    comboBoxBodyCar.SelectedItem = bclist[i].Name;
                    break;
                }
            }

            for (int i = 0; i < clrlist.Count; i++)
            {
                if (clrlist[i].Id == car.Idcolor)
                {
                    comboBoxColor.SelectedItem = clrlist[i].Name;
                    break;
                }
            }

            for (int i = 0; i < mdllist.Count; i++)
            {
                if (mdllist[i].Id == car.Idmodel)
                {
                    comboBoxModel.SelectedItem = GetManufAndName(mdllist[i]);
                    break;
                }
            }

            textBoxVin.Text = car.Vin;
            textBoxVin.Enabled = false;

            textBoxGovNumber.Text = car.GovNumber;
            richTextBoxPath.Text = car.PathImg;

            numericUpDownPower.Value = car.Power;
            numericUpDownSeats.Value = car.Seats;
            numericUpDownTCoeff.Value = (decimal)car.Tcoeff;
            numericUpDownTrunk.Value = car.Trunk;

            checkBoxAutoTrans.Checked = car.AutoTrans;
            checkBoxFreedom.Checked = car.Freedom;
            checkBoxPetrol.Checked = car.Petrol;
        }

        private static string GetManufAndName(DataBase.Models.Model mdl)
        {
            return mdl.Manufacturer + " " + mdl.Name;
        }

        private void buttonOFD_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog
            {
                ShowNewFolderButton = true
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                richTextBoxPath.Text = dialog.SelectedPath;
            }

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            if (!CheckInfo())
            {
                return;
            }
            if (car != null)
            {
                DB.Edit.Car(car.Vin, new DataBase.Models.Car()
                {
                    IdbodyCar = bclist[comboBoxBodyCar.SelectedIndex].Id,
                    Idmodel = mdllist[comboBoxModel.SelectedIndex].Id,
                    Idcolor = clrlist[comboBoxColor.SelectedIndex].Id,
                    GovNumber = textBoxGovNumber.Text,
                    Tcoeff = (double)numericUpDownTCoeff.Value,
                    Seats = (int)numericUpDownSeats.Value,
                    AutoTrans = checkBoxAutoTrans.Checked,
                    Power = (int)numericUpDownPower.Value,
                    Petrol = checkBoxPetrol.Checked,
                    Freedom = checkBoxFreedom.Checked,
                    PathImg = richTextBoxPath.Text

                });
            }
            else
            {
                DB.Add(new DataBase.Models.Car()
                {
                    Vin = textBoxVin.Text,
                    IdbodyCar = bclist[comboBoxBodyCar.SelectedIndex].Id,
                    Idmodel = mdllist[comboBoxModel.SelectedIndex].Id,
                    Idcolor = clrlist[comboBoxColor.SelectedIndex].Id,
                    GovNumber = textBoxGovNumber.Text,
                    Tcoeff = (double)numericUpDownTCoeff.Value,
                    Seats = (int)numericUpDownSeats.Value,
                    AutoTrans = checkBoxAutoTrans.Checked,
                    Power = (int)numericUpDownPower.Value,
                    Petrol = checkBoxPetrol.Checked,
                    Freedom = checkBoxFreedom.Checked,
                    PathImg = richTextBoxPath.Text

                });
            }
            if (!MsgBox.DoneContinue())
            {
                Close();
            }
        }

        private bool CheckInfo()
        {
            if (textBoxGovNumber.Text.Length < 8)
            {
                MsgBox.ErrorShow("Неверный гос. номер.");
                return false;
            }
            if (textBoxVin.Text.Length < 17)
            {
                MsgBox.ErrorShow("Неверный VIN.");
                return false;
            }
            if (numericUpDownPower.Value < 10)
            {
                MsgBox.ErrorShow("Неверная скорость.");
                return false;
            }
            if (numericUpDownTCoeff.Value == 0)
            {
                MsgBox.ErrorShow("Неверная коэффициент.");
                return false;
            }
            if (String.IsNullOrEmpty(richTextBoxPath.Text))
            {
                MsgBox.ErrorShow("Неверная путь.");
                return false;
            }




            return true;
        }
    }
}
