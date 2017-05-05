using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VM.Models
{
    public class UserDrinks
    {
        public string[] drink { get; set; }
        public int[] quantity { get; set; }
        public UserDrinks()
        {
            drink = new string[] { "Чай", "Кофе", "Кофе & Молоко", "Сок" };
            quantity = new int[] { 0, 0, 0, 0 };
        }
        public string GetString(int id)
        {
            return drink[id] + " " + quantity[id] + " пор.";
        }
    }
}