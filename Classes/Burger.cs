using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Burger : Food
    {
        public Burger(string name,double price)
        {
            this.Price = price;
            this.Name = name;
        }
        public override double Price { get; set; }
        public override string Name { get; set; }

    }
}
