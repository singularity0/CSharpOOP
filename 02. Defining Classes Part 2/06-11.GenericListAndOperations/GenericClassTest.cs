using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_11.GenericListAndOperations
{
    class GenericClassTest
    {
        static void Main()
        {
            GenericClass<int> intList = new GenericClass<int>(3);
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            intList.Min<int>();
            intList.Max<int>();
            Console.WriteLine(intList);
            intList.Add(5);
            Console.WriteLine(intList);
            //Console.WriteLine(intList.FindIndexOfElement(3));

            MatrixGeneric<int> matrix = new MatrixGeneric<int>(4);
            matrix[0, 0] = 4;
            MatrixGeneric<int> anotherMatrix = new MatrixGeneric<int>(4);
            matrix[0, 0] = 5;
            
        }

        
    }
}
