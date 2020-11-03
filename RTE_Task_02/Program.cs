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
            Console.WriteLine("Enter any words you want (Word 'exit' ends the program): ");
            string exit = "";
            do
            {
                exit = Console.ReadLine();
            } while (exit != "exit");
        }
    }
}
