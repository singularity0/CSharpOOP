using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class StartUp
    {
        static void Main()
        {
            var shapes = StartUp.GenerateSomeShapesInList();
            IterateList(shapes);
        }

        public static List<Shapes> GenerateSomeShapesInList()
        {
            Shapes triangle = new Triangle(3, 4);
            Shapes square = new Square(2);
            Square squareAnother = new Square(3, 3);
            //Shapes squareVariant2 = new Square(2, 4);  //raises an exception when created as values are diff
            Shapes rectangle = new Rectagle(3, 4);
            List<Shapes> shapesList = new List<Shapes> { triangle, rectangle, square, squareAnother };
            return shapesList;
        }
        public static void IterateList(List<Shapes> shapeList )
        {
            foreach (var item in shapeList)
            {
                Console.WriteLine(item.CalculateSurface());
            }
        }

    }
}
