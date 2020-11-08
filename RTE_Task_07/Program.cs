using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTE_Task_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int[] arr; // Массив
            int n = 0; // Размерность массива
            Console.Write("Введите размерность массива: ");
            try { n = Convert.ToInt32(Console.ReadLine()); }
            catch { Console.WriteLine("Неправильный ввод размености массива!");}
            arr = new int[n];
            Console.WriteLine("\n \n \nПервоначальный массив: ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = rng.Next(0, 999);
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine("\n \n \nПеремешанный массив: ");
            arr = arr.OrderBy(x => rng.Next()).ToArray();
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.ReadLine();
        }
    }
}
