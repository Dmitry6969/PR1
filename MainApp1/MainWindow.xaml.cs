using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Lib_9;

namespace MainApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //Ермолаев Дмитрий ИСП-31
        //Вариант 9
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            chisla.Text = " ";// очистка поля вывода ряда чисел
            int n = Convert.ToInt32(N.Text);//число элементов ряда
            List<int> numbers = new List<int>();//сам ряд
            Random rnd = new Random();

            int i = 0;//счетчик
            do//заполнение случайными числами в диапозоне 2-14
            {
                int x = rnd.Next(2, 14);
                numbers.Add(x);
                i++;

            } while (i <= n-1);

            result.Text = Convert.ToString(Class1.SummLess8(numbers));//модуль фунцкии отборки чисел меньше 8 из ряда чисел и их суммирования + вывод 

            i = 0;//обнуление счетчика
            do//вывод исходного ряда чисел
            {
                chisla.Text += numbers[i].ToString() + "\r\n";
                i++;
            } while (i <= n - 1);

        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();//выход из программы
        }

        private void info_Click(object sender, RoutedEventArgs e)//информация
        {
            MessageBox.Show("Ермолаев Дмитрий ИСП-31 Вариант 9 Сформировать n целых чисел в диапазоне 2-14. Найти сумму чисел < 8. Результат вывести на экран.");
        }
    }
}
