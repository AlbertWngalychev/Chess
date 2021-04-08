
namespace KP.Forms
{
    partial class Car
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxVin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxBodyCar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxGovNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownTCoeff = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownTrunk = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownSeats = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownPower = new System.Windows.Forms.NumericUpDown();
            this.checkBoxAutoTrans = new System.Windows.Forms.CheckBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonOFD = new System.Windows.Forms.Button();
            this.checkBoxPetrol = new System.Windows.Forms.CheckBox();
            this.checkBoxFreedom = new System.Windows.Forms.CheckBox();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.richTextBoxPath = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTCoeff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTrunk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPower)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "VIN";
            // 
            // textBoxVin
            // 
            this.textBoxVin.Location = new System.Drawing.Point(13, 32);
            this.textBoxVin.MaxLength = 17;
            this.textBoxVin.Name = "textBoxVin";
            this.textBoxVin.Size = new System.Drawing.Size(121, 23);
            this.textBoxVin.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Модель";
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(13, 80);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(121, 23);
            this.comboBoxModel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Кузов";
            // 
            // comboBoxBodyCar
            // 
            this.comboBoxBodyCar.FormattingEnabled = true;
            this.comboBoxBodyCar.Location = new System.Drawing.Point(13, 129);
            this.comboBoxBodyCar.Name = "comboBoxBodyCar";
            this.comboBoxBodyCar.Size = new System.Drawing.Size(121, 23);
            this.comboBoxBodyCar.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Гос. номер";
            // 
            // textBoxGovNumber
            // 
            this.textBoxGovNumber.Location = new System.Drawing.Point(13, 219);
            this.textBoxGovNumber.MaxLength = 9;
            this.textBoxGovNumber.Name = "textBoxGovNumber";
            this.textBoxGovNumber.Size = new System.Drawing.Size(121, 23);
            this.textBoxGovNumber.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Коэфициент аренды";
            // 
            // numericUpDownTCoeff
            // 
            this.numericUpDownTCoeff.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownTCoeff.Location = new System.Drawing.Point(13, 268);
            this.numericUpDownTCoeff.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTCoeff.Name = "numericUpDownTCoeff";
            this.numericUpDownTCoeff.Size = new System.Drawing.Size(121, 23);
            this.numericUpDownTCoeff.TabIndex = 9;
            this.numericUpDownTCoeff.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Объём багажника";
            // 
            // numericUpDownTrunk
            // 
            this.numericUpDownTrunk.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownTrunk.Location = new System.Drawing.Point(167, 81);
            this.numericUpDownTrunk.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownTrunk.Name = "numericUpDownTrunk";
            this.numericUpDownTrunk.Size = new System.Drawing.Size(127, 23);
            this.numericUpDownTrunk.TabIndex = 11;
            this.numericUpDownTrunk.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Количество мест";
            // 
            // numericUpDownSeats
            // 
            this.numericUpDownSeats.Location = new System.Drawing.Point(14, 312);
            this.numericUpDownSeats.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownSeats.Name = "numericUpDownSeats";
            this.numericUpDownSeats.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownSeats.TabIndex = 13;
            this.numericUpDownSeats.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(167, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Мощность";
            // 
            // numericUpDownPower
            // 
            this.numericUpDownPower.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownPower.Location = new System.Drawing.Point(167, 31);
            this.numericUpDownPower.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPower.Name = "numericUpDownPower";
            this.numericUpDownPower.Size = new System.Drawing.Size(127, 23);
            this.numericUpDownPower.TabIndex = 15;
            this.numericUpDownPower.Value = new decimal(new int[] {
            130,
            0,
            0,
            0});
            // 
            // checkBoxAutoTrans
            // 
            this.checkBoxAutoTrans.AutoSize = true;
            this.checkBoxAutoTrans.Location = new System.Drawing.Point(167, 268);
            this.checkBoxAutoTrans.Name = "checkBoxAutoTrans";
            this.checkBoxAutoTrans.Size = new System.Drawing.Size(72, 19);
            this.checkBoxAutoTrans.TabIndex = 16;
            this.checkBoxAutoTrans.Text = "Автомат";
            this.checkBoxAutoTrans.UseVisualStyleBackColor = true;
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(219, 310);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(75, 23);
            this.buttonDone.TabIndex = 17;
            this.buttonDone.Text = "Готово";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(167, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Путь до изображений";
            // 
            // buttonOFD
            // 
            this.buttonOFD.Location = new System.Drawing.Point(219, 214);
            this.buttonOFD.Name = "buttonOFD";
            this.buttonOFD.Size = new System.Drawing.Size(75, 23);
            this.buttonOFD.TabIndex = 20;
            this.buttonOFD.Text = "Выбрать";
            this.buttonOFD.UseVisualStyleBackColor = true;
            this.buttonOFD.Click += new System.EventHandler(this.buttonOFD_Click);
            // 
            // checkBoxPetrol
            // 
            this.checkBoxPetrol.AutoSize = true;
            this.checkBoxPetrol.Location = new System.Drawing.Point(167, 243);
            this.checkBoxPetrol.Name = "checkBoxPetrol";
            this.checkBoxPetrol.Size = new System.Drawing.Size(65, 19);
            this.checkBoxPetrol.TabIndex = 22;
            this.checkBoxPetrol.Text = "Бензин";
            this.checkBoxPetrol.UseVisualStyleBackColor = true;
            // 
            // checkBoxFreedom
            // 
            this.checkBoxFreedom.AutoSize = true;
            this.checkBoxFreedom.Location = new System.Drawing.Point(167, 290);
            this.checkBoxFreedom.Name = "checkBoxFreedom";
            this.checkBoxFreedom.Size = new System.Drawing.Size(90, 19);
            this.checkBoxFreedom.TabIndex = 23;
            this.checkBoxFreedom.Text = "Свободный";
            this.checkBoxFreedom.UseVisualStyleBackColor = true;
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(14, 173);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(120, 23);
            this.comboBoxColor.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "Цвет";
            // 
            // richTextBoxPath
            // 
            this.richTextBoxPath.Enabled = false;
            this.richTextBoxPath.Location = new System.Drawing.Point(167, 129);
            this.richTextBoxPath.Name = "richTextBoxPath";
            this.richTextBoxPath.Size = new System.Drawing.Size(127, 79);
            this.richTextBoxPath.TabIndex = 26;
            this.richTextBoxPath.Text = "";
            // 
            // Car
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 340);
            this.Controls.Add(this.richTextBoxPath);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.checkBoxFreedom);
            this.Controls.Add(this.checkBoxPetrol);
            this.Controls.Add(this.buttonOFD);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.checkBoxAutoTrans);
            this.Controls.Add(this.numericUpDownPower);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDownSeats);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDownTrunk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownTCoeff);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxGovNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxBodyCar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxVin);
            this.Controls.Add(this.label1);
            this.Name = "Car";
            this.Text = "Car";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTCoeff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTrunk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPower)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxVin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxBodyCar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxGovNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownTCoeff;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownTrunk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownSeats;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownPower;
        private System.Windows.Forms.CheckBox checkBoxAutoTrans;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonOFD;
        private System.Windows.Forms.CheckBox checkBoxPetrol;
        private System.Windows.Forms.CheckBox checkBoxFreedom;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox richTextBoxPath;
    }
}