using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _090418_eksam_4
{
    class Program
    {
        static void Main(string[] args)
        {


        }

        public List<DateTime> GenerateTimestamps(int amount, int maxY, int minY)
        {
            int[] monthMax = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            Random rnd = new Random();
            int month, day, year;

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
            return times;
        }

        public int FindOldest(List<DateTime> times)
        {
            int age = 10;

            for (int i = 0; i < times.Count(); i++)
            {
                age = DateTime.Now.Year - times.ElementAt(i).Year;
            }
            
            return age;
        }
    }
}
