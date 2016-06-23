using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Kitten : Cat
    {
        private string gender;
        public Kitten(string name, string genderr, int age) : base(name, genderr, age)
        {
            this.gender = genderr;
            this.Gender = genderr;
        }

        public string Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                string[] maleSynonims = new string[2] { "female", "feminine" };
                if (!maleSynonims.Contains(value.ToLower()))
                {
                    throw new ArgumentException("Invalid entry. Only female kittens please");
                }
                this.gender = value;
            }
        }

        public override void SaySomethings()
        {
            string specificSound = "Mau mau mau (the kitty type)";
            
            Console.WriteLine(specificSound);
        }



    }
}
