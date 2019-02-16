using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task._2
{
    public class student
    {
        private string name;
        private string id;
        private int year;
        public student(string p1, string p2, int p3)
        {
            name = p1; // присваиваем значения
            id = p2;
            year = p3;
        }
        public int Year()
        {
            return year++;
        }
        public void info()
        {
            Console.WriteLine(name + " (" + id + ") " + " " + year); // выводим имя, айди и год обучения
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string p1 = Console.ReadLine(); // считываем строку имени
            string p2 = Console.ReadLine(); // считываем строку айди
            int p3 = int.Parse(Console.ReadLine()); // считываем год обучения
            student s1 = new student(p1, p2, p3); // отправляем в конструктор
            s1.Year();
            s1.info();
        }
    }
}
