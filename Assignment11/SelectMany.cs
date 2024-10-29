//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assignment11
//{
//    internal class SelectMany
//    {
//        public static void Main(string[] args)
//        {
//            List<List<int>> listOfLists = new List<List<int>>
//        {
//            new List<int> { 1, 2, 3 },
//            new List<int> { 4, 5 },
//            new List<int> { 6, 7, 8, 9,10 }
//        };

//            var flattenedList = listOfLists.SelectMany(innerList => innerList).ToList();

//            foreach (var number in flattenedList)
//            {
//                Console.WriteLine(number);
//            }
//            Console.ReadLine();
//        }
        
//    }
//}
