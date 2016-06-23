using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    public class Students : People
    {
        
        public int StudentID { get; set; }
        public School SchoolName { get; set; }

        public Students(string Fname, string Lname, int studentID, School Schoolname) : base(Fname, Lname)
        {
            this.StudentID = studentID;
            this.SchoolName = Schoolname;
           
        }

    }
}
