
namespace KP.Forms
{
    partial class Color
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.checkBoxMetallic = new System.Windows.Forms.CheckBox();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.textBoxG = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxMetalic = new System.Windows.Forms.CheckBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(13, 30);
            this.textBoxName.MaxLength = 50;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(240, 23);
            this.textBoxName.TabIndex = 0;
            // 
            // checkBoxMetallic
            // 
            this.checkBoxMetallic.AutoSize = true;
            this.checkBoxMetallic.Location = new System.Drawing.Point(13, 60);
            this.checkBoxMetallic.Name = "checkBoxMetallic";
            this.checkBoxMetallic.Size = new System.Drawing.Size(74, 19);
            this.checkBoxMetallic.TabIndex = 1;
            this.checkBoxMetallic.Text = "Металик";
            this.checkBoxMetallic.UseVisualStyleBackColor = true;
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(13, 100);
            this.textBoxR.MaxLength = 3;
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(24, 23);
            this.textBoxR.TabIndex = 2;
            this.textBoxR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRGD_KeyPress);
            // 
            // textBoxG
            // 
            this.textBoxG.Location = new System.Drawing.Point(43, 100);
            this.textBoxG.MaxLength = 3;
            this.textBoxG.Name = "textBoxG";
            this.textBoxG.Size = new System.Drawing.Size(23, 23);
            this.textBoxG.TabIndex = 3;
            this.textBoxG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRGD_KeyPress);
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(72, 100);
            this.textBoxB.MaxLength = 3;
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(24, 23);
            this.textBoxB.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Цвет в RGB:";
            // 
            // checkBoxMetalic
            // 
            this.checkBoxMetalic.AutoSize = true;
            this.checkBoxMetalic.Location = new System.Drawing.Point(42, 89);
            this.checkBoxMetalic.Name = "checkBoxMetalic";
            this.checkBoxMetalic.Size = new System.Drawing.Size(83, 19);
            this.checkBoxMetalic.TabIndex = 1;
            this.checkBoxMetalic.Text = "Металик";
            this.checkBoxMetalic.UseVisualStyleBackColor = true;
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(169, 100);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(84, 23);
            this.buttonDone.TabIndex = 7;
            this.buttonDone.Text = "Готово";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(102, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(61, 62);
            this.panel1.TabIndex = 8;
            // 
            // Color
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 129);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxG);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.checkBoxMetallic);
            this.Controls.Add(this.textBoxName);
            this.Name = "Color";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color";
            this.Load += new System.EventHandler(this.Color_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.CheckBox checkBoxMetallic;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.TextBox textBoxG;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxMetalic;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Panel panel1;
    }
}