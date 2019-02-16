using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // считываем количество строк
            string a = "[*]";  // присваиваем значение 
            string[,] t = new string[n, n]; // создаем двумерный массив
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (i >= j)                        
                    {
                        t[i, j] = a;
                        Console.Write(t[i, j]);
                    }
                    else
                    {                                    
                        Console.Write("");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
