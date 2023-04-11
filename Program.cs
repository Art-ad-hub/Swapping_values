using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping_values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Петров";
            string lastName = "Денис";

            Console.WriteLine($"Ваше имя {name}, а ваша фамилия {lastName}.");
            Console.WriteLine("О нет, похоже что ваши данные перепутанны, давайте исправим?");
            Console.Write("Введите  ваше имя: ");
            name = Console.ReadLine();
            Console.Write("Введите  вашу фамилию: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Теперь должно быть правильно!");
            Console.WriteLine($"Ваше имя {name}, а фамилия {lastName}.");
            Console.ReadKey();
        }
    }
}
