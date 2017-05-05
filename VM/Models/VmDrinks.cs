using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VM.Models
{
    public class VmDrinks
    {
        public string[] drink { get; set; }
        public int[] price { get; set; }
        public int[] quantity { get; set; }
        public VmDrinks()
        {
            drink = new string[] { "Чай", "Кофе", "Кофе & Молоко", "Сок" };
            price = new int[] { 13, 18, 21, 35 };
            quantity = new int[] { 10, 20, 20, 15 };
        }
        public string GetString(int id)
        {
            return drink[id] + " " + price[id] + "p." + " * " + quantity[id] + " шт.";
        }
    }
}