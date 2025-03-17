namespace Lab2
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
            this.create = new System.Windows.Forms.Button();
            this.transportedMass = new System.Windows.Forms.NumericUpDown();
            this.rating = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.generate_100000_objects = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.objCount = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.showAll = new System.Windows.Forms.Button();
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
            this.greetings.Location = new System.Drawing.Point(393, 11);
            this.greetings.Name = "greetings";
            this.greetings.Size = new System.Drawing.Size(348, 80);
            this.greetings.TabIndex = 0;
            this.greetings.Text = "Лабораторная работа № 3. Порождающие паттерны.\r\nПаттерн Прототип\r\nГруппа: 23ВП2.\r" +
    "\nСостав бригады: Соколов, Муравьев.\r\nВариант 8. Фирма грузоперевозок";
            this.greetings.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Оплата\nперевозки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Масса перевезенных\nгрузов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Название\nфирмы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(501, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Рейтинг";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(611, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Количество выполненных\nзаказов";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(847, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 32);
            this.label6.TabIndex = 6;
            this.label6.Text = "Номер\nфирмы";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1047, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 32);
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
            this.price.Location = new System.Drawing.Point(24, 82);
            this.price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.price.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(124, 22);
            this.price.TabIndex = 8;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(341, 82);
            this.name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(128, 22);
            this.name.TabIndex = 10;
            // 
            // completedOrders
            // 
            this.completedOrders.Location = new System.Drawing.Point(613, 82);
            this.completedOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.completedOrders.Name = "completedOrders";
            this.completedOrders.Size = new System.Drawing.Size(124, 22);
            this.completedOrders.TabIndex = 12;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Location = new System.Drawing.Point(800, 82);
            this.phoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(151, 22);
            this.phoneNumber.TabIndex = 13;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(995, 82);
            this.email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(163, 22);
            this.email.TabIndex = 14;
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(941, 135);
            this.create.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(215, 46);
            this.create.TabIndex = 15;
            this.create.Text = "Создать";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // transportedMass
            // 
            this.transportedMass.DecimalPlaces = 1;
            this.transportedMass.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.transportedMass.Location = new System.Drawing.Point(175, 82);
            this.transportedMass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.transportedMass.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.transportedMass.Name = "transportedMass";
            this.transportedMass.Size = new System.Drawing.Size(152, 22);
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
            this.rating.Location = new System.Drawing.Point(491, 81);
            this.rating.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rating.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(99, 22);
            this.rating.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.groupBox1.Controls.Add(this.generate_100000_objects);
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.rating);
            this.groupBox1.Controls.Add(this.transportedMass);
            this.groupBox1.Controls.Add(this.create);
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
            this.groupBox1.Location = new System.Drawing.Point(3, 526);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1168, 206);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод информации";
            // 
            // generate_100000_objects
            // 
            this.generate_100000_objects.Location = new System.Drawing.Point(505, 138);
            this.generate_100000_objects.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.generate_100000_objects.Name = "generate_100000_objects";
            this.generate_100000_objects.Size = new System.Drawing.Size(152, 43);
            this.generate_100000_objects.TabIndex = 22;
            this.generate_100000_objects.Text = "Создать 100000 объектов";
            this.generate_100000_objects.UseVisualStyleBackColor = true;
            this.generate_100000_objects.Click += new System.EventHandler(this.generate_100000_objects_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(13, 138);
            this.delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(112, 43);
            this.delete.TabIndex = 21;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(901, 498);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Количество объектов";
            // 
            // objCount
            // 
            this.objCount.Location = new System.Drawing.Point(1088, 495);
            this.objCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.objCount.Name = "objCount";
            this.objCount.ReadOnly = true;
            this.objCount.Size = new System.Drawing.Size(68, 22);
            this.objCount.TabIndex = 18;
            this.objCount.Text = "0";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(149, 146);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(877, 283);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // showAll
            // 
            this.showAll.Location = new System.Drawing.Point(473, 438);
            this.showAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showAll.Name = "showAll";
            this.showAll.Size = new System.Drawing.Size(223, 59);
            this.showAll.TabIndex = 20;
            this.showAll.Text = "Вывести все фирмы";
            this.showAll.UseVisualStyleBackColor = true;
            this.showAll.Click += new System.EventHandler(this.showAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 732);
            this.Controls.Add(this.showAll);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.objCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.greetings);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Лабораторная работа 3";
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
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.NumericUpDown transportedMass;
        private System.Windows.Forms.NumericUpDown rating;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox objCount;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button showAll;
        private System.Windows.Forms.Button generate_100000_objects;
    }
}

