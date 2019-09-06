using System;
using System.Collections.Generic;

namespace TricksAspNetCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // TIP 1 - Simple demo to avoid null checking on an Enumerable

            List<string> names = GetNullList();

            foreach (var name in names.OrEmptyIfNull())
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        // Method that could return an null list
        private static List<string> GetNullList() => null;
    }
}
