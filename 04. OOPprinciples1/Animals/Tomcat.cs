using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Tomcat : Cat
    {
        private string gender;
        public Tomcat(string name, string genderr, int age) : base(name, genderr, age)
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
                        string[] maleSynonims = new string[2] { "male", "masculin" };
                        if (!maleSynonims.Contains(value.ToLower()))
                        {
                            throw new ArgumentException("Invalid entry. Only male Tomcats please");
                        }
                        this.gender = value;
                    }
            }

        public override void SaySomethings()
        {
            string specificSound = "Mau mauhoo mauhoo (the Tomcat type)";
            
            Console.WriteLine(specificSound);
        }
    }
}

