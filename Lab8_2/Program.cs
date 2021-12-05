using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\milov\source\repos\Lab8\Lab8_2\file.txt");
            Random nunber = new Random();
            for (int i = 0; i < 10; i++)
            {
                file.WriteLine(nunber.Next(0,100));
            }
            file.Close();
            StreamReader file1 = new StreamReader(@"C:\Users\milov\source\repos\Lab8\Lab8_2\file.txt");
            int S=0;
            for (int i = 0; i < 10; i++)
            {
                S += Convert.ToInt32(file1.ReadLine());
            }
            file1.Close();
            Console.WriteLine("Сумма чисел равна {0} ", S);
            Console.ReadKey();
        }
    }
}
