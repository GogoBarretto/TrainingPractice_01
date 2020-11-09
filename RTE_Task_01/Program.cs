using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTE_Task_01
{

    class Program
    {
        
        
        static void Main(string[] args)
        {
            bool purchase;
            int price = 10;
            Console.Write("Введите количество вашего золота: ");
            int gold = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Обменный курс золота на кристаллы : { price } золота = 1 кристалл. ");
            Console.Write("Сколько кристаллов вы хотите купить? : ");
            int crystals = Convert.ToInt32(Console.ReadLine());


            purchase = gold >= price * crystals;
            crystals *= Convert.ToInt32(purchase);
            gold -= price * crystals;
            Console.WriteLine($"У вас осталось {gold} золота вы получили {crystals} кристалл(ов).");

            Console.ReadKey();
        }
    }


}
