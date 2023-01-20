namespace project
{
    partial class Form1
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
            this.buttonLoad1 = new System.Windows.Forms.Button();
            this.btn_chooseReference1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_SplitAndCount = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label_mainFileName = new System.Windows.Forms.Label();
            this.label_referenceName1 = new System.Windows.Forms.Label();
            this.labelResult1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelResult2 = new System.Windows.Forms.Label();
            this.labelResult3 = new System.Windows.Forms.Label();
            this.btn_chooseReference2 = new System.Windows.Forms.Button();
            this.btn_chooseReference3 = new System.Windows.Forms.Button();
            this.label_referenceName2 = new System.Windows.Forms.Label();
            this.label_referenceName3 = new System.Windows.Forms.Label();
            this.richTextBox_textMain = new System.Windows.Forms.RichTextBox();
            this.btn_clearMain = new System.Windows.Forms.Button();
            this.btn_clearReference1 = new System.Windows.Forms.Button();
            this.btn_clearReference2 = new System.Windows.Forms.Button();
            this.btn_clearReference3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLoad1
            // 
            this.buttonLoad1.Location = new System.Drawing.Point(12, 28);
            this.buttonLoad1.Name = "buttonLoad1";
            this.buttonLoad1.Size = new System.Drawing.Size(94, 23);
            this.buttonLoad1.TabIndex = 0;
            this.buttonLoad1.Text = "Выбрать файл";
            this.buttonLoad1.UseVisualStyleBackColor = true;
            this.buttonLoad1.Click += new System.EventHandler(this.ButtonLoad1_Click);
            // 
            // btn_chooseReference1
            // 
            this.btn_chooseReference1.Location = new System.Drawing.Point(288, 28);
            this.btn_chooseReference1.Name = "btn_chooseReference1";
            this.btn_chooseReference1.Size = new System.Drawing.Size(94, 23);
            this.btn_chooseReference1.TabIndex = 1;
            this.btn_chooseReference1.Text = "Выбрать файл";
            this.btn_chooseReference1.UseVisualStyleBackColor = true;
            this.btn_chooseReference1.Click += new System.EventHandler(this.btn_chooseReference1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Перевод";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Эталоны";
            // 
            // btn_SplitAndCount
            // 
            this.btn_SplitAndCount.Location = new System.Drawing.Point(381, 142);
            this.btn_SplitAndCount.Name = "btn_SplitAndCount";
            this.btn_SplitAndCount.Size = new System.Drawing.Size(75, 23);
            this.btn_SplitAndCount.TabIndex = 4;
            this.btn_SplitAndCount.Text = "Сравнить";
            this.btn_SplitAndCount.UseVisualStyleBackColor = true;
            this.btn_SplitAndCount.Click += new System.EventHandler(this.btn_SplitAndCount_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Перевод соответствует эталону №1 на ";
            // 
            // label_mainFileName
            // 
            this.label_mainFileName.AutoSize = true;
            this.label_mainFileName.Location = new System.Drawing.Point(112, 33);
            this.label_mainFileName.Name = "label_mainFileName";
            this.label_mainFileName.Size = new System.Drawing.Size(101, 13);
            this.label_mainFileName.TabIndex = 11;
            this.label_mainFileName.Text = "Название файла...";
            // 
            // label_referenceName1
            // 
            this.label_referenceName1.AutoSize = true;
            this.label_referenceName1.Location = new System.Drawing.Point(388, 33);
            this.label_referenceName1.Name = "label_referenceName1";
            this.label_referenceName1.Size = new System.Drawing.Size(101, 13);
            this.label_referenceName1.TabIndex = 12;
            this.label_referenceName1.Text = "Название файла...";
            // 
            // labelResult1
            // 
            this.labelResult1.AutoSize = true;
            this.labelResult1.Location = new System.Drawing.Point(494, 168);
            this.labelResult1.Name = "labelResult1";
            this.labelResult1.Size = new System.Drawing.Size(39, 13);
            this.labelResult1.TabIndex = 13;
            this.labelResult1.Text = "0.00 %";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Перевод соответствует эталону №2 на ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(289, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(208, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Перевод соответствует эталону №3 на ";
            // 
            // labelResult2
            // 
            this.labelResult2.AutoSize = true;
            this.labelResult2.Location = new System.Drawing.Point(494, 193);
            this.labelResult2.Name = "labelResult2";
            this.labelResult2.Size = new System.Drawing.Size(39, 13);
            this.labelResult2.TabIndex = 16;
            this.labelResult2.Text = "0.00 %";
            // 
            // labelResult3
            // 
            this.labelResult3.AutoSize = true;
            this.labelResult3.Location = new System.Drawing.Point(494, 218);
            this.labelResult3.Name = "labelResult3";
            this.labelResult3.Size = new System.Drawing.Size(39, 13);
            this.labelResult3.TabIndex = 17;
            this.labelResult3.Text = "0.00 %";
            // 
            // btn_chooseReference2
            // 
            this.btn_chooseReference2.Location = new System.Drawing.Point(288, 58);
            this.btn_chooseReference2.Name = "btn_chooseReference2";
            this.btn_chooseReference2.Size = new System.Drawing.Size(94, 23);
            this.btn_chooseReference2.TabIndex = 18;
            this.btn_chooseReference2.Text = "Выбрать файл";
            this.btn_chooseReference2.UseVisualStyleBackColor = true;
            this.btn_chooseReference2.Click += new System.EventHandler(this.btn_chooseReference2_Click);
            // 
            // btn_chooseReference3
            // 
            this.btn_chooseReference3.Location = new System.Drawing.Point(288, 88);
            this.btn_chooseReference3.Name = "btn_chooseReference3";
            this.btn_chooseReference3.Size = new System.Drawing.Size(94, 23);
            this.btn_chooseReference3.TabIndex = 19;
            this.btn_chooseReference3.Text = "Выбрать файл";
            this.btn_chooseReference3.UseVisualStyleBackColor = true;
            this.btn_chooseReference3.Click += new System.EventHandler(this.btn_chooseReference3_Click);
            // 
            // label_referenceName2
            // 
            this.label_referenceName2.AutoSize = true;
            this.label_referenceName2.Location = new System.Drawing.Point(388, 63);
            this.label_referenceName2.Name = "label_referenceName2";
            this.label_referenceName2.Size = new System.Drawing.Size(101, 13);
            this.label_referenceName2.TabIndex = 20;
            this.label_referenceName2.Text = "Название файла...";
            // 
            // label_referenceName3
            // 
            this.label_referenceName3.AutoSize = true;
            this.label_referenceName3.Location = new System.Drawing.Point(388, 93);
            this.label_referenceName3.Name = "label_referenceName3";
            this.label_referenceName3.Size = new System.Drawing.Size(101, 13);
            this.label_referenceName3.TabIndex = 21;
            this.label_referenceName3.Text = "Название файла...";
            // 
            // richTextBox_textMain
            // 
            this.richTextBox_textMain.Location = new System.Drawing.Point(15, 58);
            this.richTextBox_textMain.Name = "richTextBox_textMain";
            this.richTextBox_textMain.ReadOnly = true;
            this.richTextBox_textMain.Size = new System.Drawing.Size(266, 195);
            this.richTextBox_textMain.TabIndex = 22;
            this.richTextBox_textMain.Text = "";
            // 
            // btn_clearMain
            // 
            this.btn_clearMain.Location = new System.Drawing.Point(219, 28);
            this.btn_clearMain.Name = "btn_clearMain";
            this.btn_clearMain.Size = new System.Drawing.Size(63, 23);
            this.btn_clearMain.TabIndex = 23;
            this.btn_clearMain.Text = "Очистить";
            this.btn_clearMain.UseVisualStyleBackColor = true;
            this.btn_clearMain.Click += new System.EventHandler(this.btn_clearMain_Click);
            // 
            // btn_clearReference1
            // 
            this.btn_clearReference1.Location = new System.Drawing.Point(495, 29);
            this.btn_clearReference1.Name = "btn_clearReference1";
            this.btn_clearReference1.Size = new System.Drawing.Size(62, 23);
            this.btn_clearReference1.TabIndex = 24;
            this.btn_clearReference1.Text = "Очистить";
            this.btn_clearReference1.UseVisualStyleBackColor = true;
            this.btn_clearReference1.Click += new System.EventHandler(this.btn_clearReference1_Click);
            // 
            // btn_clearReference2
            // 
            this.btn_clearReference2.Location = new System.Drawing.Point(495, 58);
            this.btn_clearReference2.Name = "btn_clearReference2";
            this.btn_clearReference2.Size = new System.Drawing.Size(62, 23);
            this.btn_clearReference2.TabIndex = 25;
            this.btn_clearReference2.Text = "Очистить";
            this.btn_clearReference2.UseVisualStyleBackColor = true;
            this.btn_clearReference2.Click += new System.EventHandler(this.btn_clearReference2_Click);
            // 
            // btn_clearReference3
            // 
            this.btn_clearReference3.Location = new System.Drawing.Point(495, 87);
            this.btn_clearReference3.Name = "btn_clearReference3";
            this.btn_clearReference3.Size = new System.Drawing.Size(62, 23);
            this.btn_clearReference3.TabIndex = 26;
            this.btn_clearReference3.Text = "Очистить";
            this.btn_clearReference3.UseVisualStyleBackColor = true;
            this.btn_clearReference3.Click += new System.EventHandler(this.btn_clearReference3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 263);
            this.Controls.Add(this.btn_clearReference3);
            this.Controls.Add(this.btn_clearReference2);
            this.Controls.Add(this.btn_clearReference1);
            this.Controls.Add(this.btn_clearMain);
            this.Controls.Add(this.richTextBox_textMain);
            this.Controls.Add(this.label_referenceName3);
            this.Controls.Add(this.label_referenceName2);
            this.Controls.Add(this.btn_chooseReference3);
            this.Controls.Add(this.btn_chooseReference2);
            this.Controls.Add(this.labelResult3);
            this.Controls.Add(this.labelResult2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelResult1);
            this.Controls.Add(this.label_referenceName1);
            this.Controls.Add(this.label_mainFileName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_SplitAndCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_chooseReference1);
            this.Controls.Add(this.buttonLoad1);
            this.Name = "Form1";
            this.Text = "Сравнение текстовых файлов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoad1;
        private System.Windows.Forms.Button btn_chooseReference1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_SplitAndCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_mainFileName;
        private System.Windows.Forms.Label label_referenceName1;
        private System.Windows.Forms.Label labelResult1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelResult2;
        private System.Windows.Forms.Label labelResult3;
        private System.Windows.Forms.Button btn_chooseReference2;
        private System.Windows.Forms.Button btn_chooseReference3;
        private System.Windows.Forms.Label label_referenceName2;
        private System.Windows.Forms.Label label_referenceName3;
        private System.Windows.Forms.RichTextBox richTextBox_textMain;
        private System.Windows.Forms.Button btn_clearMain;
        private System.Windows.Forms.Button btn_clearReference1;
        private System.Windows.Forms.Button btn_clearReference2;
        private System.Windows.Forms.Button btn_clearReference3;
    }
}

