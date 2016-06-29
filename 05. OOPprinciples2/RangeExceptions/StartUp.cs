using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeExceptions
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int number = 3000;
            try
            {
                if (number < 1 || number > 100)
                {
                    throw new InvalidRangeException<int>("Invalid input", 1, 100);
                }
            }
            catch (InvalidRangeException<int> ex)
            {

                Console.WriteLine(ex.Message);
            }

            try
            {
                DateTime date = new DateTime(1994, 11, 01);
                if (date < new DateTime(1990, 03, 11) || date > new DateTime(2016, 05, 15))
                {
                    throw new InvalidRangeException<DateTime>("Invalid date",
                    new DateTime(1990, 03, 11), new DateTime(2016, 05, 15));
                }
            }

            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
