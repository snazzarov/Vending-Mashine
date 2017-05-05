using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VM.Models
{
    public class VmData
    {
        public VmDrinks drinks { get; set; }
        public VmAccount account { get; set; }
        public int balance { get; set; }
        public VmMoney money { get; set; }
        public UserWallet wallet { get; set; }
        public UserDrinks userDrinks { get; set; }
        public VmData(VmDrinks drinks, VmAccount account, VmMoney money, UserWallet wallet, UserDrinks userDrinks)
        {
            this.drinks = drinks;
            this.account = account;
            balance = account.Balance();
            this.money = money;
            this.wallet = wallet;
            this.userDrinks = userDrinks;
        }
    }
}