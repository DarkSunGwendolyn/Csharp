namespace Lab6
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
            this.minFindButton = new System.Windows.Forms.Button();
            this.showTimeButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // minFindButton
            // 
            this.minFindButton.Location = new System.Drawing.Point(12, 90);
            this.minFindButton.Name = "minFindButton";
            this.minFindButton.Size = new System.Drawing.Size(100, 23);
            this.minFindButton.TabIndex = 0;
            this.minFindButton.Text = "Найти минимум";
            this.minFindButton.UseVisualStyleBackColor = true;
            this.minFindButton.Click += new System.EventHandler(this.findMinButton_Click);
            // 
            // showTimeButton
            // 
            this.showTimeButton.Location = new System.Drawing.Point(209, 90);
            this.showTimeButton.Name = "showTimeButton";
            this.showTimeButton.Size = new System.Drawing.Size(100, 23);
            this.showTimeButton.TabIndex = 1;
            this.showTimeButton.Text = "Показать время";
            this.showTimeButton.UseVisualStyleBackColor = true;
            this.showTimeButton.Click += new System.EventHandler(this.showTimeButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(125, 163);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 2;
            this.loadButton.Text = "Загрузить";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(12, 119);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.ReadOnly = true;
            this.textBoxMin.Size = new System.Drawing.Size(100, 20);
            this.textBoxMin.TabIndex = 3;
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(209, 119);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.ReadOnly = true;
            this.textBoxTime.Size = new System.Drawing.Size(100, 20);
            this.textBoxTime.TabIndex = 4;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 192);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(297, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 78);
            this.label1.TabIndex = 6;
            this.label1.Text = "Лабораторная работа 6. Многопоточность и\r\nасинхронное программирование\r\nВариант 8" +
    ". Поиск минимального значения\r\nна векторе\r\nСостав бригады: Муравьев В.С., Соколо" +
    "в О.А.\r\n23ВП2";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 227);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.showTimeButton);
            this.Controls.Add(this.minFindButton);
            this.Name = "Form1";
            this.Text = "Лабораторная работа 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button minFindButton;
        private System.Windows.Forms.Button showTimeButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
    }
}

