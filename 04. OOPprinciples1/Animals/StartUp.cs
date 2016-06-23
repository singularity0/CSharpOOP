using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main()
        {

            Cat someCat = new Cat("goshko", "female", 22);
            Tomcat someTomcat = new Tomcat("Georgi", "male", 12);
            Kitten someKitty = new Kitten("Lily", "female", 33);
            var someDog = new Dog("richi", "other", 12);
            var someFrog = new Frog("kuku", "hibrid", 33);
            
            var animals = new List<Animal>() { someCat, someTomcat, someKitty, someFrog, someDog };
            foreach (var anim in animals)
            {
                Console.Write(anim.Name + " says "); 
                anim.SaySomethings();
            }

        }
    }
}
