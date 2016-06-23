using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal : ISound
    {

        

        public Animal(string someName, string gender, int age)
        {
            this.Age = age;
            this.Name = someName;
            this.Sex = gender;
        }

        public Animal(string someName,int age)
        {
            this.Age = age;
            this.Name = someName;

        }

        public int Age { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }


        public virtual void SaySomethings()
        {
            Console.Write("My sound is: ");
        }
    }
}
