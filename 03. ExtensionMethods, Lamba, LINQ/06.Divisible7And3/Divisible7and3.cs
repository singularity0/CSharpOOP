using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Divisible7And3
{
    class Divisible7and3
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 3, 45, 6, 8, 56, 777, 88, 7, 21, 42 };

            var result = list.FindAll(x => x % 3 == 0 && x % 7 == 0).Select(x => x).ToArray();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
