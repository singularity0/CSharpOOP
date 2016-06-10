using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class CallHistoryTest
    {
        public static void TestCallHistory()
        {
            GSM motorola = new GSM("nexus", "Motorola", 500, "comapny phone", new Battery(BatteryType.NiCd), new Display(5, 2000));
            GSM newBrand = new GSM("SSD", "MegaHyper");

            motorola.AddCall(new Call("12/03/2015", "05:34", "0889888888", 100));
            motorola.AddCall(new Call("02.02.2012", "12:34", "0999999999", 140));
            motorola.AddCall(new Call("12.30.2012", "00:34", "0999999999", 12));
            ShowCalls(motorola.calls);
            Console.WriteLine("The Total Price is {0}",  motorola.CalculateTotalPrice());
            motorola.FindAndRemoveLongestCall();
            Console.WriteLine("Longest call now removed");
            Console.WriteLine("The Total Price is {0:F2}", motorola.CalculateTotalPrice());
            motorola.ClearHistory();
            Console.WriteLine("Call history deleted");
        }
        public static void ShowCalls(List<Call> li)
        {
            foreach (var item in li)
            {
                Console.WriteLine("Date: {0}", item.Date);
                Console.WriteLine("Time: {0}", item.Time);
                Console.WriteLine("Phone Number Called: {0}", item.Number);
                Console.WriteLine("Duration: {0}", item.Duration);
                Console.WriteLine(new string('*', 40));
            }
        }
       
    }
}
