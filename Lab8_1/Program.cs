using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Lab8_1
{
    class Program
    {
        static void Main(string[] args)
        {

            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\milov\source\repos\Lab8\Lab8_1");
            ShowInfo(directory);
            Console.ReadKey();
        }
        static void ShowInfo(DirectoryInfo directory)
        {
            Console.WriteLine("ИМЯ КАТАЛОГОВ");
            Console.WriteLine(directory.Name);
            Console.WriteLine("СПИСОК ПОДКАТАЛОГОВ");
            foreach (var catalog in directory.GetDirectories())
            {
                Console.WriteLine(catalog.Name);
            }
            Console.WriteLine("СПИСОК ФАЙЛОВ");
            foreach (var file in directory.GetFiles())
            {
                Console.WriteLine(file.Name);
            }
            foreach (var catalog in directory.GetDirectories())
            {
                ShowInfo(catalog);
              }

        }

    }
}
