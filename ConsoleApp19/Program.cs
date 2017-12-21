using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp19
{
    class Program
    {
        static void Task1()
        {
            Dictionary<char, int> all = new Dictionary<char, int>();
            char[] mas;
            using (FileStream stream = new FileStream(@"C:\Users\madik\Documents\Visual Studio 2017\projects\ConsoleApp19\test.txt", FileMode.Open))
            {
                byte[] bytes = new byte[stream.Length];
                stream.Read(bytes, 0, bytes.Length);
                mas = Encoding.UTF8.GetChars(bytes);
                for (int i = 0; i < mas.Length; i++)
                {
                    if (!all.ContainsKey(mas[i]))
                    {
                        all.Add(mas[i], 1);
                    }
                    else
                    {
                        all[mas[i]]++;
                    }
                }
            }
            foreach (KeyValuePair<char, int> value in all)
            {
                Console.WriteLine(value);
            }
        }

        static void Task2()
        {
            using (StreamWriter stream = new StreamWriter(@"C:\Users\madik\Documents\Visual Studio 2017\projects\ConsoleApp19\test2.txt"))
            {
                stream.WriteLine("mad");
                stream.WriteLine("madik");
                stream.WriteLine("404error");
            }
        }

        static void Main(string[] args)
        {
            Task1();
            Task2();
            Console.ReadLine();
        }
    }
}
