using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _090418_eksam_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] monthMax = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            Random rnd = new Random();
            int month, day, year;

            Console.WriteLine("min");
            int minY = int.Parse(Console.ReadLine());

            Console.WriteLine("max");
            int maxY = int.Parse(Console.ReadLine());

            Console.WriteLine("amount of data");
            int amount = int.Parse(Console.ReadLine());

            List<DateTime> times = new List<DateTime>();

            for (int i = 0; i <= amount; i++)
            {
                year = rnd.Next(minY, maxY);
                month = rnd.Next(1, 13);
                if (DateTime.IsLeapYear(year) && month == 2)
                {
                    day = rnd.Next(1, 29);
                }
                else
                {
                    day = rnd.Next(1, monthMax[month - 1]);
                }
                

                times.Add(new DateTime(year, month, day));
            }


        }
    }
}
