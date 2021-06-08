using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ImplementMoney.Models;

namespace ImplementMoney.Controllers
{
    public class MoneyController : ApiController, IMoney, IMoneyCalculator
    {
        public decimal Amount { get; set; }
        public string Currency { get; set; }

        [HttpGet]
        public IMoney Max(IEnumerable<IMoney> monies)
        {
            IMoney money = null;
            if (monies != null)
            {
                var ListMoney = monies.ToList();
                
                var result = ListMoney.Select(x => x.Currency).Distinct();
                if (result.Count() == 1)
                {
                    var listMoney = ListMoney.OrderByDescending(x => x.Amount);
                    money = listMoney.FirstOrDefault();
                    return money;
                }
                else
                {
                    
                    throw new Exception("All monies are not in the same currency");
                    
                }
            }
            return money;


        }

        [HttpGet]

        public IEnumerable<IMoney> SumPerCurrency(IEnumerable<IMoney> monies)
        {
            var Listmoney = monies.ToList();

            IEnumerable<IMoney> sum = (from money in Listmoney
                group money by money.Currency into s
                select new Money { Currency = s.Key, Amount = s.Sum(x => x.Amount) }).ToList();
            return sum;
        }

        
    }
}
