using System;
using System.Collections.Generic;

namespace SortList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>{23,45,2,1,56,3};
            foreach(var item in myList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            myList.Sort();
            
            foreach(var item in myList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
