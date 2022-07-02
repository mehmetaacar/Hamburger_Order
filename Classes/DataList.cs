using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public static class DataList
    {
        public static List<Menu> menus = new List<Menu>();
        public static List<Sauce> sauces = new List<Sauce>();
        public static List<Burger> burger = new List<Burger>();
        public static Dictionary<string, double> order = new Dictionary<string, double>();
    }
}
