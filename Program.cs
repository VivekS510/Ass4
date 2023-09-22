using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c = 30;
            Console.WriteLine("Enter first temperature: ");
            int temp1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second temperature: ");
            int temp2 = Convert.ToInt32(Console.ReadLine());
            if (temp1 > 100 && temp2 < 0 || temp1 < 0 && temp2 > 100)
            {
                Console.WriteLine("True");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("False");
                Console.ReadLine();
            }
        }
    }
}
