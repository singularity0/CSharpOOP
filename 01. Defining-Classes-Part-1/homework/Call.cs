using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class Call
    {
        public string Date { get; set; }
        public string Time { get; set; }
        public string Number { get; set; }
        public int Duration { get; set; }

        public Call(string dateWhenCalled, string timeWhenCalled, string numberCalled, int durationOfCall)
        {
            this.Date = dateWhenCalled;
            this.Time = timeWhenCalled;
            this.Number = numberCalled;
            this.Duration = durationOfCall;
        }

       
    }
}
