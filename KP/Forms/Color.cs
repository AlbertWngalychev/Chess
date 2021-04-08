using KP.DataBase;
using KP.Extension;
using System;
using System.Windows.Forms;

namespace KP.Forms
{
    public partial class Color : Form
    {
        private byte r = 0;
        private byte g = 0;
        private byte b = 0;
        private readonly DataBase.Models.Color color;

        public Color()
        {
            InitializeComponent();
        }

        public Color(int id)
            : this()
        {
            color = DB.Find.Color(id);

            textBoxName.Text = color.Name;

            textBoxR.Text = color.Red.ToString();
            r = byte.Parse(color.Red.ToString());

            textBoxG.Text = color.Green.ToString();
            g = byte.Parse(color.Green.ToString());

            textBoxB.Text = color.Blue.ToString();
            b = byte.Parse(color.Blue.ToString());

            checkBoxMetallic.Checked = color.Metallic;

            changeBackColor();
        }


        private void buttonDone_Click(object sender, EventArgs e)
        {
            if (color == null)
            {
                DB.Add(new DataBase.Models.Color()
                {
                    Name = textBoxName.Text,
                    Metallic = checkBoxMetallic.Checked,
                    Red = r,
                    Green = g,
                    Blue = b
                });
            }
            else
            {
                DB.Edit.Color(color.Id, new DataBase.Models.Color()
                {
                    Name = textBoxName.Text,
                    Metallic = checkBoxMetallic.Checked,
                    Red = r,
                    Green = g,
                    Blue = b
                });
            }

            if (!MsgBox.DoneContinue())
            {
                Close();
            }
        }

        private void textBoxR_TextChanged(object sender, EventArgs e)
        {
            checkTextBox(textBoxR, ref r);

            changeBackColor();
        }
        private void textBoxG_TextChanged(object sender, EventArgs e)
        {
            checkTextBox(textBoxG, ref g);

            changeBackColor();
        }
        private void textBoxB_TextChanged(object sender, EventArgs e)
        {
            checkTextBox(textBoxB, ref b);

            changeBackColor();
        }

        private void changeBackColor()
        {
            panel1.BackColor = System.Drawing.Color.FromArgb(r, g, b);
        }

        private void checkTextBox(TextBox tb, ref byte rgb)
        {
            if (!(tb.Text == ""))
            {
                int temp = int.Parse(tb.Text);

                if (temp > 255)
                {
                    rgb = 255;
                    tb.Text = "255";
                }
                else if (temp < 0)
                {
                    rgb = 0;
                    tb.Text = "0";
                }
                else
                {
                    rgb = byte.Parse(tb.Text);
                }
            }
            else
            {
                rgb = 0;
            }

        }

        private void textBoxRGD_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.CharIsDigitHandled();
        }

        private void Color_Load(object sender, EventArgs e)
        {
            textBoxG.TextChanged += new System.EventHandler(textBoxR_TextChanged);
            textBoxR.TextChanged += new System.EventHandler(textBoxG_TextChanged);
            textBoxB.TextChanged += new System.EventHandler(textBoxB_TextChanged);
            MaximizeBox = false;
            MaximumSize = Size;
            MinimumSize = Size;
        }
    }
}
