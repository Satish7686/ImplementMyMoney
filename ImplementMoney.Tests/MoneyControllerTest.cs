using System;
using System.Collections.Generic;
using System.Linq;
using ImplementMoney.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ImplementMoney.Models;

namespace ImplementMoney.Tests
{
    [TestClass]
    public class MoneyControllerTest
    {
        MoneyController _mc = new MoneyController();
        [TestMethod]
        public void Max_Test()
        {

            Money m = new Money
            {
                Amount = 35,
                Currency = "GBP"
            };

            Money m1 = new Money
            {
                Amount = 40,
                Currency = "GBP"
            };

            List<Money> monies = new List<Money>
            {
                m,
                m1
            };
            var result = _mc.Max(monies);

            Assert.AreEqual(40, result.Amount);
        }

        [TestMethod()]
        public void SumPerCurrencyTest_Currencytypesone()
        {

            Money m = new Money
            {
                Amount = 35,
                Currency = "GBP"
            };

            Money m1 = new Money
            {
                Amount = 40,
                Currency = "GBP"
            };

            Money m2 = new Money
            {
                Amount = 30,
                Currency = "GBP"
            };

            Money m3 = new Money
            {
                Amount = 40,
                Currency = "GBP"
            };


            List<Money> monies = new List<Money>
            {
                m,
                m1,
                m2,
                m3
            };

            var results = _mc.SumPerCurrency(monies);

            foreach (var result in results)
            {
                if (result.Currency == "GBP")
                {
                    Assert.AreEqual(145, result.Amount);
                }
          

            }

        }

        [TestMethod()]
        public void SumPerCurrencyTest_Currencytypestwo()
        {

            Money m = new Money
            {
                Amount = 35,
                Currency = "GBP"
            };

           Money m1 = new Money
            {
                Amount = 40,
                Currency = "GBP"
            };

            Money m2 = new Money
            {
                Amount = 30,
                Currency = "Euro"
            };

            Money m3 = new Money
            {
                Amount = 40,
                Currency = "Euro"
            };


            List<Money> monies = new List<Money>
            {
                m,
                m1,
                m2,
                m3
            };

            var results = _mc.SumPerCurrency(monies);

            foreach (var result in results)
            {
                if (result.Currency == "GBP")
                {
                    Assert.AreEqual(75, result.Amount);
                }
                else if (result.Currency == "Euro")
                {
                    Assert.AreEqual(70, result.Amount);
                }
                
            }
           
        }

        [TestMethod()]
        public void SumPerCurrencyTest_Currencytypesthree()
        {

            Money m = new Money
            {
                Amount = 35,
                Currency = "GBP"
            };

            Money m1 = new Money
            {
                Amount = 40,
                Currency = "GBP"
            };

            Money m2 = new Money
            {
                Amount = 30,
                Currency = "Euro"
            };

            Money m3 = new Money
            {
                Amount = 40,
                Currency = "USD"
            };


            List<Money> monies = new List<Money>
            {
                m,
                m1,
                m2,
                m3
            };

            var results = _mc.SumPerCurrency(monies);

            foreach (var result in results)
            {
                if (result.Currency == "GBP")
                {
                    Assert.AreEqual(75, result.Amount);
                }
                else if (result.Currency == "Euro")
                {
                    Assert.AreEqual(30, result.Amount);
                }
                else
                {
                    Assert.AreEqual(40, result.Amount);
                }

            }

        }

    }



}
