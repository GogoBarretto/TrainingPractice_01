using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RTE_Task_04
{
    class Mage //Начальные параметры мага
    {
        public int health = 150; 
        public int attack_modifier = 1;
       
    }
    class Boss //Начальные параметры босса
    {
        public int health = 150;
        public int attack_modifier = 1;
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            
            Mage mage = new Mage();
            Boss boss = new Boss();
            bool isStunned = false ; // Застанен ли босс (изначально нет)
            int lava_lakes_charge = 0;//Заряд магмовых озёр

            Console.WriteLine("Вы - послушник гильдии магов огня. В качестве последнего испытания для становления полноценным магом");
            Console.WriteLine("огня совет магов назначил вам испытание поединком против ледяного голема. Если вы потерпите поражение");
            Console.WriteLine("сейчас, то погибните, и ваше место займёт другой послушник. Постарайтесь, чтобы выжить и уничтожить");
            Console.WriteLine("голема как можно быстрее, так как с каждым ходом голем будет бить всё сильнее и сильнее.");
            Console.WriteLine();
            Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
            Console.ReadKey();
            Console.Clear();
            do
            {
                //Ход мага
                Console.WriteLine($"Здоровье мага  = {mage.health}  Множитель урона по боссу = {mage.attack_modifier}   Заряды магмовых озёр = {lava_lakes_charge}");
                Console.WriteLine($"Здоровье босса = {boss.health}");
                Console.WriteLine();
                Console.WriteLine("Ваши заклинания:");
                Console.WriteLine("1: Огненная стрела (С множителем урона '1' наносит от 1 до 10 урона)");
                Console.WriteLine("2: Всепоглащающее пекло (Увеличивает множитель урона на 2, но с 50% шансом потерять 25 здоровья)");
                Console.WriteLine("3: Метеоритный дождь (Боссу наносится урон в размере 1-5, вам - 2-10 (с множителем урона 1), но босс с шансом в 75% не сможет ходить следующий раунд)");
                Console.WriteLine("4: Святое пламя (Лечит вас на 10-20 единиц здоровья (с множителем урона 1) (выше 150 не поднимется), но уменьшает множитель урона на 1 (ниже 1 не падает)) ");
                Console.WriteLine("5: Бушевание магмовых озёр (Даёт 1 заряд магмовых озёр. При накоплении 6 зарядов заклинание высвобождается и полностью аннигилирует босса)");

            
                Console.WriteLine();
            chooseAgain:
                Console.Write("Выберите заклинание на этот ход: ");

                int spellSelection = 0;
                try { spellSelection = Convert.ToInt32(Console.ReadLine()); }
                catch 
                {
                    Console.WriteLine("Такого заклинания нет, попробуйте заново.");
                    Console.WriteLine();
                    goto chooseAgain;
                }
                
                Console.WriteLine();
                int health_change = 0;
                int modifier_change = 0;
                string stun = "";
                switch (spellSelection) // Выбор заклинания для атаки
                {
                    
                    case (1):
                        health_change = Spell1(mage.attack_modifier);
                        Console.WriteLine($"Вы атаковали босса огненной стрелой и нанесли ему {health_change} единиц(ы) урона. ");
                        boss.health -= health_change;
                        break;

                    case (2):
                        health_change = Spell2Health();
                        Console.WriteLine($"Вы увеличили множитель урона на 1 и потеряли {health_change} единиц(ы) здоровья. ");
                        mage.health -= health_change;
                        mage.attack_modifier = Spell2Modifier(mage.attack_modifier);
                        break;

                    case (3):
                        health_change = Spell3Health(mage.attack_modifier);
                        Console.WriteLine($"Вы потеряли {health_change * 2} единиц(ы) здоровья. ");
                        mage.health -= health_change * 2;

                        health_change = Spell3Health(mage.attack_modifier);
                        isStunned = Spell3Stun(isStunned);
                        if (isStunned)
                            stun = ("застанился.");
                        else
                            stun = ("не застанился.");
                        Console.WriteLine($"Босс потерял {health_change} единиц(ы) здоровья, и босс {stun} ");
                        boss.health -= health_change;                        
                        break;

                    case (4):
                        health_change = Spell4Health(mage.attack_modifier);
                        mage.attack_modifier = Spell4Modifier(mage.attack_modifier);
                        Console.WriteLine($"Вы получили {health_change} единиц(ы) здоровья, новый множитель урона: {mage.attack_modifier} ");
                        if (mage.health + health_change >= 150)
                            mage.health = 150;
                        else
                            mage.health += health_change;
                        break;

                    case (5):
                        lava_lakes_charge = Spell5(lava_lakes_charge);
                        Console.WriteLine($"Вы получили 1 заряд магмовых озёр, теперь их {lava_lakes_charge}.");
                        if (lava_lakes_charge >= 6) 
                        {
                            Console.WriteLine($"Зарядив 6-ой заряд магмовых озёр вы обрушили всю их яростную силу на босса.");
                            Console.WriteLine("Босс получил 666 единиц урона.");
                            boss.health -= 666;
                        }
                        break;

                    default:
                        Console.WriteLine("Такого заклинания нет, попробуйте заново.");
                        goto chooseAgain;     
                }
                Console.WriteLine();
                Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                Console.ReadKey();
                Console.Clear();
                if (boss.health >= 1) // Ход босса
                {
                    Console.WriteLine($"Ход босса: ");
                    Console.WriteLine();
                    Random rng = new Random();
                    int result = rng.Next(2);
                    int boss_attack = rng.Next(4, 6);
                    if (result == 0)
                    {
                        health_change = boss.attack_modifier * boss_attack;
                        Console.WriteLine($"Босс вызвал заклинание ледяного шторма и нанёс вам {health_change} единиц урона.");
                        mage.health -= health_change;
                    }
                    else
                    {
                        health_change = boss.attack_modifier * boss_attack / 10;
                        mage.health -= health_change;
                        boss.health += health_change;
                        if (boss.health > 150)
                            boss.health = 150;
                        Console.WriteLine($"Босс вызвал заклинание вытягивания жизненной энергии, нанёс вам {health_change} единиц урона и вылечил себя на {health_change} единиц здоровья.");
                    }
                    boss.attack_modifier += 1;

                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                }


            } while (mage.health > 0 && boss.health > 0); //Битва идёт до тех пор, пока здоровье одной из сил не упало ниже единицы.

            if (mage.health <= 0)
                Console.WriteLine("Ваше здоровье упало ниже 0, вы погибли.");
            else
                Console.WriteLine("Вы победили босса. Сражение выиграно!");
            Console.ReadLine();
        }
        static int Spell1(int attack) // Урон по боссу в диапазоне 1-10
        {
            Random rng = new Random();
            int result = rng.Next(1, 10) * attack;
            return result;
        }



        static int Spell2Health() // Проверка на урон от заклинания 2
        {
            Random rng = new Random();
            int result = rng.Next(1, 100);
            if (result > 50)
                return 25;
            else
                return 0;
        }
        static int Spell2Modifier(int attack) // Увеличение модификатора урона
        {
            return attack += 2;
        }



        static int Spell3Health(int attack) //Заклинание на стан
        {
            Random rng = new Random();
            int result = rng.Next(1, 5) * attack;
            return result;
        }
        static bool Spell3Stun(bool Stun)// Сам стан
        {
            Random rng = new Random();
            int result = rng.Next(1, 100);
            if (result > 25)
                return Stun = true;
            else
                return Stun = false;
        }


        static int Spell4Health(int attack) // Заклинание регенерации
        {
            Random rng = new Random();
            int result = rng.Next(10, 20) * attack;
            return result;
        }
        static int Spell4Modifier(int attack) // Разрядка множителя урона
        {
            if (attack > 1)
                return attack -= 1;
            else
                return attack =  1;
        }


        static int Spell5(int charge) // Новый заряд для заклинания магмовых озёр
        {
            return charge += 1;
        }
    }
}
