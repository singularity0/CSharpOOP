using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class GSMTest
    {
        static void Main()
        {
            GSM cellSamsung = new GSM("6s", "Samsung", 1199.99, "pcSHop", new Battery(BatteryType.Unknown, "a123asw", 200, 24), new Display(12.4, 5000000));
            GSM cellTelefunken = new GSM("NovaStar", "Telefunken", 399.99, "Technopolis", new Battery(BatteryType.Li_Ion, "a1dd23asw", 100, 14), new Display(12.4, 5000000));
            GSM cellLG = new GSM("Nexus", "LG");
            PrintCellPhones();
            PrintIphoneDetails();
            CallHistoryTest.TestCallHistory();
        }
        private static void PrintCellPhones()
        {
            for (int i = 0; i < GSM.listGSM.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine(new string('*', 15));
                Console.WriteLine(GSM.listGSM[i]);
                Console.WriteLine(new string('*', 15));  
            }
        }
        private static void PrintIphoneDetails()
        {
            Console.WriteLine(GSM.Iphone7);
            Console.WriteLine();
        }
    }
}
