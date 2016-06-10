using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class Display
    {
        private double size;
        private int numberColor;

        public Display(double size, int colorNum)
        {
            this.size = size;
            this.numberColor = colorNum;
        }

        public double Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (this.size < 0)
                {
                    throw new ArgumentOutOfRangeException("impossible size");
                }
                else if (size > 17)
                {
                    throw new ArgumentOutOfRangeException("impossible size: item is with the size of a monitor/TV");
                }
                this.size = value;
            }
        }
        public int NumberColor
        {
            get
            {
                return this.numberColor;
            }
            set
            {
                if (this.numberColor < 0)
                {
                    throw new ArgumentOutOfRangeException("Not even 2 colors ?");
                }
                else if(this.numberColor > 20000000)
                {
                    throw new ArgumentOutOfRangeException("what a waste. Human can only understand upto 16M");
                }
            }
        }


    }
}
