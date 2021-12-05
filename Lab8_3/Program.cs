using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\milov\source\repos\Lab8\Lab8_3\file.txt");
            int strNumber = 0;
            int wordNumber = 0;
            int elementNumber = 0;
            foreach (char element in text)
            {
                if (element != '\n' && element != '\r' && element != '\b') elementNumber++;

            }
            foreach (char word in text)
            {
                if (word == ' ' || word == '\n') wordNumber++;

            }
            foreach (char str in text)
            {
                if (str == '\r' || str == '\n') strNumber++;

            }
            Console.WriteLine("Колличество строк: {0} ", strNumber);
            Console.WriteLine("Колличество слов: {0} ", wordNumber);
            Console.WriteLine("Колличество символов: {0} ", elementNumber);
            Console.ReadKey();
        }
    }
}
