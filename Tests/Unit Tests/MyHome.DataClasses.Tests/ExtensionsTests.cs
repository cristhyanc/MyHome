﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyHome.DataClasses.Tests
{
    [TestClass]
    public class ExtensionsTests
    {
        [TestMethod]
        public void Expense_Copy()
        {
            var first = new Expense
            {
                Amount = 120,
                Category = new ExpenseCategory
                {
                    Id = 0,
                    Name = "Category"
                },
                Comments = "Stuff",
                Date = DateTime.Today,
                Id = 0,
                Method = new PaymentMethod
                {
                    Id = 0,
                    Name = "Method"
                }
            };

            var second = first.Copy();

            Assert.AreNotSame(first, second);
            Assert.IsTrue(first.Equals(second));
            Assert.IsTrue(second.Equals(first));
        }

        [TestMethod]
        public void Income_Copy()
        {
            var first = new Income
            {
                Amount = 120,
                Category = new IncomeCategory
                {
                    Id = 0,
                    Name = "Category"
                },
                Comments = "Stuff",
                Date = DateTime.Today,
                Id = 0,
                Method = new PaymentMethod
                {
                    Id = 0,
                    Name = "Method"
                }
            };

            var second = first.Copy();

            Assert.AreNotSame(first, second);
            Assert.IsTrue(first.Equals(second));
            Assert.IsTrue(second.Equals(first));
        }
    }
}
