using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeExceptions
{
    public class InvalidRangeException<T> : ArgumentException
    {
        private T start;
        private T end;

        public T Start
        {
            get { return this.start; }
            set { this.start = value; }
        }

        public T End
        {
            get { return this.end; }
            set { this.end = value; }
        }

        public InvalidRangeException(string message, T start, T end, Exception inner) :base(message, inner)
        {
            this.Start = start;
            this.End = end;

        }

        public InvalidRangeException(string message, T start, T end)
            : base(message)
        {

        }
    }
}
