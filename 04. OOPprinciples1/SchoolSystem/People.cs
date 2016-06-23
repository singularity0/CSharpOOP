using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    public abstract class People : IComment
    {
        private string firstName;
        private string lastName;

        public People(string firstname, string lastname)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                foreach (var item in value)
                {
                    if (char.IsDigit(item))
                    {
                        throw new ArgumentException("name should not contain numbers");
                    }
                }
                this.firstName = value;
            }
        }
        public string LastName { get; set; }
        public string Comment { get { return "people Comment"; } set { this.Comment = value; } }

        public virtual string toString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }

    
}
