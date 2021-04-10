using System;
using System.Collections.Generic;

namespace Iterator
{
    class Program

    {
        class Iterator
        {
            public static IEnumerable<string> GetArray()
            {
                int[] tablica = new int[] { 5, 7, 6, 9, 1 };
                
                foreach (var element in tablica)
                {
                    yield return element.ToString(); 
                }
            }
            public static void Main(string[] args)
            {
                IEnumerable<string> elements = GetArray();
                foreach (var element in elements) 
                {
                    Console.WriteLine(element);
                }
            }
        }
    }
}