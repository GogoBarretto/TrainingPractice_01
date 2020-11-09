using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTE_Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вы можете вводить любые слова в консоль, пока не введено слово 'exit'. Вводите: ");
            string exit = "";
            do
            {
                exit = Console.ReadLine();
            } while (exit != "exit");
        }
    }
}
