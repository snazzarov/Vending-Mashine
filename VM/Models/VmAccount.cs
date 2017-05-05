using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VM.Models
{
    // class for inserted money to VM by user
    public class VmAccount
    {
        public int[] coins { get; set; }
        public int[] quantity { get; set; }
        public VmAccount()
        {
            coins = new int[] {1, 2, 5, 10 };
            quantity = new int[] { 0, 0, 0, 0 };
        }
        public int Balance()
        {
            int result = 0;
            for (int i = 0; i < coins.Length; i++)
                result += coins[i] * quantity[i];
            return result;
        }
        public void Clear()
        {
            for (int i = 0; i < coins.Length; i++)
                quantity[i] = 0;
        }
        public string GetString(int id)
        {
            return coins[id] + "p." + " * " + quantity[id] + " шт.";
        }
        public void AddBalance(int delta, VmMoney money)
        {
            for (int i = money.coins.Length - 1; i >= 0; i--)
                for (int j = money.quantity[i]; j >= 0; j--)
                    if (delta - money.coins[i] >= 0)
                    {
                        delta -= money.coins[i];
                        money.quantity[i]--;
                        quantity[i]++;
                    }
                    else
                        break;
        }
    }
}