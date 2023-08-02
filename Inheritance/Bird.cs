using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal 
    {
        public bool CanFly { get; set; }    

        public string  WingSpan { get; set; }   

        public bool Migrates { get; set; }  

        public string NumberOfEggs { get; set; }    
    }
}
