using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveNegativeNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PositiveNegativeNum positiveNegativenum = new PositiveNegativeNum();
            Console.Write("Vuvedi chislo: ");
            double number = double.Parse(Console.ReadLine());
            positiveNegativenum.IsPositive(number);
            if (number < 0 && number != 0)
            {
                Console.WriteLine("Chisloto e otricatelno");
            }
            if (number > 0 && number != 0)
            {
                Console.WriteLine("Chisloto e polojitelno");
            }
        }
    }
}
