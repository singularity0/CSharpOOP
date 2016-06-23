using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    public class Class : IComment
    {
        protected List<Teachers> teachers = new List<Teachers>();
        protected List<Students> students = new List<Students>();

        public Class(List<Students> studentsList, List<Teachers> teachers)
        {
            this.students = studentsList;
            this.teachers = teachers;
        }

        public string Comment { get { return "class Comment"; } set { this.Comment = value; } }
    }
}
