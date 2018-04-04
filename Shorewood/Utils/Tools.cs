using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Animalerie.Utils
{
    class Tools
    {
        readonly static ConsoleColor baseColor = ConsoleColor.White;

        public static string ReadString(int x, int y, int speed, string text)
        {
            string answer = "";
            do
            {
                Animated(x, y, speed, text);
                answer = Console.ReadLine();
                if (string.IsNullOrEmpty(answer))
                    RemoveRange(x, x);
            } while (string.IsNullOrEmpty(answer));

            return answer;
        }
        public static double ReadNumber(int x, int y, int speed, string text)
        {

            double answer = 0.0;
            do
            {
                Animated(x, y, speed, text);
                double.TryParse(Console.ReadLine(), out answer);
                if (answer==0)
                    RemoveRange(x, x);
            } while (answer == 0);

            return answer;
        }
        public static void Animated(int x, int y, int speed, string text)
        {
            int initialX = x;
            Console.SetCursorPosition(x, y);
            foreach(char c in text.ToCharArray())
            {
                if (c == '\n')
                {
                    y++;
                    x = initialX;
                    Console.SetCursorPosition(x, y);
                }else
                {
                    Console.Write(c);
                    Console.SetCursorPosition(++x, y);
                    Thread.Sleep(speed);
                }
            }
        }
        public static void Animated(int x, int y, int speed, string text, ConsoleColor color)
        {
            int initialX = x;
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            foreach (char c in text.ToCharArray())
            {
                if (c == '\n')
                {
                    y++;
                    x = initialX;
                    Console.SetCursorPosition(x, y);
                }
                else
                {
                    Console.Write(c);
                    Console.SetCursorPosition(++x, y);
                    Thread.Sleep(speed);
                }
            }
            Console.ForegroundColor = baseColor;
        }
        
        public static void RemoveRange(int y, int Y)
        {
            for (int i = y; i <= Y; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(new string(' ', Console.BufferWidth));
            }
        }
        public static void RemoveSquare(int x, int X, int y, int Y, string text="")
        {
            if (!string.IsNullOrEmpty(text))
            {
                Animated(x, Y, 5, text);
                Console.ReadKey();
            }
            
            for (int i = y; i <= Y; i++)
            {
                Console.SetCursorPosition(x, i);
                Console.Write(new string(' ', X-x));
            }
        }
        public static void Continue(int x, int y, int speed)
        {
            Animated(x, y, speed, "Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
