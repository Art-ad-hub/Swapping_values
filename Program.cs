using System;
using System.CodeDom.Compiler;
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
            string firstname = "Петров";
            string lastName = "Денис";
            string intervalValue = firstname;
            firstname = lastName;
            lastName = intervalValue;

            Console.WriteLine($"Ваше имя {firstname}, а ваша фамилия {lastName}.");
            Console.ReadKey();
        }
    }
}