using KP.DataBase;
using KP.Extension;
using System;
using System.Windows.Forms;

namespace KP.Forms
{
    public partial class Model : Form
    {
        private readonly DataBase.Models.Model model;

        public Model()
        {
            InitializeComponent();
        }

        public Model(DataBase.Models.Model model)
            : this()
        {
            this.model = model;

            textBoxClass.Text = model.Class;
            textBoxManuf.Text = model.Manufacturer;
            textBoxName.Text = model.Name;
            textBoxPrice1.Text = model.PriceIn1moth.ToString();
            textBoxPrice2.Text = model.PriceUpto6mth.ToString();
            textBoxPrice3.Text = model.PriceUpto1year.ToString();
            textBoxPrice4.Text = model.PriceFrom1year.ToString();
        }

        private void KeyPressDecimal(object sender, KeyPressEventArgs e)
        {
            e.CharIsDigitHandled();
        }

        private void textBoxManuf_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.CharIsLetterHandled();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxManuf.Text) || String.IsNullOrEmpty(textBoxName.Text))
            {
                MsgBox.ErrorShow("Не правильно введены поля");
                return;
            }

            if (model != null)
            {
                DB.Edit.Model(model.Id, new DataBase.Models.Model()
                {
                    Name = textBoxName.Text,
                    Manufacturer = textBoxManuf.Text,
                    Class = textBoxClass.Text,
                    PriceIn1moth = decimal.Parse(textBoxPrice1.Text),
                    PriceUpto6mth = decimal.Parse(textBoxPrice2.Text),
                    PriceUpto1year = decimal.Parse(textBoxPrice3.Text),
                    PriceFrom1year = decimal.Parse(textBoxPrice4.Text)
                });
            }
            else
            {
                DB.Add(new DataBase.Models.Model()
                {
                    Name = textBoxName.Text,
                    Manufacturer = textBoxManuf.Text,
                    Class = textBoxClass.Text,
                    PriceIn1moth = decimal.Parse(textBoxPrice1.Text),
                    PriceUpto6mth = decimal.Parse(textBoxPrice2.Text),
                    PriceUpto1year = decimal.Parse(textBoxPrice3.Text),
                    PriceFrom1year = decimal.Parse(textBoxPrice4.Text),
                });
            }

            if (!MsgBox.DoneContinue())
            {
                Close();
            }
        }
    }
}
