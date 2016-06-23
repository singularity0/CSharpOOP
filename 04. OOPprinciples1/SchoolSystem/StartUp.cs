using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    class StartUp
    {
        static void Main()
        {
            var OurSchool = new School("Advanced Programming School");

            var Jorko = new Students("Gerogi", "Kolev", 123, OurSchool);
            var Ganka = new Students("Gana", "Popova-Hristova", 120, OurSchool);
            var Haralampi = new Students("Haralampi", "Anev", 150, OurSchool);
            var Maria = new Students("Maria", "Yonova", 130, OurSchool);

            var disciplineENglish = new Disciplines("English", 10, 12);
            var disciplineProgramming = new Disciplines("Programming", 30, 42);

            var MrTonev = new Teachers("Anatolyii", "Tonev", new List<Disciplines> { disciplineENglish, disciplineProgramming });
            var MrsZlateva = new Teachers("Zlatina", "Zlateva", new List<Disciplines> { disciplineProgramming });

            var FifhtGrade = new Class(new List<Students> { Jorko, Ganka }, new List<Teachers> { MrTonev });
            var SixthGrade = new Class(new List<Students> { Haralampi, Maria }, new List<Teachers> { MrTonev, MrsZlateva });

            Console.WriteLine("Print all stidetns in the school:");
            Students[] listOfStudents = new Students[4] { Jorko, Ganka, Haralampi, Maria };
            foreach (var item in listOfStudents)
            {
                Console.WriteLine(item.toString());
            }
            Console.WriteLine();
            Console.WriteLine("Print all subjects that MrTonev is a teacher for:");
            foreach (var item in MrTonev.Disciplines)
            {
                Console.WriteLine(item.NameOfDisc);
            }

        }
    }
}
