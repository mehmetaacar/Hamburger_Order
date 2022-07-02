using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    
    public class Sauce : Food
    {
        

        public Sauce(string name, double price) //ctor
        {
            this.Name = name;
            this.Price = price;
        }
        public Sauce(string name) //ctor
        {
            this.Name = name;
            
        }
        public Sauce()
        {

        }
        
        public override double Price { get; set; }
        public override string Name { get; set; }
        
    }
}
