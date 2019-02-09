using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int n; // глобально обьявляем перменную для размера массива
        static int[] a = new int[1000]; // создаем пустой масив с размером 1000
        
        static public void Nevoid() // создаем метод для того чтобы дублировать элементы массива 
        {
            int[] w = new int[2 * n]; // создаем еще один массив
            for(int i=0;i<n;i++) // цикл чтобы присвоить и продублировать значения
            {
                w[i * 2] = a[i]; // текущий элемент пустого массива равен текущему элементу данного массива 
                w[i * 2 + 1] = a[i]; // следуюищй элемент пустого массива равен текущему элементу данного массива
            }
            for(int i=0;i<w.Length; i++) // цикл чтобы вывксти элементы массива на экран
            {
                Console.Write(w[i] + " "); //выводим  
            }
        }
        static void Main(string[] args) 
        {
            n = int.Parse(Console.ReadLine()); // считываем значение размера массива и переводим его в интежер
            string[] p = Console.ReadLine().Split(); // создаем массив строк который разделяем по пробелу
            for (int i = 0; i < n; i++) // цикл для присвоения значений массиву
            {
                a[i] = int.Parse(p[i]);// элемент массива равен элементу строки переведенный в интежер

            }
            Nevoid();// вызываем метод
            Console.ReadKey();// чтобы консоль не закрылась
        }
    }
}
