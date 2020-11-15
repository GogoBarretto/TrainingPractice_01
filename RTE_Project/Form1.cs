using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTE_Project
{
    public partial class Game : Form
    {
        int[] die = new int[] { 0, 0, 0, 0, 0, 0 }; // значения кубиков
        bool[] isChosen = new bool[] { false,false,false,false,false,false}; // выбран ли кубик
        bool[] isLocked = new bool[] { false, false, false, false, false, false }; // закрыт ли кубик от выбора в прошлом ходу
        int[] temp = new int[] { 0, 0, 0, 0, 0, 0 }; // для подсчёта чисел
        int countNum = 0; // счёт за ход
        int roundNum = 0; // счёт за раунд
        int counter = 0; // счётчик встречающихся одинаковых чисел
        bool firstRun = true; // инициализация запуска
        int player1 = 0, player2 = 0; // игрок 1 и 2 соответственно
        bool firstPlayer = true; // играет ли сейчас игрок 1

        Random rnd = new Random();
        public int Randomizer() // рандомизация значений для кубиков
        {
            int value = 1;
            for (int i = 0; i < 1000; i++)
            {
                value = rnd.Next(1, 7);
            }      
            return value;
        }
        public void makeWhite() // очистка поля для другого игрока
        {
            for (int i = 0; i < 6; i++)
            {
                isChosen[i] = false;
                isLocked[i] = false;
            }
            Die1.BackColor = Color.FromArgb(255, 255, 255);
            Die2.BackColor = Color.FromArgb(255, 255, 255);
            Die3.BackColor = Color.FromArgb(255, 255, 255);
            Die4.BackColor = Color.FromArgb(255, 255, 255);
            Die5.BackColor = Color.FromArgb(255, 255, 255);
            Die6.BackColor = Color.FromArgb(255, 255, 255);
            die[1] = Randomizer();
            Die1.Text = Convert.ToString(die[1]);
            die[2] = Randomizer();
            Die2.Text = Convert.ToString(die[2]);
            die[3] = Randomizer();
            Die3.Text = Convert.ToString(die[3]);
            die[4] = Randomizer();
            Die4.Text = Convert.ToString(die[4]);
            die[5] = Randomizer();
            Die5.Text = Convert.ToString(die[5]);
            die[0] = Randomizer();
            Die6.Text = Convert.ToString(die[0]);
        }
        public void Round() // завершение хода, подготовка к следующему
        {

            int check = 0; // проверка на выбранность и незаолченность
            for(int i = 0; i < 6; i++)
            {
                if (isChosen[i] && !isLocked[i])
                {
                    check++;
                    isLocked[i] = true;
                }
            }
            int chooseAmount = 0;
            for (int i = 0; i < 6; i++)
            {
                if (isChosen[i])
                {
                    chooseAmount += 1;
                }
            }
            if (countNum != 0 && chooseAmount == 6) // проверка на 6 заполненных кубиков
            {
                for (int i = 0; i < 6; i++)
                {
                    isChosen[i] = false;
                    isLocked[i] = false;
                }
                Die1.BackColor = Color.FromArgb(255, 255, 255);
                Die2.BackColor = Color.FromArgb(255, 255, 255);
                Die3.BackColor = Color.FromArgb(255, 255, 255);
                Die4.BackColor = Color.FromArgb(255, 255, 255);
                Die5.BackColor = Color.FromArgb(255, 255, 255);
                Die6.BackColor = Color.FromArgb(255, 255, 255);
                die[1] = Randomizer();
                Die1.Text = Convert.ToString(die[1]);
                die[2] = Randomizer();
                Die2.Text = Convert.ToString(die[2]);
                die[3] = Randomizer();
                Die3.Text = Convert.ToString(die[3]);
                die[4] = Randomizer();
                Die4.Text = Convert.ToString(die[4]);
                die[5] = Randomizer();
                Die5.Text = Convert.ToString(die[5]);
                die[0] = Randomizer();
                Die6.Text = Convert.ToString(die[0]);
                roundNum += countNum;
                CounterRound.Text = Convert.ToString(roundNum);
                countNum = 0;
                Counter.Text = Convert.ToString(countNum);
            }
            if (check == 6 && countNum >= 800) //проверка на 6 одинаковых кубиков
            {

                for (int i = 0; i < 6; i++)
                {
                    isChosen[i] = false;
                    isLocked[i] = false;
                }
                Die1.BackColor = Color.FromArgb(255, 255, 255);
                Die2.BackColor = Color.FromArgb(255, 255, 255);
                Die3.BackColor = Color.FromArgb(255, 255, 255);
                Die4.BackColor = Color.FromArgb(255, 255, 255);
                Die5.BackColor = Color.FromArgb(255, 255, 255);
                Die6.BackColor = Color.FromArgb(255, 255, 255);
                die[1] = Randomizer();
                Die1.Text = Convert.ToString(die[1]);
                die[2] = Randomizer();
                Die2.Text = Convert.ToString(die[2]);
                die[3] = Randomizer();
                Die3.Text = Convert.ToString(die[3]);
                die[4] = Randomizer();
                Die4.Text = Convert.ToString(die[4]);
                die[5] = Randomizer();
                Die5.Text = Convert.ToString(die[5]);
                die[0] = Randomizer();
                Die6.Text = Convert.ToString(die[0]);
                roundNum += countNum;
                CounterRound.Text = Convert.ToString(roundNum);
                countNum = 0;
                Counter.Text = Convert.ToString(countNum);
            }
            if ((check != 0 && countNum != 0) || firstRun) // проверка, впервые ли запущена программа, а затем рандомизация невыбранных кубиков
            {
                firstRun = false;
                if (!isChosen[1])
                {
                    die[1] = Randomizer();
                    Die1.Text = Convert.ToString(die[1]);
                    Die1.BackColor = Color.FromArgb(255, 255, 255);
                }
                if (!isChosen[2])
                {
                    die[2] = Randomizer();
                    Die2.Text = Convert.ToString(die[2]);
                    Die2.BackColor = Color.FromArgb(255, 255, 255);
                }
                if (!isChosen[3])
                {
                    die[3] = Randomizer();
                    Die3.Text = Convert.ToString(die[3]);
                    Die3.BackColor = Color.FromArgb(255, 255, 255);
                }
                if (!isChosen[4])
                {
                    die[4] = Randomizer();
                    Die4.Text = Convert.ToString(die[4]);
                    Die4.BackColor = Color.FromArgb(255, 255, 255);
                }
                if (!isChosen[5])
                {
                    die[5] = Randomizer();
                    Die5.Text = Convert.ToString(die[5]);
                    Die5.BackColor = Color.FromArgb(255, 255, 255);
                }
                if (!isChosen[0])
                {
                    die[0] = Randomizer();
                    Die6.Text = Convert.ToString(die[0]);
                    Die6.BackColor = Color.FromArgb(255, 255, 255);
                }
                roundNum += countNum;
                CounterRound.Text = Convert.ToString(roundNum);
                countNum = 0;
                Counter.Text = Convert.ToString(countNum);
                
            }
            else
            {
                MessageBox.Show(
                "Не выбрано ни одного кубика",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }
        }
        public int counterCount(int num) // счётчик комбинации
        {
            int sum = 0;
            for(int i = 0; i < 6;i++)
            {
                if (isChosen[i] && die[i] == num && !isLocked[i])
                {
                    sum += 1;
                }
            }
            return sum; // возвращает значение количества костей в комбинации
        }
        public void Count()
        {
            
            countNum = 0; // каждый выбор кости считает результат заново
            for (int i = 0; i < 6; i++)
            {
                if (isChosen[i] && !isLocked[i]) // считает только если кубик незалочен и выбран
                {
                    if (temp.Contains(die[i])) { } // не считает, если значение кубика присутствует в временном массиве
                    else
                    {
                        if (die[i] == 1) // счёт для единицы
                        {
                            counter = counterCount(die[i]);

                            if (counter == 6)
                            {
                                countNum += (((die[i] * 1000) * 2) * 2) * 2;
                            }
                            else if (counter == 5)
                            {
                                countNum += ((die[i] * 1000) * 2) * 2;
                            }
                            else if (counter == 4)
                            {
                                countNum += (die[i] * 1000) * 2;
                            }
                            else if (counter == 3)
                            {
                                countNum += die[i] * 1000;
                            }
                            else
                            {
                                countNum += counter * die[i] * 100;
                            }
                            temp[i] = die[i];
                        }
                        if (die[i] == 5) // счёт для пятёрки
                        {
                            counter = counterCount(die[i]);
                            if (counter == 6)
                            {
                                countNum += (((die[i] * 100) * 2) * 2) * 2;
                            }
                            else if (counter == 5)
                            {
                                countNum += ((die[i] * 100) * 2) * 2;
                            }
                            else if (counter == 4)
                            {
                                countNum += (die[i] * 100) * 2;
                            }
                            else if (counter == 3)
                            {
                                countNum += die[i] * 100;
                            }
                            else
                            {
                                countNum += counter * die[i] * 10;
                            }
                            temp[i] = die[i];
                        }
                        if (die[i] == 2) // это и ниже - счёт для остальных значений. Сделано так, ибо на одном ходу могут сразу попасться две+ комбинации
                        {
                            counter = counterCount(die[i]);
                            if (counter == 6)
                            {
                                countNum += (((die[i] * 100) * 2) * 2) * 2;
                            }
                            else if (counter == 5)
                            {
                                countNum += ((die[i] * 100) * 2) * 2;
                            }
                            else if (counter == 4)
                            {
                                countNum += (die[i] * 100) * 2;
                            }
                            else if (counter == 3)
                            {
                                countNum += die[i] * 100;
                            }
                            else if (counter > 0)
                                countNum = 0;
                            temp[i] = die[i];
                        }
                        if (die[i] == 3)
                        {
                            counter = counterCount(die[i]);
                            if (counter == 6)
                            {
                                countNum += (((die[i] * 100) * 2) * 2) * 2;
                            }
                            else if (counter == 5)
                            {
                                countNum += ((die[i] * 100) * 2) * 2;
                            }
                            else if (counter == 4)
                            {
                                countNum += (die[i] * 100) * 2;
                            }
                            else if (counter == 3)
                            {
                                countNum += die[i] * 100;
                            }
                            else if (counter > 0)
                                countNum = 0;
                            temp[i] = die[i];
                            
                        }
                        if (die[i] == 4)
                        {
                            counter = counterCount(die[i]);
                            if (counter == 6)
                            {
                                countNum += (((die[i] * 100) * 2) * 2) * 2;
                            }
                            else if (counter == 5)
                            {
                                countNum += ((die[i] * 100) * 2) * 2;
                            }
                            else if (counter == 4)
                            {
                                countNum += (die[i] * 100) * 2;
                            }
                            else if (counter == 3)
                            {
                                countNum += die[i] * 100;
                            }
                            else if (counter > 0)
                                countNum = 0;
                            temp[i] = die[i];
                        }
                        if (die[i] == 6)
                        {
                            counter = counterCount(die[i]);
                            if (counter == 6)
                            {
                                countNum += (((die[i] * 100) * 2) * 2) * 2;
                            }
                            else if (counter == 5)
                            {
                                countNum += ((die[i] * 100) * 2) * 2;
                            }
                            else if (counter == 4)
                            {
                                countNum += (die[i] * 100) * 2;
                            }
                            else if (counter == 3)
                            {
                                countNum += die[i] * 100;
                            }
                            else if (counter > 0)
                                countNum = 0;
                            temp[i] = die[i];
                        }
                    }
                }
            }
            Counter.Text = Convert.ToString(countNum);
            for (int j = 0; j < 6; j++) { temp[j] = 0; } // обнуление временного массива
        }


        public Game()
        {
            InitializeComponent();
        }

        private void Die1_Click(object sender, EventArgs e)// Это и ниже - кнопки нажатия на кости, проверки на выбранность (нельзя отменить выбор, если кость залочена)
        {
            if(!isChosen[1])
            {
                Die1.BackColor = Color.FromArgb(240, 128, 128);
                isChosen[1] = true;
                Count();
                
            }
            else if(!isLocked[1])
            {
                Die1.BackColor = Color.FromArgb(255, 255, 255);
                isChosen[1] = false;
                Count();
            }
        }

        
        private void Die2_Click_1(object sender, EventArgs e)
        {
            if (!isChosen[2])
            {
                Die2.BackColor = Color.FromArgb(240, 128, 128);
                isChosen[2] = true;
                Count();

            }
            else if (!isLocked[2])
            {
                Die2.BackColor = Color.FromArgb(255, 255, 255);
                isChosen[2] = false;
                Count();
            }
        }

        private void Die3_Click_1(object sender, EventArgs e)
        {
            if (!isChosen[3])
            {
                Die3.BackColor = Color.FromArgb(240, 128, 128);
                isChosen[3] = true;
                Count();

            }
            else if (!isLocked[3])
            {
                Die3.BackColor = Color.FromArgb(255, 255, 255);
                isChosen[3] = false;
                Count();
            }
        }

        private void Die4_Click_1(object sender, EventArgs e)
        {
            if (!isChosen[4])
            {
                Die4.BackColor = Color.FromArgb(240, 128, 128);
                isChosen[4] = true;
                Count();

            }
            else if (!isLocked[4])
            {
                Die4.BackColor = Color.FromArgb(255, 255, 255);
                isChosen[4] = false;
                Count();
            }
        }

        private void Die5_Click_1(object sender, EventArgs e)
        {
            if (!isChosen[5])
            {
                Die5.BackColor = Color.FromArgb(240, 128, 128);
                isChosen[5] = true;
                Count();

            }
            else if (!isLocked[5])
            {
                Die5.BackColor = Color.FromArgb(255, 255, 255);
                isChosen[5] = false;
                Count();
            }
        }

        private void Die6_Click_1(object sender, EventArgs e)
        {
            if (!isChosen[0])
            {
                Die6.BackColor = Color.FromArgb(240, 128, 128);
                isChosen[0] = true;
                Count();

            }
            else if (!isLocked[0])
            {
                Die6.BackColor = Color.FromArgb(255, 255, 255);
                isChosen[0] = false;
                Count();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Round();// кнопка "бросить ещё раз"
        }

        private void button5_Click(object sender, EventArgs e) //переход хода следующему игроку
        {
            if (countNum != 0) // проверка на нужность добавления результата из этого хода игрока
            {
                if (firstPlayer) // если был ход игрока 1
                {
                    player1 += countNum + roundNum;
                    textBox2.Text = Convert.ToString(player1);
                    firstPlayer = false;
                    if (player1 <= 4000) // проверка на победу
                    {
                        MessageBox.Show(
                        "Ходит игрок 2",
                        "Переход хода",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                    }
                    else
                    {
                        MessageBox.Show(
                        "Игрок 1 победил",
                        "Конец игры",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                        this.Close();
                    }

                }
                else
                {
                    player2 += countNum + roundNum;
                    textBox3.Text = Convert.ToString(player2);
                    firstPlayer = true;
                    if (player2 <= 4000)
                    {
                        MessageBox.Show(
                        "Ходит игрок 2",
                        "Переход хода",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                    }
                    else
                    {
                        MessageBox.Show(
                        "Игрок 2 победил",
                        "Конец игры",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                        this.Close();
                    }

                }
                makeWhite();
                countNum = 0;
                roundNum = 0;
                CounterRound.Text = Convert.ToString(roundNum);
                Counter.Text = Convert.ToString(countNum);
            }
            else // если ход был потрачен впустую и игроку не повезло
            {
                if (firstPlayer)
                {
                    firstPlayer = false;
                    MessageBox.Show(
                    "Ходит игрок 2",
                    "Переход хода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                }
                else
                {
                    firstPlayer = true;
                    MessageBox.Show(
                    "Ходит игрок 1",
                    "Переход хода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                }
                makeWhite();
                countNum = 0;
                roundNum = 0;
                CounterRound.Text = Convert.ToString(roundNum);
                Counter.Text = Convert.ToString(countNum);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // кнопка выход
        }
        private void button2_Click(object sender, EventArgs e) // кнопка правил игры
        {
            Rules rules = new Rules(); 
            rules.Show();
        }
        private void button3_Click(object sender, EventArgs e) // Кнопка для начала игры
        {
            Die1.Enabled = true;
            Die2.Enabled = true;
            Die3.Enabled = true;
            Die4.Enabled = true;
            Die5.Enabled = true;
            Die6.Enabled = true;
            button3.Visible = false;
            button4.Visible = true;
            button5.Visible = true;
            Round();
        }
    }
}
