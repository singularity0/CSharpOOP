using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAndWorker
{
    public class Worker : Human
    {
        public float WeekSalary { get; set; }
        public float WorkHoursPerDay { get; set; }

        public Worker(string fname, string lname, float salaryWeek, float dailyHours) : base(fname, lname)
        {
            this.WeekSalary = salaryWeek;
            this.WorkHoursPerDay = dailyHours;
        }

        public float MoneyEarnedPerHour()
        {
            var result = WeekSalary / (WorkHoursPerDay * 5);
            return result;
        }

    }
}
