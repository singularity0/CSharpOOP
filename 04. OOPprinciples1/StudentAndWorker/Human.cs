using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAndWorker
{
    public abstract class Human
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }


        public Human(string fname, string lname)
        {
            this.Firstname = fname;
            this.Lastname = lname;
        }
    }
}
