using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Products in stock");
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Ürün1", "Apple");
            dictionary.Add("Ürün2", "Watermelon");
            dictionary.Add("Ürün3", "Banana");
            dictionary.Add("Ürün4", "Orange");



            foreach (var value in dictionary.Value)
            {
                Console.WriteLine(value);
            }

        }
    }
}