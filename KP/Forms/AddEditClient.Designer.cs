
namespace KP.Forms
{
    partial class AddEditClient
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
            this.textBoxSNPasport = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSName = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.textBoxDriverL = new System.Windows.Forms.TextBox();
            this.dateTimePickerDL = new System.Windows.Forms.DateTimePicker();
            this.buttonDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSNPasport
            // 
            this.textBoxSNPasport.Location = new System.Drawing.Point(108, 13);
            this.textBoxSNPasport.MaxLength = 10;
            this.textBoxSNPasport.Name = "textBoxSNPasport";
            this.textBoxSNPasport.Size = new System.Drawing.Size(202, 23);
            this.textBoxSNPasport.TabIndex = 0;
            this.textBoxSNPasport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSNPasport_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Серия и номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Очество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Номер ВУ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Дата выдачи";
            // 
            // textBoxSName
            // 
            this.textBoxSName.Location = new System.Drawing.Point(108, 42);
            this.textBoxSName.MaxLength = 50;
            this.textBoxSName.Name = "textBoxSName";
            this.textBoxSName.Size = new System.Drawing.Size(202, 23);
            this.textBoxSName.TabIndex = 7;
            this.textBoxSName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressLetter);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(108, 71);
            this.textBoxName.MaxLength = 50;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(202, 23);
            this.textBoxName.TabIndex = 8;
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressLetter);
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(108, 100);
            this.textBoxLName.MaxLength = 50;
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(202, 23);
            this.textBoxLName.TabIndex = 9;
            this.textBoxLName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressLetter);
            // 
            // textBoxDriverL
            // 
            this.textBoxDriverL.Location = new System.Drawing.Point(108, 131);
            this.textBoxDriverL.MaxLength = 10;
            this.textBoxDriverL.Name = "textBoxDriverL";
            this.textBoxDriverL.Size = new System.Drawing.Size(202, 23);
            this.textBoxDriverL.TabIndex = 10;
            this.textBoxDriverL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSNPasport_KeyPress);
            // 
            // dateTimePickerDL
            // 
            this.dateTimePickerDL.Location = new System.Drawing.Point(108, 161);
            this.dateTimePickerDL.Name = "dateTimePickerDL";
            this.dateTimePickerDL.Size = new System.Drawing.Size(202, 23);
            this.dateTimePickerDL.TabIndex = 11;
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(234, 191);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(75, 23);
            this.buttonDone.TabIndex = 12;
            this.buttonDone.Text = "Готово";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // AddEditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(322, 232);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.dateTimePickerDL);
            this.Controls.Add(this.textBoxDriverL);
            this.Controls.Add(this.textBoxLName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxSName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSNPasport);
            this.Name = "AddEditClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSNPasport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.TextBox textBoxDriverL;
        private System.Windows.Forms.DateTimePicker dateTimePickerDL;
        private System.Windows.Forms.Button buttonDone;
    }
}