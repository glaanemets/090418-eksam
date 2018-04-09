using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _090418_eksam_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "kaur", "mattias", "kristel",
                "heleri", "trevor", "kristjan", "kelli", "kevin", "maarika", "laura" };

            string input = Console.ReadLine();


            for (int i = 0; i < names.Count(); i++)
            {
              string[] xx = Regex.Split(input, names[i]);

                input = string.Join(UppercaseFirst(names[i]), xx);
            }
            Console.WriteLine($"{input}");
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
