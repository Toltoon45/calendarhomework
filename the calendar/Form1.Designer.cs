
namespace the_calendar
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonAddCelebration = new System.Windows.Forms.Button();
            this.buttonAddReminder = new System.Windows.Forms.Button();
            this.buttonDeleteReminder = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSaveEditCeleb = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSaveCelebrations = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.buttonShowRemind = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonSaveEditRemind = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonDeleteCeleb = new System.Windows.Forms.Button();
            this.buttonSaveReminds = new System.Windows.Forms.Button();
            this.buttonShowCelebs = new System.Windows.Forms.Button();
            this.buttonAddToEdit = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelTimeYear = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowCheckBox = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.TabStop = false;
            // 
            // buttonAddCelebration
            // 
            this.buttonAddCelebration.Location = new System.Drawing.Point(345, 354);
            this.buttonAddCelebration.Name = "buttonAddCelebration";
            this.buttonAddCelebration.Size = new System.Drawing.Size(117, 43);
            this.buttonAddCelebration.TabIndex = 7;
            this.buttonAddCelebration.Text = "Добавить праздник";
            this.buttonAddCelebration.UseVisualStyleBackColor = true;
            this.buttonAddCelebration.Click += new System.EventHandler(this.buttonAddCelebration_Click);
            // 
            // buttonAddReminder
            // 
            this.buttonAddReminder.Enabled = false;
            this.buttonAddReminder.Location = new System.Drawing.Point(640, 361);
            this.buttonAddReminder.Name = "buttonAddReminder";
            this.buttonAddReminder.Size = new System.Drawing.Size(117, 36);
            this.buttonAddReminder.TabIndex = 8;
            this.buttonAddReminder.Text = "Добавить напоминание";
            this.buttonAddReminder.UseVisualStyleBackColor = true;
            this.buttonAddReminder.Click += new System.EventHandler(this.buttonAddReminder_Click);
            // 
            // buttonDeleteReminder
            // 
            this.buttonDeleteReminder.Enabled = false;
            this.buttonDeleteReminder.Location = new System.Drawing.Point(640, 400);
            this.buttonDeleteReminder.Name = "buttonDeleteReminder";
            this.buttonDeleteReminder.Size = new System.Drawing.Size(117, 36);
            this.buttonDeleteReminder.TabIndex = 9;
            this.buttonDeleteReminder.Text = "Удалить напоминание";
            this.buttonDeleteReminder.UseVisualStyleBackColor = true;
            this.buttonDeleteReminder.Click += new System.EventHandler(this.buttonDeleteReminder_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(218, 39);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(244, 303);
            this.listBox1.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(404, 479);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 20);
            this.textBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 578);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Редактирование";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(325, 575);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(336, 20);
            this.textBox2.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 644);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Чтобы редактировать дату  выберите её выше и нажмите редактировать";
            // 
            // buttonSaveEditCeleb
            // 
            this.buttonSaveEditCeleb.Location = new System.Drawing.Point(325, 671);
            this.buttonSaveEditCeleb.Name = "buttonSaveEditCeleb";
            this.buttonSaveEditCeleb.Size = new System.Drawing.Size(111, 40);
            this.buttonSaveEditCeleb.TabIndex = 19;
            this.buttonSaveEditCeleb.Text = "Сохранить праздник";
            this.buttonSaveEditCeleb.UseVisualStyleBackColor = true;
            this.buttonSaveEditCeleb.Click += new System.EventHandler(this.buttonSaveEditCeleb_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 463);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Название события";
            // 
            // buttonSaveCelebrations
            // 
            this.buttonSaveCelebrations.Location = new System.Drawing.Point(218, 356);
            this.buttonSaveCelebrations.Name = "buttonSaveCelebrations";
            this.buttonSaveCelebrations.Size = new System.Drawing.Size(117, 41);
            this.buttonSaveCelebrations.TabIndex = 23;
            this.buttonSaveCelebrations.Text = "Сохранить все праздники";
            this.buttonSaveCelebrations.UseVisualStyleBackColor = true;
            this.buttonSaveCelebrations.Click += new System.EventHandler(this.button_save_celebrations_Click);
            // 
            // listBox2
            // 
            this.listBox2.Enabled = false;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.Location = new System.Drawing.Point(513, 39);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(244, 303);
            this.listBox2.TabIndex = 25;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Checked = false;
            this.dateTimePicker2.Location = new System.Drawing.Point(763, 87);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowCheckBox = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 26;
            this.dateTimePicker2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(763, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Начальная дата";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(763, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Конечная дата";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Checked = false;
            this.dateTimePicker3.Location = new System.Drawing.Point(766, 176);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.ShowCheckBox = true;
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker3.TabIndex = 29;
            this.dateTimePicker3.TabStop = false;
            // 
            // buttonShowRemind
            // 
            this.buttonShowRemind.Enabled = false;
            this.buttonShowRemind.Location = new System.Drawing.Point(517, 400);
            this.buttonShowRemind.Name = "buttonShowRemind";
            this.buttonShowRemind.Size = new System.Drawing.Size(117, 36);
            this.buttonShowRemind.TabIndex = 31;
            this.buttonShowRemind.Text = "Вывести все напоминания";
            this.buttonShowRemind.UseVisualStyleBackColor = true;
            this.buttonShowRemind.Click += new System.EventHandler(this.buttonShowRemind_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Праздники";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(514, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Напоминания";
            // 
            // buttonSaveEditRemind
            // 
            this.buttonSaveEditRemind.Enabled = false;
            this.buttonSaveEditRemind.Location = new System.Drawing.Point(550, 671);
            this.buttonSaveEditRemind.Name = "buttonSaveEditRemind";
            this.buttonSaveEditRemind.Size = new System.Drawing.Size(111, 40);
            this.buttonSaveEditRemind.TabIndex = 34;
            this.buttonSaveEditRemind.Text = "Сохранить напоминание";
            this.buttonSaveEditRemind.UseVisualStyleBackColor = true;
            this.buttonSaveEditRemind.Click += new System.EventHandler(this.buttonSaveEditRemind_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(458, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(94, 17);
            this.checkBox1.TabIndex = 35;
            this.checkBox1.Text = "Переключить";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonDeleteCeleb
            // 
            this.buttonDeleteCeleb.Location = new System.Drawing.Point(345, 397);
            this.buttonDeleteCeleb.Name = "buttonDeleteCeleb";
            this.buttonDeleteCeleb.Size = new System.Drawing.Size(117, 43);
            this.buttonDeleteCeleb.TabIndex = 36;
            this.buttonDeleteCeleb.Text = "Добавить праздник";
            this.buttonDeleteCeleb.UseVisualStyleBackColor = true;
            this.buttonDeleteCeleb.Click += new System.EventHandler(this.buttonDeleteCeleb_Click);
            // 
            // buttonSaveReminds
            // 
            this.buttonSaveReminds.Enabled = false;
            this.buttonSaveReminds.Location = new System.Drawing.Point(517, 361);
            this.buttonSaveReminds.Name = "buttonSaveReminds";
            this.buttonSaveReminds.Size = new System.Drawing.Size(117, 36);
            this.buttonSaveReminds.TabIndex = 37;
            this.buttonSaveReminds.Text = "Сохранить все напоминания";
            this.buttonSaveReminds.UseVisualStyleBackColor = true;
            this.buttonSaveReminds.Click += new System.EventHandler(this.buttonSaveReminds_Click);
            // 
            // buttonShowCelebs
            // 
            this.buttonShowCelebs.Location = new System.Drawing.Point(218, 398);
            this.buttonShowCelebs.Name = "buttonShowCelebs";
            this.buttonShowCelebs.Size = new System.Drawing.Size(117, 41);
            this.buttonShowCelebs.TabIndex = 38;
            this.buttonShowCelebs.Text = "Показать все праздники";
            this.buttonShowCelebs.UseVisualStyleBackColor = true;
            this.buttonShowCelebs.Click += new System.EventHandler(this.buttonShowCelebs_Click);
            // 
            // buttonAddToEdit
            // 
            this.buttonAddToEdit.Location = new System.Drawing.Point(427, 601);
            this.buttonAddToEdit.Name = "buttonAddToEdit";
            this.buttonAddToEdit.Size = new System.Drawing.Size(111, 40);
            this.buttonAddToEdit.TabIndex = 39;
            this.buttonAddToEdit.Text = "Добавить для редактирования";
            this.buttonAddToEdit.UseVisualStyleBackColor = true;
            this.buttonAddToEdit.Click += new System.EventHandler(this.buttonAddToEdit_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(103, 160);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(35, 13);
            this.labelTime.TabIndex = 40;
            this.labelTime.Text = "label8";
            // 
            // labelTimeYear
            // 
            this.labelTimeYear.AutoSize = true;
            this.labelTimeYear.Location = new System.Drawing.Point(103, 183);
            this.labelTimeYear.Name = "labelTimeYear";
            this.labelTimeYear.Size = new System.Drawing.Size(35, 13);
            this.labelTimeYear.TabIndex = 41;
            this.labelTimeYear.Text = "label8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Время";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Дата";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 723);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelTimeYear);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonAddToEdit);
            this.Controls.Add(this.buttonShowCelebs);
            this.Controls.Add(this.buttonSaveReminds);
            this.Controls.Add(this.buttonDeleteCeleb);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buttonSaveEditRemind);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonShowRemind);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.buttonSaveCelebrations);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSaveEditCeleb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonDeleteReminder);
            this.Controls.Add(this.buttonAddReminder);
            this.Controls.Add(this.buttonAddCelebration);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonAddCelebration;
        private System.Windows.Forms.Button buttonAddReminder;
        private System.Windows.Forms.Button buttonDeleteReminder;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSaveEditCeleb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSaveCelebrations;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Button buttonShowRemind;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonSaveEditRemind;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonDeleteCeleb;
        private System.Windows.Forms.Button buttonSaveReminds;
        private System.Windows.Forms.Button buttonShowCelebs;
        private System.Windows.Forms.Button buttonAddToEdit;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelTimeYear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

