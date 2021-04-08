using KP.DataBase;
using KP.Extension;
using System;
using System.Windows.Forms;

namespace KP.Forms
{
    public partial class BodyCar : Form
    {
        private readonly DataBase.Models.BodyCar bodyCar;

        public BodyCar()
        {
            InitializeComponent();
            MaximizeBox = false;
            MaximumSize = Size;
            MinimumSize = Size;
        }

        public BodyCar(DataBase.Models.BodyCar bodyCar)
            : this()
        {
            this.bodyCar = bodyCar;
            textBoxName.Text = bodyCar.Name;
            checkBoxClosed.Checked = bodyCar.Closed;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MsgBox.ErrorShow("Неверное имя");
                return;
            }

            if (bodyCar == null)
            {
                DB.Add(new DataBase.Models.BodyCar()
                {
                    Name = textBoxName.Text,
                    Closed = checkBoxClosed.Checked
                });
            }
            else
            {
                DB.Edit.BodyCar(bodyCar.Id, new DataBase.Models.BodyCar()
                {
                    Name = textBoxName.Text,
                    Closed = checkBoxClosed.Checked
                });
            }

            if (!MsgBox.DoneContinue())
            {
                Close();
            }
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.CharIsLetterHandled();
        }
    }
}
