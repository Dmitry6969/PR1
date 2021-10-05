using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_9
{
    public class Class1
    {
        public static int SummLess8(List<int> numbers)//функция суммирования ряда чисел
        {                               
            int summ;//сумма
            int n = numbers.Count();//количество элементов
            int l = 0;//счетчик
            List<int> numbers8 = new List<int>();//новый список для чисел меньше 8

            do// отбор чисел меньше 8  в новый ряд
            {
                if (numbers[l] < 8)
                {
                    numbers8.Add(numbers[l]);
                }
                l++;

            } while (l <= n - 1);

            summ = numbers8.Sum();//суммирование
            return summ;//возврат суммы

        }

    }
}
