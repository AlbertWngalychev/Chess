using KP.DataBase;
using KP.DataBase.Models;
using KP.Extension;
using System;
using System.Windows.Forms;

namespace KP.Forms
{
    public partial class AddEditClient : Form
    {
        private readonly Client client;

        public AddEditClient()
        {
            InitializeComponent();

            MaximizeBox = false;
            MaximumSize = Size;
            MinimumSize = Size;
            textBoxSNPasport.Enabled = true;
        }

        public AddEditClient(int snpasportEditClient)
            : this()
        {
            client = DB.Find.Client(snpasportEditClient);

            if (client != null)
            {

                textBoxName.Text = client.Name;
                textBoxLName.Text = client.Lname;
                textBoxSName.Text = client.Sname;
                textBoxDriverL.Text = client.DriverLicense.ToString();
                textBoxSNPasport.Text = client.Snpasport.ToString();

                dateTimePickerDL.Value = client.StartTimeDl.Date;

                textBoxSNPasport.Enabled = false;
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            if (!checkTextBox())
            {
                return;
            }

            if (client == null)
            {
                DB.Add(new Client()
                {
                    Snpasport = int.Parse(textBoxSNPasport.Text),
                    Sname = textBoxSName.Text,
                    Name = textBoxName.Text,
                    Lname = textBoxLName.Text,
                    DriverLicense = int.Parse(textBoxDriverL.Text),
                    StartTimeDl = dateTimePickerDL.Value.Date
                });
            }
            else
            {
                DB.Edit.Client(client.Snpasport, new Client()
                {
                    Sname = textBoxSName.Text,
                    Name = textBoxName.Text,
                    Lname = textBoxLName.Text,
                    DriverLicense = int.Parse(textBoxDriverL.Text),
                    StartTimeDl = dateTimePickerDL.Value.Date
                });
            }

            if (!MsgBox.DoneContinue())
            {
                Close();
            }
        }

        private void textBoxSNPasport_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.CharIsDigitHandled();
        }

        private void keyPressLetter(object sender, KeyPressEventArgs e)
        {
            e.CharIsLetterHandled();
        }

        private bool checkTextBox()
        {
            if (textBoxSNPasport.Text.Length != 10)
            {
                MsgBox.ErrorShow("Неправильно введены серия и номер паспорта.");
                return false;
            }
            else if (textBoxDriverL.Text.Length != 10)
            {
                MsgBox.ErrorShow("Неправильно введены серия и номер ВУ.");
                return false;
            }
            else if (textBoxSName.Text.Length < 2 || textBoxName.Text.Length < 3 || textBoxLName.Text.Length < 4)
            {

                MsgBox.ErrorShow("Неверные Фамилия и/или Имя и/или Очество");
                return false;
            }
            else if (dateTimePickerDL.Value.Date > DateTime.Now.Date)
            {

                MsgBox.ErrorShow("Неверная дата выдачи ВУ.");
                return false;
            }

            return true;
        }
    }

}
