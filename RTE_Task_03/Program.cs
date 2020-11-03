using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTE_Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isAccessGranted = false;
            string password = "password";
            for(int i = 0; i < 3;i++)
            {
                Console.Write("Введите пароль: ");
                string password_check = Console.ReadLine();
                if (password == password_check)
                {
                    isAccessGranted = true;
                    break;
                }
                else
                {
                    Console.WriteLine($"Пароль введён не правильно, у вас осталось {2 - i} попыток для ввода");
                    Console.WriteLine();
                }
            }
            if (isAccessGranted == true)
            {
                Console.WriteLine("Вы успешно вошли в систему");
            }
            else
            {
                Console.WriteLine("Вы исчерпали все попытки входа, доступ не получен.");
            }
            Console.ReadLine();
        }
    }
}
