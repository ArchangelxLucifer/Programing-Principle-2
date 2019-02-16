using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // считываем количество чисел
            string massive = Console.ReadLine(); // считываем строку
            string[] a = massive.Split(); // добавляем подстроки в массив а
            int[] b = new int[n]; // создаем массив, в котором хранятся n чисел 
            for(int i = 0; i < n; i++) // пробегаемся по циклу for
            {
                b[i] = int.Parse(a[i]); // Конвертируем элемменты массива а на тип int и перекидывем в массив b
            }
            int el = 0;
            for(int i = 0; i < n; i++)
            {
                int c = 0;
                if (b[i] == 1) 
                {
                    b[i] = 0;
                }
                else
                {
                    for (int k = 2; k < b[i]; k++) // Проверяем является ли число простым 
                    {
                        if (b[i] % k == 0) 
                        {
                            c++;
                        }
                    }
                    if (c == 0)
                    {
                        el++;
                    }
                    else
                    {
                        b[i] = 0;
                    }
                }
            }
            Console.WriteLine(el); // Количество простых чисел 
            for(int i = 0; i < n; i++)
            {
                if (b[i] != 0)
                {
                    Console.Write(b[i] + " "); // выводим простые числа
                }
            }
        }
    }
}
