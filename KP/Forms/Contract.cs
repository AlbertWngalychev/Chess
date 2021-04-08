using KP.DataBase;
using KP.Extension;
using System;
using System.Windows.Forms;

namespace KP.Forms
{
    public partial class Contract : Form
    {
        private readonly DataBase.Models.Contract contract;

        public Contract()
        {
            InitializeComponent();
            MaximizeBox = false;
            MaximumSize = Size;
            MinimumSize = Size;
        }
        public Contract(int id)
            : this()
        {
            contract = DB.Find.Contract(id);

            textBoxId.Enabled = false;
            textBoxId.Text = contract.Id.ToString();
            textBoxClient.Text = contract.Idclient.ToString();
            textBoxVin.Text = contract.Vinauto;

            dateTimePickerStart.Value = contract.Start;
            dateTimePickerEnd.Value = contract.End;
            if (contract.ActualSurrender.Value.Date == null)
            {
                checkBox1.Checked = false;
                dateTimePickerFact.Enabled = false;
            }
            else
            {
                checkBox1.Checked = true;
                dateTimePickerFact.Enabled = true;
                dateTimePickerFact.Value = contract.ActualSurrender.Value.Date;
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            if (!CheckInfo())
            {
                return;
            }

            if (contract != null)
            {
                if (checkBox1.Checked)
                {
                    DB.Edit.Contract(contract.Id, new DataBase.Models.Contract()
                    {
                        Idclient = int.Parse(textBoxClient.Text),
                        Vinauto = textBoxVin.Text,
                        Start = dateTimePickerStart.Value.Date,
                        End = dateTimePickerEnd.Value.Date,
                        ActualSurrender = dateTimePickerFact.Value.Date

                    });
                }
                else
                {
                    DB.Edit.Contract(contract.Id, new DataBase.Models.Contract()
                    {
                        Idclient = int.Parse(textBoxClient.Text),
                        Vinauto = textBoxVin.Text,
                        Start = dateTimePickerStart.Value.Date,
                        End = dateTimePickerEnd.Value.Date
                    });
                }
            }
            else
            {
                if (checkBox1.Checked)
                {
                    DB.Add(new DataBase.Models.Contract()
                    {
                        Idclient = int.Parse(textBoxClient.Text),
                        Vinauto = textBoxVin.Text,
                        Start = dateTimePickerStart.Value.Date,
                        End = dateTimePickerEnd.Value.Date,
                        ActualSurrender = dateTimePickerFact.Value.Date

                    });
                }
                else
                {
                    DB.Add(new DataBase.Models.Contract()
                    {
                        Idclient = int.Parse(textBoxClient.Text),
                        Vinauto = textBoxVin.Text,
                        Start = dateTimePickerStart.Value.Date,
                        End = dateTimePickerEnd.Value.Date
                    });
                }
            }

            if (!MsgBox.DoneContinue())
            {
                Close();
            }

        }

        private void TextChangeDig(Object sender, KeyPressEventArgs e)
        {
            e.CharIsDigitHandled();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerFact.Enabled = checkBox1.Checked;
        }

        private bool CheckInfo()
        {
            if (textBoxClient.Text.Length != 10)
            {
                MsgBox.ErrorShow("Не верный указаны данные серии и номера паспорта");
                return false;
            }
            else if (DB.Find.Client(int.Parse(textBoxClient.Text)) == null)
            {
                MsgBox.ErrorShow("Такого клиента не существует");
                return false;
            }

            if (textBoxVin.Text.Length != 17)
            {
                MsgBox.ErrorShow("Не верный указаны данные VIN");
                return false;
            }
            else if (DB.Find.Car(textBoxVin.Text) == null)
            {
                MsgBox.ErrorShow("Такого клиента не существует");
                return false;
            }

            if (dateTimePickerStart.Value.Date >= dateTimePickerEnd.Value.Date
                || dateTimePickerStart.Value.Date >= dateTimePickerFact.Value.Date)
            {
                MsgBox.ErrorShow("Не верный указаны даты");
                return false;
            }

            return true;
        }
    }
}
