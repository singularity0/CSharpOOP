using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FirstBeforeLast
{
    class FirstBeforeLast
    {
        static void Main()
        {
            var firstStudent = new Student("Gosho", "Petrov", 14);
            var secondStudent = new Student("Ganka", "Huliganka", 20);
            var thirdStudent = new Student("Haralampi", "Belqta", 23);

            var students = new[] { firstStudent, secondStudent, thirdStudent };

            var queryFirstBeforeLAst = students
                .Where(x => x.FirstName.CompareTo(x.LastName) == -1);
            foreach (var item in queryFirstBeforeLAst)
            {
                Console.WriteLine(item.FullName);
            }
            Console.WriteLine(new string('*', 20));

            var queryAgeBtw18And24 = students
                .Where(x => x.Age > 18 && x.Age < 24)
                .Select(x=> x.FullName )
                .ToList();
            foreach (var item in queryAgeBtw18And24)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('*', 20));
            var queryFirstLAstName = students
                .OrderByDescending(x => x.FirstName)
                .ThenByDescending(x => x.LastName)
                .Select(x => x.FullName);
            foreach (var item in queryFirstLAstName)
            {
                Console.WriteLine(item);
            }

            var queryFirstLast = from student in students
                                 orderby student.FirstName, student.LastName
                                 select student;
            foreach (var item in queryFirstLast)
            {
                Console.WriteLine(item.FullName);
            }

        }
    }

    public class Student
    {
        public string FirstName {get; set;}
        public string LastName { get; set; }
        public int Age { get; set; }

        public Student(string firstname, string lastname, int age)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Age = age;
        }

        public string FullName
        {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
        }
        
    }


}
