using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Student // создаем класс
    {
        public string name;//обьявляем переменную имя
        public string id; // обьявляем переменную айди
        public int year; // год
        public Student(string name,string id)// создаем конструктор с двумя параметрами(имя и айди)
        {
            this.name = name;// уточняем обращение к переменной
            this.id = id; // уточняем обращение к переменной
        }
        public void Constructor() // создаем метод для увеличения года и вывода на экран данных
        {
            year++; // увеличиваем год
            Console.WriteLine("Name: {0}; ID: {1}; Year:{2}", name, id, year);// вывод

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student Sanzhar = new Student("Sanzhar", "18BD789456"); // создаем новый экземпляр
            Sanzhar.year = 2;// присваиваем значение году
            Sanzhar.Constructor(); // вызываем метод
            Console.ReadKey();
        }
    }
}
