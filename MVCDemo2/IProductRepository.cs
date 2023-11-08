using System;
using MVCDemo2.Models;

namespace MVCDemo2
{
	public interface IProductRepository
	{
        public IEnumerable<Product> GetAllProducts();

    }
}

