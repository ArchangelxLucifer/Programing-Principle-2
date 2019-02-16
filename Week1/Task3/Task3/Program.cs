using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string massive = Console.ReadLine();
            string[] a = massive.Split();
            int[] b = new int[n];
            int[] c = new int[2 * n];
            for(int i = 0; i < n; i++)
            {
                b[i] = int.Parse(a[i]); //преобразование массива со string к типу int 
            }
            for(int i = 0; i < 2 * n; i++)
            {
                c[i] = b[i / 2]; //каждые последующие 2 эллемента большого массива были равны одному элементу маленького массива 
            }
            for(int i = 0; i < 2 * n; i++)
            {
                Console.Write(c[i] + " "); // выведение оканчательного массива 
            }
        }
    }
}
