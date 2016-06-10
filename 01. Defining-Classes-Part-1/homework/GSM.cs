using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class GSM
    {
        private string model;
        private string manufacturer;
        private double price;
        private string owner;
        private Battery battery;
        private Display display;
        private static string iphone7 = "=> Iphone7 <= ";
        public static List<GSM> listGSM = new List<GSM>();
        public List<Call> calls;
        private const double pricePerMinute = 0.37d;


        public GSM(string model, string manif)
        {
            this.model = model;
            this.manufacturer = manif;
            listGSM.Add(this);
            this.calls = new List<Call>();
        }
    

        public GSM(string modelOfItem, string manif, double priceItem, string ownerOfItem, Battery battery, Display display) : this(modelOfItem, manif)
        {
            this.price = priceItem;
            this.owner = ownerOfItem;
            this.battery = battery;
            this.display = display;

        }

        public string Manufacturer
        {
            get
            {
                if (Array.IndexOf(new string[] { "Nokia", "BlackBurry" }, this.manufacturer) != -1)
                {
                    throw new ArgumentException(string.Format("Producer {0} not supported currently.", this.manufacturer.ToUpper()));
                }
                return this.manufacturer;
            }
            set
            {
                if (Array.IndexOf(new string[] { "Nokia", "BlackBurry" }, value) != -1)
                {
                    throw new ArgumentException("Producer not supported currently.");
                }
            }
        }
        public static string Iphone7
        {
            get
            {
                return iphone7 + "is an amazing phone!";
            }
        }
        public List<Call> CallHistory
        {
            get
            {
                return this.calls;
            }
        }
        public string  Model { get { return this.model; } private set { this.model = value; } }
        public double Price { get { return this.price; } private set { this.price = value; } }  // any reseller could sell on a whatever price they want
        public string Owner { get { return this.owner; } private set { this.owner = value; } } //items could be re-sold freely
        public BatteryType BatteryType { get { return this.battery.TypeBattery; } }
        public Display DisplayInfo { get { return this.display; } }
        public void ClearHistory()
        {
            this.calls = new List<Call>();
        }
        public void AddCall(Call someCall)
        {
            calls.Add(someCall);
        }
        public void DeleteCall(Call someCall)
        {
            calls.Remove(someCall);
        }
        public double CalculateTotalPrice()
        {

            double totalSumSeconds = default(double); 
            foreach (var item in this.calls)
            {
                totalSumSeconds += item.Duration;
            }
            double pricePerSEcond = pricePerMinute / 60;
            return totalSumSeconds * pricePerSEcond;
        }
        public void FindAndRemoveLongestCall()
        {
            int longest = calls[0].Duration;
            int indexLogest = 0;
            for(int item = 0; item < calls.Count; item++)
            {
                if (calls[item].Duration > longest)
                {
                    longest = calls[item].Duration;
                    indexLogest = item;
                }
            }
            calls.Remove(calls[indexLogest]);
            
        }

        public override string ToString()
        {
            string template;
            string formatedTemplate;
            if (this.Price == 0.00)
            {
                template = "Model: {0}\nManufacturer: {1}\n";
                formatedTemplate = string.Format(template, this.Model, this.Manufacturer);
            }
            else
            {
                
                template = "Model: {0}\nManufacturer: {1}\nPrice: {2}\nOwner: {3}\nBattery Type: {4}\nBattery Active Time: {5}\nDisplay size: {6}";
                formatedTemplate = string.Format(template, this.Model, this.Manufacturer, this.Price, this.owner, this.battery.TypeBattery, this.battery.HoursTalk, this.display.Size);
            }
            
            return formatedTemplate;
        }

        public int this[int indexer]
        {
            get
            {
                return this[indexer];
            }
            
        }

    }
}
