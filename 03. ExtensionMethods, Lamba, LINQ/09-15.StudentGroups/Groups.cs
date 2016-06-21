using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.StudentGroups
{
    public class Groups
    {
        static void Main(string[] args)
        {
            var students = new Student[] { new Student("Ganka", "Pencheva", "2006", "+3592", "ganka@abv.bg", new List<int>{2,2 }, 2 ),
                new Student("Galabankaka", "Pencheeeeva", "2006", "0888", "galabanka@abmv.bg", new List<int>{4,6}, 2 ),
                new Student("Gaa", "Pip", "12322", "0887", "ga@abv.bg", new List<int>{6,6,100 }, 3 )
            };
            Console.WriteLine("EXtract students By group == 2");

            var group2 = students
                .Where(x => x.GroupNumber == 2)
                .Select(x => x.FirstName + " " + x.LastName);

            foreach (var item in group2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('*', 25));
            List<Student> someListSts = new List<Student>(students).ExtractAndOrder();

            foreach (var item in someListSts)
            {
                Console.WriteLine(item.FirstName + " " +  item.LastName);
            }
            Console.WriteLine(new string('*', 25));

            var extractByAbvBg = students
                .Where(x => x.Email.EndsWith("abv.bg"))
                .Select(x => x.FirstName + " " + x.LastName);

            foreach (var item in extractByAbvBg)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine(new string('*', 25));
            Console.WriteLine("With phone nums in Sofia:");
            var extractBySofia = students
                .Where(x => x.Telephone.StartsWith("+3592") || x.Telephone.StartsWith("02"))
                .Select(x => x.FirstName + " " + x.LastName);

            foreach (var item in extractBySofia)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Students with at least one mark 6");
            var withMark6 = students.Where(x => x.Marks.Contains(6)).
                Select(x => new { x.FirstName, x.Marks });
            foreach (var item in withMark6)
            {
                Console.WriteLine(item.FirstName);
            }

            Console.WriteLine();
            Console.WriteLine("Students with excatly 2 marks = 2:");
            var withExactly22 = students.Where(x => x.Marks.Count == 2)
                .Where(x => x.Marks[0] == x.Marks[1] && x.Marks[0] == 2)
                .Select(x => x.LastName);
            foreach (var item in withExactly22)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("students from 2006:");
            var class2006 = students
                .Where(x => x.FN.EndsWith("06"))
                .Select(x => new { x.FirstName, x.LastName });

            foreach (var item in class2006)
            {
                Console.WriteLine(item.FirstName);
            }

        }
    }
    public class Student
    {
        public string FirstName {get; set;}
        public string LastName { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public List<int> Marks { get; set; }
        public string FN { get; set; }
        public int GroupNumber { get; set; }


        public Student(string fristname, string lastname, string FN, string tel, string email, List<int> marks,  int groupNumber)
        {
            this.FirstName = fristname;
            this.LastName = lastname;
            this.Telephone = tel;
            this.Email = email;
            this.Marks = new List<int>(marks);
            this.GroupNumber = groupNumber;
            this.FN = FN;
        }


    }

    public static class StudentExtensions
    {
        public static List<Student> ExtractAndOrder(this List<Student> stCollection)
        {
            var group = from student in stCollection
                        where student.GroupNumber == 2
                        select student;

            return new List<Student>(group);
        }
    }
}
