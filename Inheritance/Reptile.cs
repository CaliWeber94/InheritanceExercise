using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public bool ColdBlooded { get; set; }   

        public bool Aquatic { get; set; }   

        public string Scales { get; set; }  

        public string Length { get; set; }  
    }
}
