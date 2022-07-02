using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public enum Drinks
    {
        Cola, ColaLight, ColaZero, Fanta, Sprite, IceTea, KFCKAHVESİ2LİRALIK
    }
    public class Drink : Food
    {
        public Drink(double price)
        {
            this.Price = price;
        }
        
        public override double Price { get; set; }
        
        public override string Name { get; set; }

    }
}
