using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace _07.Timer
{
    public delegate void SimpleDelegate();
    class StartUP
    {
        

        static void Main(string[] args)
        {
            SimpleDelegate someDelegate = new SimpleDelegate(PrintSmile);
            someDelegate();

            Timer.setInterval(new Action(() => PrintSmile()), 1);
        }

        public static void PrintSmile()
        {
            Console.WriteLine(":-)");
        }

    }
    class Timer
    {
        public int Interval { get; set; }

        public static void setInterval(Action action, int interval)
        {
            while(true)
            {
                Thread.Sleep(interval * 1000);
                action();
            }
        }
    }
}
