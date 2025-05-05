namespace Lab2
{
    partial class View1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.delete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.objCount = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rating_type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportMethodColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.save_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.completedOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportedMass)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // greetings
            // 
            this.greetings.AutoSize = true;
            this.greetings.Location = new System.Drawing.Point(393, 11);
            this.greetings.Name = "greetings";
            this.greetings.Size = new System.Drawing.Size(276, 64);
            this.greetings.TabIndex = 0;
            this.greetings.Text = "Лабораторная работа № 7. Паттерн MVC.\r\nГруппа: 23ВП2.\r\nСостав бригады: Соколов, М" +
    "уравьев.\r\nВариант 8. Фирма грузоперевозок";
            this.greetings.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Оплата\nперевозки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "Масса\r\nперевезенных\r\nгрузов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Название\nфирмы";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(541, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 48);
            this.label5.TabIndex = 5;
            this.label5.Text = "Количество\r\nвыполненных\r\nзаказов";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(744, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 32);
            this.label6.TabIndex = 6;
            this.label6.Text = "Номер\nфирмы";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(963, 44);
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
            this.price.Location = new System.Drawing.Point(215, 80);
            this.price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.price.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(95, 22);
            this.price.TabIndex = 8;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(25, 81);
            this.name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(156, 22);
            this.name.TabIndex = 10;
            // 
            // completedOrders
            // 
            this.completedOrders.Location = new System.Drawing.Point(532, 80);
            this.completedOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.completedOrders.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.completedOrders.Name = "completedOrders";
            this.completedOrders.Size = new System.Drawing.Size(111, 22);
            this.completedOrders.TabIndex = 12;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Location = new System.Drawing.Point(744, 80);
            this.phoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(151, 22);
            this.phoneNumber.TabIndex = 13;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(967, 80);
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
            this.transportedMass.Location = new System.Drawing.Point(360, 80);
            this.transportedMass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.transportedMass.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.transportedMass.Name = "transportedMass";
            this.transportedMass.Size = new System.Drawing.Size(89, 22);
            this.transportedMass.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.groupBox1.Controls.Add(this.delete);
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.rating_type,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.transportMethodColumn});
            this.dataGridView1.Location = new System.Drawing.Point(16, 137);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1141, 294);
            this.dataGridView1.TabIndex = 21;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Название компании";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 105;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Цена";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 75;
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Масса";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 75;
            // 
            // rating_type
            // 
            this.rating_type.Frozen = true;
            this.rating_type.HeaderText = "Тип рейтинга";
            this.rating_type.Items.AddRange(new object[] {
            "По заказам",
            "По цене",
            "Комбин."});
            this.rating_type.MinimumWidth = 6;
            this.rating_type.Name = "rating_type";
            this.rating_type.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.rating_type.Width = 85;
            // 
            // Column4
            // 
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "Рейтинг";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 55;
            // 
            // Column5
            // 
            this.Column5.Frozen = true;
            this.Column5.HeaderText = "Количество заказов";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 70;
            // 
            // Column6
            // 
            this.Column6.Frozen = true;
            this.Column6.HeaderText = "Номер телефона";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.Frozen = true;
            this.Column7.HeaderText = "Почта";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 120;
            // 
            // transportMethodColumn
            // 
            this.transportMethodColumn.Frozen = true;
            this.transportMethodColumn.HeaderText = "Способ перевозки";
            this.transportMethodColumn.Items.AddRange(new object[] {
            "Перевозка самолетом",
            "Перевозка грузовиком",
            "Перевозка кораблем"});
            this.transportMethodColumn.MinimumWidth = 6;
            this.transportMethodColumn.Name = "transportMethodColumn";
            this.transportMethodColumn.Width = 167;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(1060, 439);
            this.save_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(100, 28);
            this.save_button.TabIndex = 22;
            this.save_button.Text = "Сохранить";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // View1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 732);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.objCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.greetings);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "View1";
            this.Text = "Лабораторная работа 7";
            ((System.ComponentModel.ISupportInitialize)(this.price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.completedOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportedMass)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label greetings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox objCount;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewComboBoxColumn rating_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewComboBoxColumn transportMethodColumn;
    }
}

