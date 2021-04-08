
namespace KP.Forms
{
    partial class CarsPuckUp
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
            this.textBoxIdContract = new System.Windows.Forms.TextBox();
            this.textBoxAcceptor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonReloadDT = new System.Windows.Forms.Button();
            this.buttonRemoveDT = new System.Windows.Forms.Button();
            this.buttonAddDT = new System.Windows.Forms.Button();
            this.buttonEditDT = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBoxDTName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxAuto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxClient = new System.Windows.Forms.TextBox();
            this.onDone = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonCreateCarPickUp = new System.Windows.Forms.Button();
            this.buttonEditCPU = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "IdContract";
            // 
            // textBoxIdContract
            // 
            this.textBoxIdContract.Location = new System.Drawing.Point(6, 38);
            this.textBoxIdContract.Name = "textBoxIdContract";
            this.textBoxIdContract.Size = new System.Drawing.Size(195, 23);
            this.textBoxIdContract.TabIndex = 1;
            this.textBoxIdContract.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdContract_KeyPress);
            // 
            // textBoxAcceptor
            // 
            this.textBoxAcceptor.Location = new System.Drawing.Point(6, 86);
            this.textBoxAcceptor.Name = "textBoxAcceptor";
            this.textBoxAcceptor.Size = new System.Drawing.Size(195, 23);
            this.textBoxAcceptor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Проверяющий";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата проверки";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(6, 135);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(195, 23);
            this.dateTimePicker.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(447, 169);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonReloadDT);
            this.groupBox1.Controls.Add(this.buttonRemoveDT);
            this.groupBox1.Controls.Add(this.buttonAddDT);
            this.groupBox1.Controls.Add(this.buttonEditDT);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.textBoxPrice);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.textBoxDTName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 353);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DamageType";
            // 
            // buttonReloadDT
            // 
            this.buttonReloadDT.Location = new System.Drawing.Point(362, 266);
            this.buttonReloadDT.Name = "buttonReloadDT";
            this.buttonReloadDT.Size = new System.Drawing.Size(75, 23);
            this.buttonReloadDT.TabIndex = 11;
            this.buttonReloadDT.Text = "Обновить";
            this.buttonReloadDT.UseVisualStyleBackColor = true;
            this.buttonReloadDT.Click += new System.EventHandler(this.buttonReloadDT_Click);
            // 
            // buttonRemoveDT
            // 
            this.buttonRemoveDT.Location = new System.Drawing.Point(362, 302);
            this.buttonRemoveDT.Name = "buttonRemoveDT";
            this.buttonRemoveDT.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveDT.TabIndex = 10;
            this.buttonRemoveDT.Text = "Удалить";
            this.buttonRemoveDT.UseVisualStyleBackColor = true;
            this.buttonRemoveDT.Click += new System.EventHandler(this.buttonRemoveDT_Click);
            // 
            // buttonAddDT
            // 
            this.buttonAddDT.Location = new System.Drawing.Point(362, 207);
            this.buttonAddDT.Name = "buttonAddDT";
            this.buttonAddDT.Size = new System.Drawing.Size(75, 23);
            this.buttonAddDT.TabIndex = 9;
            this.buttonAddDT.Text = "Добавить";
            this.buttonAddDT.UseVisualStyleBackColor = true;
            this.buttonAddDT.Click += new System.EventHandler(this.buttonAddDT_Click);
            // 
            // buttonEditDT
            // 
            this.buttonEditDT.Location = new System.Drawing.Point(362, 236);
            this.buttonEditDT.Name = "buttonEditDT";
            this.buttonEditDT.Size = new System.Drawing.Size(75, 23);
            this.buttonEditDT.TabIndex = 8;
            this.buttonEditDT.Text = "Изменить";
            this.buttonEditDT.UseVisualStyleBackColor = true;
            this.buttonEditDT.Click += new System.EventHandler(this.buttonEditDT_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(189, 210);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(167, 116);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Enabled = false;
            this.textBoxPrice.Location = new System.Drawing.Point(6, 303);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(167, 23);
            this.textBoxPrice.TabIndex = 6;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdContract_KeyPress);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(6, 254);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(167, 23);
            this.numericUpDown1.TabIndex = 5;
            // 
            // textBoxDTName
            // 
            this.textBoxDTName.Enabled = false;
            this.textBoxDTName.Location = new System.Drawing.Point(6, 208);
            this.textBoxDTName.Name = "textBoxDTName";
            this.textBoxDTName.Size = new System.Drawing.Size(167, 23);
            this.textBoxDTName.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(189, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Комментарий";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Цена исправления";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Урон";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Название";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Авто";
            // 
            // textBoxAuto
            // 
            this.textBoxAuto.Location = new System.Drawing.Point(6, 180);
            this.textBoxAuto.Name = "textBoxAuto";
            this.textBoxAuto.Size = new System.Drawing.Size(195, 23);
            this.textBoxAuto.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "Клиент";
            // 
            // textBoxClient
            // 
            this.textBoxClient.Location = new System.Drawing.Point(6, 229);
            this.textBoxClient.Name = "textBoxClient";
            this.textBoxClient.Size = new System.Drawing.Size(195, 23);
            this.textBoxClient.TabIndex = 13;
            // 
            // onDone
            // 
            this.onDone.Location = new System.Drawing.Point(640, 343);
            this.onDone.Name = "onDone";
            this.onDone.Size = new System.Drawing.Size(75, 23);
            this.onDone.TabIndex = 14;
            this.onDone.Text = "Готово";
            this.onDone.UseVisualStyleBackColor = true;
            this.onDone.Click += new System.EventHandler(this.onDone_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonCreateCarPickUp);
            this.groupBox2.Controls.Add(this.buttonEditCPU);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxIdContract);
            this.groupBox2.Controls.Add(this.textBoxClient);
            this.groupBox2.Controls.Add(this.textBoxAcceptor);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxAuto);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dateTimePicker);
            this.groupBox2.Location = new System.Drawing.Point(514, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 298);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CarPickUp";
            // 
            // buttonCreateCarPickUp
            // 
            this.buttonCreateCarPickUp.Location = new System.Drawing.Point(7, 258);
            this.buttonCreateCarPickUp.Name = "buttonCreateCarPickUp";
            this.buttonCreateCarPickUp.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateCarPickUp.TabIndex = 15;
            this.buttonCreateCarPickUp.Text = "Создать";
            this.buttonCreateCarPickUp.UseVisualStyleBackColor = true;
            this.buttonCreateCarPickUp.Click += new System.EventHandler(this.buttonCreateCarPickUp_Click);
            // 
            // buttonEditCPU
            // 
            this.buttonEditCPU.Location = new System.Drawing.Point(126, 258);
            this.buttonEditCPU.Name = "buttonEditCPU";
            this.buttonEditCPU.Size = new System.Drawing.Size(75, 23);
            this.buttonEditCPU.TabIndex = 14;
            this.buttonEditCPU.Text = "Изменить";
            this.buttonEditCPU.UseVisualStyleBackColor = true;
            this.buttonEditCPU.Click += new System.EventHandler(this.buttonEditCPU_Click);
            // 
            // CarsPuckUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 386);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.onDone);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Name = "CarsPuckUp";
            this.Text = "CarsPuckUp";
            this.Load += new System.EventHandler(this.CarsPuckUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIdContract;
        private System.Windows.Forms.TextBox textBoxAcceptor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxDTName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonReloadDT;
        private System.Windows.Forms.Button buttonRemoveDT;
        private System.Windows.Forms.Button buttonAddDT;
        private System.Windows.Forms.Button buttonEditDT;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxAuto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxClient;
        private System.Windows.Forms.Button onDone;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonCreateCarPickUp;
        private System.Windows.Forms.Button buttonEditCPU;
    }
}