﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _090418_eksam
{
    class Program //yl 1
    {
        static void Main(string[] args)
        {
            List<string> nimed = new List<string>();
            do
            {
                nimed.Add(UppercaseFirst(Console.ReadLine()));

            } while (nimed.ElementAt(nimed.Count() - 1) != "-1");

            nimed.RemoveAt(nimed.Count() - 1);

            for (int i = 0; i < nimed.Count(); i++)
            {
                Console.WriteLine($"{nimed.ElementAt(i)}");

            }
            Console.ReadKey();
        }

        static string UppercaseFirst(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }


    }
}
