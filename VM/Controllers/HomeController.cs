using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VM.Models;

namespace VM.Controllers
{
    public class HomeController : Controller
    {
        static UserWallet wallet;
        static VmAccount account;
        static VmDrinks drinks;
        static VmMoney money;
        static VmData data;
        static UserDrinks userDrinks;
        public ActionResult Index()
        {
            wallet = new UserWallet();
            account = new VmAccount();
            drinks = new VmDrinks();
            money = new VmMoney();
            userDrinks = new UserDrinks();
            data = new VmData(drinks, account, money, wallet, userDrinks);
            return View(data);
        }

        public ActionResult PutCoin(int id)
        {
            // if id = -1 then refresh page without changing 'data'
            // if id >= 0 then it's handler for button clicking  
            if (id >= 0)
            {
                if (wallet.quantity[id] > 0)
                {
                    wallet.quantity[id]--;
                    account.quantity[id]++;
                    data = new VmData(drinks, account, money, wallet, userDrinks);
                }
            }
            return View("Index", data);
        }
        public ActionResult MoneyBack()
        {
            wallet.Rollback(account);
            account.Clear();
            data = new VmData(drinks, account, money, wallet, userDrinks);
            return View("Index", data);
        }
        public ActionResult BuyDrink(int id)
        {
            if (drinks.quantity[id] > 0 &&
                drinks.price[id] <= account.Balance())
            {
                int delta = account.Balance() - drinks.price[id];
                money.TakeFromAccount(account);
                account.Clear();
                account.AddBalance(delta, money);
                drinks.quantity[id]--;
                userDrinks.quantity[id]++;
                data = new VmData(drinks, account, money, wallet, userDrinks);
                ViewBag.Message = "Спасибо!";
                return View("Index", data);
            }
            return View();
        }
    }
}