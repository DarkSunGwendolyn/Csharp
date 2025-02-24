namespace Lab1
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
            this.greetings = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.NumericUpDown();
            this.name = new System.Windows.Forms.TextBox();
            this.completedOrders = new System.Windows.Forms.NumericUpDown();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.enter = new System.Windows.Forms.Button();
            this.transportedMass = new System.Windows.Forms.NumericUpDown();
            this.rating = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.objCount = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.completedOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportedMass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rating)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // greetings
            // 
            this.greetings.AutoSize = true;
            this.greetings.Location = new System.Drawing.Point(295, 9);
            this.greetings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.greetings.Name = "greetings";
            this.greetings.Size = new System.Drawing.Size(322, 75);
            this.greetings.TabIndex = 0;
            this.greetings.Text = "Лабораторная работа № 2. Класс. Статические члены\nкласса. Обработка исключений.\nГ" +
    "руппа: 23ВП2.\nСостав бригады: Соколов, Муравьев.\nВариант 8. Фирма грузоперевозок" +
    "";
            this.greetings.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Оплата\nперевозки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Масса перевезенных\nгрузов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Название\nфирмы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Рейтинг";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(458, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "Количество выполненных\nзаказов";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(635, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 30);
            this.label6.TabIndex = 6;
            this.label6.Text = "Номер\nфирмы";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(785, 39);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 30);
            this.label7.TabIndex = 7;
            this.label7.Text = "Почта\nфирмы";
            // 
            // price
            // 
            this.price.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.price.Location = new System.Drawing.Point(18, 67);
            this.price.Margin = new System.Windows.Forms.Padding(2);
            this.price.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(93, 20);
            this.price.TabIndex = 8;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(256, 67);
            this.name.Margin = new System.Windows.Forms.Padding(2);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(97, 20);
            this.name.TabIndex = 10;
            // 
            // completedOrders
            // 
            this.completedOrders.Location = new System.Drawing.Point(460, 67);
            this.completedOrders.Margin = new System.Windows.Forms.Padding(2);
            this.completedOrders.Name = "completedOrders";
            this.completedOrders.Size = new System.Drawing.Size(93, 20);
            this.completedOrders.TabIndex = 12;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Location = new System.Drawing.Point(600, 67);
            this.phoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(114, 20);
            this.phoneNumber.TabIndex = 13;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(746, 67);
            this.email.Margin = new System.Windows.Forms.Padding(2);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(123, 20);
            this.email.TabIndex = 14;
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(711, 126);
            this.enter.Margin = new System.Windows.Forms.Padding(2);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(161, 37);
            this.enter.TabIndex = 15;
            this.enter.Text = "Создать";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // transportedMass
            // 
            this.transportedMass.DecimalPlaces = 1;
            this.transportedMass.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.transportedMass.Location = new System.Drawing.Point(131, 67);
            this.transportedMass.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.transportedMass.Name = "transportedMass";
            this.transportedMass.Size = new System.Drawing.Size(114, 20);
            this.transportedMass.TabIndex = 19;
            // 
            // rating
            // 
            this.rating.DecimalPlaces = 1;
            this.rating.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.rating.Location = new System.Drawing.Point(368, 66);
            this.rating.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(74, 20);
            this.rating.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.rating);
            this.groupBox1.Controls.Add(this.transportedMass);
            this.groupBox1.Controls.Add(this.enter);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.phoneNumber);
            this.groupBox1.Controls.Add(this.completedOrders);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.price);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 427);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(876, 167);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод информации";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 35);
            this.button1.TabIndex = 21;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(295, 153);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(0, 15);
            this.info.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(676, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Количество объектов";
            // 
            // objCount
            // 
            this.objCount.Location = new System.Drawing.Point(816, 402);
            this.objCount.Name = "objCount";
            this.objCount.ReadOnly = true;
            this.objCount.Size = new System.Drawing.Size(52, 20);
            this.objCount.TabIndex = 18;
            this.objCount.Text = "0";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(116, 132);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(659, 231);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 605);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.objCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.info);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.greetings);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Лабораторная работа 2";
            ((System.ComponentModel.ISupportInitialize)(this.price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.completedOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportedMass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rating)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label greetings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown price;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.NumericUpDown completedOrders;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.NumericUpDown transportedMass;
        private System.Windows.Forms.NumericUpDown rating;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox objCount;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
    }
}

