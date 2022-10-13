using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pianino
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Добро пожаловать в программу \"Пианино\"");
            Console.WriteLine("Выберите октаву:");
            Console.WriteLine(" F3 - Третья октава");
            Console.WriteLine(" F5 - Пятая октава");
            Console.WriteLine("Для выхода нажмите \"Enter\"");
            ConsoleKeyInfo oktava = Console.ReadKey();
            ConsoleKeyInfo knopka = Console.ReadKey();
            int[] thirdoktave = new int[]
            { 132, 139, 147, 156, 165, 175, 185, 196, 208, 220, 233, 247 };
            int[] fifthoktave = new int[]
            { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 978 };
            IzmOktave(fifthoktave, thirdoktave);
            if (knopka.Key == ConsoleKey.Enter)
            {
                Environment.Exit(0);
            }
            Console.WriteLine("Для выбора октавы нажмите: \"F3\" или \"F5\"");
        }
        static void IzmOktave(int[] thirdoktave, int[] fifthoktave)
        {
             ConsoleKeyInfo oktava = Console.ReadKey();
             if (oktava.Key == ConsoleKey.F3)
             {
                Zvuk3(thirdoktave, fifthoktave);
             }
             else if (oktava.Key == ConsoleKey.F5)
             {
                Zvuk5(fifthoktave, thirdoktave);
             }
        }
        static void Zvuk3(int[] thirdoktave, int[] fifthoktave)
        {
            while (true)
            {
                ConsoleKeyInfo oktava = Console.ReadKey();
                if (oktava.Key == ConsoleKey.Q)
                {
                    Console.Beep(thirdoktave[0], 250);
                }
                else if (oktava.Key == ConsoleKey.W)
                {
                    Console.Beep(thirdoktave[1], 250);
                }
                else if (oktava.Key == ConsoleKey.E)
                {
                    Console.Beep(thirdoktave[2], 250);
                }
                else if (oktava.Key == ConsoleKey.R)
                {
                    Console.Beep(thirdoktave[3], 250);
                }
                else if (oktava.Key == ConsoleKey.T)
                {
                    Console.Beep(thirdoktave[4], 250);
                }
                else if (oktava.Key == ConsoleKey.Y)
                {
                    Console.Beep(thirdoktave[5], 250);
                }
                else if (oktava.Key == ConsoleKey.U)
                {
                    Console.Beep(thirdoktave[6], 250);
                }
                else if (oktava.Key == ConsoleKey.I)
                {
                    Console.Beep(thirdoktave[8], 250);
                }
                else if (oktava.Key == ConsoleKey.O)
                {
                    Console.Beep(thirdoktave[9], 250);
                }
                else if (oktava.Key == ConsoleKey.P)
                {
                    Console.Beep(thirdoktave[10], 250);
                }
                else if (oktava.Key == ConsoleKey.L)
                {
                    Console.Beep(thirdoktave[11], 250);
                }
                if (oktava.Key == ConsoleKey.F5)
                {
                    Zvuk5(fifthoktave, thirdoktave);
                }
                Console.Clear();
                Console.WriteLine("Для смены октавы нажмите: \"F5\"");
            }
        }
        static void Zvuk5(int[] fifthoktave, int[] thirdoktave)
        {
            while (true)
            {
                ConsoleKeyInfo oktava = Console.ReadKey();
                if (oktava.Key == ConsoleKey.Q)
                {
                    Console.Beep(fifthoktave[0], 250);
                }
                else if (oktava.Key == ConsoleKey.W)
                {
                    Console.Beep(fifthoktave[1], 250);
                }
                else if (oktava.Key == ConsoleKey.E)
                {
                    Console.Beep(fifthoktave[2], 250);
                }
                else if (oktava.Key == ConsoleKey.R)
                {
                    Console.Beep(fifthoktave[3], 250);
                }
                else if (oktava.Key == ConsoleKey.T)
                {
                    Console.Beep(fifthoktave[4], 250);
                }
                else if (oktava.Key == ConsoleKey.Y)
                {
                    Console.Beep(fifthoktave[5], 250);
                }
                else if (oktava.Key == ConsoleKey.U)
                {
                    Console.Beep(fifthoktave[6], 250);
                }
                else if (oktava.Key == ConsoleKey.I)
                {
                    Console.Beep(fifthoktave[8], 250);
                }
                else if (oktava.Key == ConsoleKey.O)
                {
                    Console.Beep(fifthoktave[9], 250);
                }
                else if (oktava.Key == ConsoleKey.P)
                {
                    Console.Beep(fifthoktave[10], 250);
                }
                else if (oktava.Key == ConsoleKey.L)
                {
                    Console.Beep(fifthoktave[11], 250);
                }
                if (oktava.Key == ConsoleKey.F3)
                {
                    Zvuk3(thirdoktave, fifthoktave);
                }
                Console.Clear();
                Console.WriteLine("Для смены октавы нажмите: \"F3\"");
            }
        }
    }
}