using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class Battery
    {
        private string model;
        private int hoursIdle;
        private int hoursTalk;
        private BatteryType typeBattery;

        public Battery(BatteryType typeBattery = BatteryType.Unknown, string model = "n/a", int hoursIDLEtime = 0, int hoursTALKtime = 0)
        {
            this.model = model;
            this.hoursIdle = hoursIDLEtime;
            this.hoursTalk = hoursTALKtime;
            this.typeBattery = typeBattery;
        }

        public string HoursTalk
        {
            get
            {
                return this.model;
            }
            set
            {
                if ( this.hoursTalk > 1000 )
                {
                    throw new ArgumentException("Fenomenal time. if this is a smartphone go patent this now. (and then open-source it)");
                }
            }
        }
        public string Model { get { return this.model; } set { this.model = value; } }
        public int HoursIdle { get { return this.hoursTalk; } set { this.hoursTalk = value; } }
        public BatteryType TypeBattery { get { return this.typeBattery; } set { this.typeBattery = value; } }
    }
}
