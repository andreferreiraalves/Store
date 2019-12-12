using System;
using Store.Domain.Entities;
using Store.Domain.Repositories;

namespace Store.Tests.Repositories
{
    public class FakeDiscountRepository : IDiscountRepository
    {
        public Discount Get(string code)
        {
            if (code == "123")
                return new Discount(10, DateTime.Now.AddDays(3));

            if (code == "321")
                return new Discount(10, DateTime.Now.AddDays(-3));

            return null;
        }
    }
}