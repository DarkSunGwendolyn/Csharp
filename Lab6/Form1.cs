using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Поиск минимума
        private async void findMinButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            List<int> numbers = new List<int>();
            int arraySize = 1000;
            for (int i = 0; i < arraySize; i++)
                numbers.Add(rnd.Next(-1000, 10000));

            int min = await FindMinAsync(numbers);

            textBoxMin.Text = $"Минимум: {min}";
        }
        private async Task<int> FindMinAsync(List<int> numbers)
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(1500);
                return numbers.Min();
            });
        }

        // Вывод системного времени
        private CancellationTokenSource timeTokenSource;
        private async void showTimeButton_Click(object sender, EventArgs e)
        {
            if (timeTokenSource != null)
            {
                timeTokenSource.Cancel();
                timeTokenSource = null;
                showTimeButton.Text = "Показать время";
                return;
            }

            timeTokenSource = new CancellationTokenSource();
            showTimeButton.Text = "Остановить время";

            await ShowTimeAsync(timeTokenSource.Token);
        }
        private async Task ShowTimeAsync(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                textBoxTime.Invoke((MethodInvoker)(() =>
                {
                    textBoxTime.Text = DateTime.Now.ToLongTimeString();
                }));

                await Task.Delay(1000);
            }
        }

        // Имитация загрузки
        private async void loadButton_Click(object sender, EventArgs e)
        {
            await SimulateLoadingAsync();
        }
        private async Task SimulateLoadingAsync()
        {
            progressBar1.Value = 0;
            for (int i = 0; i <= 100; i += 10)
            {
                progressBar1.Value = i;
                await Task.Delay(300);
            }

            MessageBox.Show("Загрузка завершена!", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
            progressBar1.Value = 0;
        }
    }
}
