using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StringBuilderExtensionSubstr
{
    class Substring
    {
        static void Main(string[] args)
        {
            var TestBuilder = new StringBuilder("Some test sample");
            Console.WriteLine(TestBuilder.SubstringStrinB(2,2).ToString());
        }
    }

    public static class StringExtension
    {
        public static StringBuilder SubstringStrinB(this StringBuilder str, int index, int length)
        {
            var builder = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                index = index + i;
                builder.Append(str[index].ToString());
            }
            return builder;
            
        }
    }
}
