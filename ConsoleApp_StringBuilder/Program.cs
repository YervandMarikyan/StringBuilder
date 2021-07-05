using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder();

            Write("Enter Your name: ");
            builder.Append("Hello " + ReadLine());
            Write("Enter Your age: ");
            builder.Append("\nYour age is - " + int.Parse(ReadLine()));
            Write("Enter Your birthplace: ");
            builder.Append("\nYour birthplace is - " + ReadLine());
            Write("Enter Your Profession: ");
            builder.Append("\n" + ReadLine() + " is a good Profession");
            Write("Enter Your horoscope sign: ");
            builder.Append("\nYour horoscope is " + char.Parse(ReadLine()));
            Write("Enter Your bank account balance: ");
            builder.Append($"\nYou have {decimal.Parse(ReadLine())} in your account");
            string s = builder.ToString();
            string[] s1 = s.Split('\n');

            ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < s1.Count() - 1; i++)
            {
                SetCursorPosition((WindowWidth - s1[i].Length) / 2, WindowHeight / 2 + i);
                WriteLine(s1[i]);
            }
        }
    }
}
