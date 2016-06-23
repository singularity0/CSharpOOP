using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    public class Disciplines
    {
        public string NameOfDisc { get; set; }
        public int NumberOfLectures { get; set; }
        public int NumberOfEXcercise { get; set; }

        public Disciplines(string nameDiscpline, int numberOflectures, int numberOfExscercises)
        {
            this.NameOfDisc = nameDiscpline;
            this.NumberOfLectures = numberOflectures;
            this.NumberOfEXcercise = numberOfExscercises;
        }
    }
}
