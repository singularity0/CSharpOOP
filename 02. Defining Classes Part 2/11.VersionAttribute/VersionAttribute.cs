using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.VersionAttribute
{
    [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Struct | System.AttributeTargets.Interface | System.AttributeTargets.Enum | System.AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    public class Version : System.Attribute
    {
        private string val;

        public Version(string value)
        {
            this.Val = value;
        }

        public string Val
        {
            get { return this.val; }
            private set { this.val = value; }
        }
    }
}
