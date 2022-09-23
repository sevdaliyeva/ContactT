using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactT
{
    public class Contact
    { public string name { get; set; }
        public string number { get; set; }  
        public Contact(string name,string number)
        {
           this.name = name;
            this.number = number;   
        }
        public override string ToString()
        {
            return name + " " + number; 
        }
    }
}
