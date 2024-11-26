using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Yulia";
            string str2 = "yulia"; 
            string str3 = "Yulia Karamova";
            string str4 = "Yulia";

            int comp = String.Compare(str1, str2);
            if (comp < 0)
            {
                Console.WriteLine($"Строка '{str1}' меньше строки '{str2}'.");
            }
            else if (comp > 0)
            {
                Console.WriteLine($"Строка '{str1}' больше строки '{str2}'.");
            }
            else
            {
                Console.WriteLine($"Строка '{str1}' равна строке '{str2}'.");
            }

            if (str1.Equals(str4))
            {
                Console.WriteLine($"Строка '{str1}' равна строке '{str4}'.");
            }
            else
            {
                Console.WriteLine($"Строка '{str1}' не равна строке '{str4}'.");
            }

            int ordinalComparison = String.CompareOrdinal(str1, str2);
            if (ordinalComparison == 0)
            {
                Console.WriteLine($"Строка '{str1}' и строка '{str2}' равны.");
            }
            else
            {
                Console.WriteLine($"Строка '{str1}' и строка '{str2}' не равны.");
            }

            int index = str3.IndexOf("Maximovna");
            if (index != -1)
            {
                Console.WriteLine($"Слово 'Maximovna' найдено в строке '{str3}' на индексе.");
            }
            else
            {
                Console.WriteLine($"Слово 'World' не найдено в строке '{str3}'.");
            }

            if (str3.Contains("Maximovna"))
            {
                Console.WriteLine($"Строка '{str3}' содержит 'Maximovna'.");
            }
            else
            {
                Console.WriteLine($"Строка '{str3}' не содержит 'Maximovna'.");
            }

            if (str1 == str4)
            {
                Console.WriteLine($"Строка '{str1}' равна строке '{str4}'.");
            }
            else
            {
                Console.WriteLine($"Строка '{str1}' не равна строке '{str4}'.");
            }

            if (str1 != str2)
            {
                Console.WriteLine($"Строка '{str1}' не равна строке '{str2}'.");
            }
            else
            {
                Console.WriteLine($"Строка '{str1}' равна строке '{str2}'.");
            }
            Console.ReadLine();
        }
    }
}
