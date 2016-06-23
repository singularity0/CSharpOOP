using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    public class Teachers : People
    {
        protected internal List<Disciplines> Disciplines { get; set; }
        //public Class ClassID {get; set;}

        public Teachers(string Fname, string Lname, List<Disciplines> someDisc) : base(Fname, Lname)
        {
            this.Disciplines = someDisc;

        }
    }
}
