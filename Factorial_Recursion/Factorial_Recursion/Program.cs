using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value to find the Factorial in recursion Method");
            string number = Console.ReadLine();
            int num = Convert.ToInt32(number);
            int result = Factorial(num);
            Console.WriteLine("Factrial value is:{0}", result);
            Console.Read();
        }

        private static int Factorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            return num * Factorial(num - 1);
        }
    }
}
