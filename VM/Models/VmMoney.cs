using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VM.Models
{
    // class for VM moneyback
    public class VmMoney
    {
        public int[] coins { get; set; }
        public int[] quantity { get; set; }
        public VmMoney()
        {
            coins = new int[] { 1, 2, 5, 10 };
            quantity = new int[] { 100, 100, 100, 100 };
        }
        public void TakeFromAccount(VmAccount account)
        {
            for (int i = 0; i < account.coins.Length; i++)
                quantity[i] += account.quantity[i];
        }
        public string GetString(int id)
        {
            return coins[id] + "p." + " * " + quantity[id] + " шт.";
        }
    }
}