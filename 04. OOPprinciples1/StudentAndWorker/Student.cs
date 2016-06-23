using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAndWorker
{
    public class Student : Human
    {
        public int Grade { get; set; }
        public Student(string fname, string lname, int grade) : base(fname, lname)
        {
            this.Grade = grade;
        }
    }
}
