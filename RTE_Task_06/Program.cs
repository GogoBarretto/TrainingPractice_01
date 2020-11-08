using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RTE_Task_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] FIO = new string[3][]; // Массив массивов, в котором у Фамилии, Имени и Отчества свои массивы.
            FIO[0] = new string[100];//Фамилии
            FIO[1] = new string[100];//Имена
            FIO[2] = new string[100];//Отчества

            string[] post = new string[100];// Должность
            int i = 0;//Количество записей
            bool isNeeded = true; // Проверка для выхода из массива

            do
            {
                Console.Write("Функции отдела кадров: " +
                           "\n  1. Добавить досье " +
                           "\n  2. Вывести все досье" +
                           "\n  3. Удалить досье" +
                           "\n  4. Найти досье по фамилии" +
                           "\n  5. Выйти из меню \n \n");
                Console.Write("Выберите функцию: ");
                int function;
                try { function = Convert.ToInt32(Console.ReadLine()); } //Выбираем функцию
                catch { function = 0; }
                Console.Clear();

                switch (function)
                {
                    case 1:
                        Console.Write("Введите Фамилию: ");
                        FIO[0][i] = Console.ReadLine();
                        Console.Write("Введите Имя: ");
                        FIO[1][i] = Console.ReadLine();
                        Console.Write("Введите Отчество: ");
                        FIO[2][i] = Console.ReadLine();

                        Console.Write("Введите должность, которую занимает этот человек: "); // Вводим данные о человеке
                        post[i] = Console.ReadLine();
                        i++; // Увеличиваем число записей на 1
                        Console.Write("Досье успешно занесено в базу. Нажмите любую кнопку для продолжения!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        if (i != 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Записанные в базе досье: \n");
                            for (int j = 0; j <= i - 1; j++)
                            {
                                Console.WriteLine($"{j}. {FIO[0][j]} {FIO[1][j]} {FIO[2][j]} : {post[j]}"); // Выводим все данные
                            }
                            Console.Write("\n Нажмите любую кнопку для продолжения!");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.Write("Не найдено ни одной записи. Нажмите любую кнопку для продолжения!");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 3:
                        Console.Write("Досье под каким номером нужно удалить? : ");
                        int choice;
                        again:
                        try { choice = Convert.ToInt32(Console.ReadLine()); }
                        catch { goto again; }

                        bool isFounded = false; // Переменная, чтобы понять, был ли уже использован нужный индекс
                        if (choice <= i && choice > 0) // Проверка, не введено ли число больше, чем общее кол-во внесенных в список людей, или же если индекс < 0
                        {
                            for (int j = 0; j <= i; j++)
                            {

                                if (j == choice || isFounded)
                                {
                                    if (j != i - 1) // Чтобы не было ошибки о заполнении массива несуществующими данными
                                    {
                                        FIO[0][j] = FIO[0][j + 1];
                                        FIO[1][j] = FIO[1][j + 1];
                                        FIO[2][j] = FIO[2][j + 1];
                                        post[j] = post[j + 1];
                                        isFounded = true;
                                    }
                                    else
                                    {
                                        FIO[0][j] = "";
                                        FIO[1][j] = "";
                                        FIO[2][j] = "";
                                        post[j] = "";

                                    }
                                }
                            }
                            i--; // Уменьшаем число записей на 1
                            Console.WriteLine("Досье успешно удалено. Нажмите любую кнопку для продолжения!");
                            Console.ReadKey();
                            Console.Clear();

                        }
                        else
                        {
                            Console.WriteLine("Неправильный индекс досье! Нажмите любую кнопку для продолжения!");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        
                        break;
                    case 4:
                        Console.Write("Введите фамилию, по которой хотите начать поиск (функция чувствительна к регистру): ");
                        string surname = Console.ReadLine(); // Ввод нужной фамилии
                        bool isAtLeastOne = false; // Проверка на хотя бы одно найденное совпадение
                        
                        for (int j = 0; j <= i; j++)
                        {
                            
                            if (surname == FIO[0][j])
                            {
                                isAtLeastOne = true;
                                Console.WriteLine($"{j}. {FIO[0][j]} {FIO[1][j]} {FIO[2][j]} : {post[j]}");
                            }
                            
                            

                        }
                        if (!isAtLeastOne)
                        {
                            Console.WriteLine("В базе не было найдено ни одного совпадения.");
                            
                        }
                        Console.WriteLine("\n Нажмите любую кнопку для продолжения!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        isNeeded = false;
                        break;
                    default:
                        Console.WriteLine("Такой функции не существует. Нажмите любую кнопку для продолжения!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }      
            } while (isNeeded);
        }
    }
}
