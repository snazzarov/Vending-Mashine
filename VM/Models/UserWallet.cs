using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VM.Models
{
    // class for user wallet
    public class UserWallet
    {
        public int[] coins { get; set; }
        public int[] quantity { get; set; }
        public UserWallet()
        {
            coins = new int[] { 1, 2, 5, 10 };
            quantity = new int[] { 10, 30, 20, 15 };
        }
        public void Rollback(VmAccount account)
        {
            for (int i = 0; i < coins.Length; i++)
                quantity[i] += account.quantity[i];
        }
    }
}