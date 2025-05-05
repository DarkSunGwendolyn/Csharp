using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    internal static class Program
    {
        // Импорт функции для создания консоли
        [DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        [STAThread]
        static void Main()
        {
            // Устанавливаем русскую локализацию
            Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-RU");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Показываем окно выбора режима
            var result = MessageBox.Show(
                "Выберите режим запуска:\n\nДа — Консоль\nНет — Форма",
                "Режим запуска",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Создаём консоль
                AllocConsole();

                // Настройка кодировок для корректного отображения русских символов
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.InputEncoding = Encoding.GetEncoding(1251);

                // Перенаправляем вывод в стандартный поток
                var writer = new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true };
                Console.SetOut(writer);
                Console.SetError(writer);

                // Запускаем консольное представление
                var view = new View2();
                view.Run();
            }
            else
            {
                // Запускаем WinForms форму
                Application.Run(new View1());
            }
        }
    }
}
