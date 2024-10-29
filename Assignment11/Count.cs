using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    internal class Count
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7};

            int oddCount = numbers.Count(n => n % 2 != 0);

            Console.WriteLine("The number of odd numbers is: {0}", oddCount);
            Console.ReadLine();
        }
        
    }
}
