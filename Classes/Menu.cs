using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    
    public class Menu
    {
        public enum Size
        {
            Küçük=0,Orta=2,Büyük=3,Jumbo=5
        }
        
        public Menu(string menuName,double menuPrice,string burgerName,double burgerPrice)
        {
            Burger burger = new Burger(burgerName,burgerPrice);
            
            SelectedBurger = burger;
            
            this.MenuName = menuName;
            this.Price = menuPrice;
        }

        public Menu(string menuName, double menuPrice)
        {
            this.MenuName = menuName;
            this.Price = menuPrice;
        }
        
        public string MenuName { get; set; }
        public double Price { get; set; }
        public Burger SelectedBurger { get; set; }
        public Drink SelectedDrink { get; set; }

        // public Sauce SelectedSauce { get; set; }

        public override string ToString()
        {
            return MenuName;
        }

    }
}
