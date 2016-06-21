using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.LongestString
{
    class StringCounter
    {
        static void Main()
        {
            var arr = new string[] { "some", "another one", "Longest? ?? ", "linq is awesome" };
            var result = arr
                .OrderByDescending(x => x.Length)
                .First();
            Console.WriteLine(result);
        }
    }
}
