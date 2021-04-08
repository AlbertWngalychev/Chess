
namespace KP.Forms
{
    partial class Model
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
            this.textBoxManuf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxClass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPrice1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPrice2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPrice3 = new System.Windows.Forms.TextBox();
            this.textBoxPrice4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Производитель";
            // 
            // textBoxManuf
            // 
            this.textBoxManuf.Location = new System.Drawing.Point(13, 32);
            this.textBoxManuf.MaxLength = 50;
            this.textBoxManuf.Name = "textBoxManuf";
            this.textBoxManuf.Size = new System.Drawing.Size(185, 23);
            this.textBoxManuf.TabIndex = 1;
            this.textBoxManuf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxManuf_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(13, 81);
            this.textBoxName.MaxLength = 50;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(133, 23);
            this.textBoxName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Класс";
            // 
            // textBoxClass
            // 
            this.textBoxClass.Location = new System.Drawing.Point(160, 81);
            this.textBoxClass.MaxLength = 3;
            this.textBoxClass.Name = "textBoxClass";
            this.textBoxClass.Size = new System.Drawing.Size(38, 23);
            this.textBoxClass.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Цена за месяц";
            // 
            // textBoxPrice1
            // 
            this.textBoxPrice1.Location = new System.Drawing.Point(13, 130);
            this.textBoxPrice1.Name = "textBoxPrice1";
            this.textBoxPrice1.Size = new System.Drawing.Size(185, 23);
            this.textBoxPrice1.TabIndex = 7;
            this.textBoxPrice1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressDecimal);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Цена от 1 до 6 месяцев";
            // 
            // textBoxPrice2
            // 
            this.textBoxPrice2.Location = new System.Drawing.Point(13, 179);
            this.textBoxPrice2.Name = "textBoxPrice2";
            this.textBoxPrice2.Size = new System.Drawing.Size(185, 23);
            this.textBoxPrice2.TabIndex = 9;
            this.textBoxPrice2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressDecimal);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Цена от 6 до 12 месяцев";
            // 
            // textBoxPrice3
            // 
            this.textBoxPrice3.Location = new System.Drawing.Point(13, 228);
            this.textBoxPrice3.Name = "textBoxPrice3";
            this.textBoxPrice3.Size = new System.Drawing.Size(185, 23);
            this.textBoxPrice3.TabIndex = 11;
            this.textBoxPrice3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressDecimal);
            // 
            // textBoxPrice4
            // 
            this.textBoxPrice4.Location = new System.Drawing.Point(13, 276);
            this.textBoxPrice4.Name = "textBoxPrice4";
            this.textBoxPrice4.Size = new System.Drawing.Size(185, 23);
            this.textBoxPrice4.TabIndex = 12;
            this.textBoxPrice4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressDecimal);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Цена от 1 года";
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(123, 305);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(75, 23);
            this.buttonDone.TabIndex = 14;
            this.buttonDone.Text = "Готово";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // Model
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 338);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxPrice4);
            this.Controls.Add(this.textBoxPrice3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPrice2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPrice1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxClass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxManuf);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(231, 373);
            this.MinimumSize = new System.Drawing.Size(231, 373);
            this.Name = "Model";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Model";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxManuf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPrice1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPrice2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPrice3;
        private System.Windows.Forms.TextBox textBoxPrice4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonDone;
    }
}