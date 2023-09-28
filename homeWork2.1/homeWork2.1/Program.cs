using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text;
            Console.WriteLine("Что?");
            text = Console.ReadLine();

            int quantity;
            Console.WriteLine("Сколько?");
            quantity = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < quantity; i++)
            {
                Console.WriteLine(text);
            }
        }
    }
}
