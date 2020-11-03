using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNS_Task_01
{

    class Program
    {
        
        
        static void Main(string[] args)
        {
            int price = 10;
            Console.Write("Введите количество вашего золота: ");
            int gold = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Обменный курс золота на кристаллы : { price } золота = 1 кристалл. ");
            Console.Write("Сколько кристаллов вы хотите купить?");
            int crystals = Convert.ToInt32(Console.ReadLine());

            try
            {
                int rest = gold - crystals * price;
                int[] check = new int[gold + 1];
                check[rest] = 1;
                Console.WriteLine($"Операция успешна. У вас осталось {rest} золота вы получили {crystals} кристалл(ов).");
            }
            catch
            {
                Console.WriteLine($"Сделка невозможна, у вас {gold} золота и 0 кристаллов.");
            }
            Console.ReadKey();
        }
    }


}
