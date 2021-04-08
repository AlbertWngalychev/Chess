using System;
using System.Windows.Forms;

namespace KP.Forms
{
    public partial class DamageType : Form
    {
        DataBase.Models.DamageType dt;
        DataBase.Models.CarPickup cpu;
        public DamageType(DataBase.Models.CarPickup cpu = null)
        {
            InitializeComponent();
            this.cpu = cpu;
        }
        public DamageType(int id, DataBase.Models.CarPickup cpu = null)
            : this(cpu)
        {
            dt = DataBase.DB.Find.DamageType(id);
            textBoxDTName.Text = dt.Name;
            textBoxPrice.Text = dt.FixPrice.ToString();
            numericUpDown1.Value = (decimal)dt.Damage;
            richTextBox1.Text = dt.Comment;
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Extension.KeyPressExtension.CharIsDigitHandled(e);
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            if (dt == null)
            {
                DataBase.DB.AddDamageType(cpu, new DataBase.Models.DamageType()
                {
                    Name = textBoxDTName.Text,
                    Damage = (double)numericUpDown1.Value,
                    Comment = richTextBox1.Text,
                    FixPrice = int.Parse(textBoxPrice.Text)
                });
            }
            else
            {
                DataBase.DB.Edit.DamageType(dt.Id, new DataBase.Models.DamageType()
                {
                    Name = textBoxDTName.Text,
                    Damage = (double)numericUpDown1.Value,
                    Comment = richTextBox1.Text,
                    FixPrice = int.Parse(textBoxPrice.Text)
                });
            }

            if (!Extension.MsgBox.DoneContinue())
            {
                this.Close();
            }
        }
    }
}
