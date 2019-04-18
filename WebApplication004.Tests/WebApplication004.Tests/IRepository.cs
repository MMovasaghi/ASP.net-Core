using System;
using WebApplication004.Models;
using System.Collections.Generic;
using System.Text;

namespace WebApplication004.Tests
{
    public interface IRepository
    {
        IEnumerable<Product> Products { get; }
        void AddProduct(Product p);
    }
}
