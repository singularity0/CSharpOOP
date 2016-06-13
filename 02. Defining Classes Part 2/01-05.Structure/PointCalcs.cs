using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PointCalcs
{
    public class Structure
    {
        static void Main()
        {
            //adding some point with properties
            Point3D somePoint = new Point3D();
            somePoint.X = 3;
            somePoint.Y = 45;
            somePoint.Z = 55;

            //adding another point with constructor
            Point3D anotherPoint = new Point3D(3, 46, 10);

            //Console.WriteLine(somePoint);     //uncomment to test toString()
            //Console.WriteLine(anotherPoint);  //uncomment to test toString()
            //Path.listPoints.Add(somePoint);    //uncomment to test adding to list

            ReadWrite();

            //Console.WriteLine(CalclateDistance.DistanceBwTwoPoints(somePoint, anotherPoint));   // //uncomment to test Distance betwen Points

        }
        public static void ReadWrite()
        {
            StreamReader reader = new StreamReader(@"..\..\input.txt");
            StreamWriter streamWriter = new StreamWriter(@"..\..\output.txt");
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    Console.WriteLine("Read {0}", line);
                    string[] lineParser = line.Split(new string[] { ",", "(", ")", "\n", " " }, StringSplitOptions.RemoveEmptyEntries);
                    Path.listPoints.Add(new Point3D(int.Parse(lineParser[0]), int.Parse(lineParser[1]), int.Parse(lineParser[2])));

                    streamWriter.WriteLine(line);

                    Console.WriteLine("point added to list");
                    line = reader.ReadLine();
                }
            }
            reader.Close();
            streamWriter.Close();
        }
    }

    public struct Point3D
    {
        private static readonly Point3D start = new Point3D( 0,0,0);
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public static Point3D GetStartCoord { get { return start; } }

        public Point3D(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            string template = "({0}, {1}, {2})";
            return string.Format(template, this.X, this.Y, this.Z);
        }
    }

    public static class CalclateDistance
    {
        public static Point3D DistanceBwTwoPoints(Point3D somePoint, Point3D anotherPoint)
        {
            Point3D logic = new Point3D(Math.Abs(somePoint.X - anotherPoint.X), Math.Abs(somePoint.Y - anotherPoint.Y), Math.Abs(somePoint.Z - anotherPoint.Z));
            return logic;
         }
    }

    public static class Path
    {
        public static List<Point3D> listPoints = new List<Point3D>();

    }
}
