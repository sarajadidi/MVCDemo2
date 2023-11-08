using System;
using System.Data;
using Dapper;
using MVCDemo2.Models;

namespace MVCDemo2
{
	public class ProductRepository : IProductRepository
	{
        private readonly IDbConnection _conn;

        public ProductRepository(IDbConnection conn)
		{
            _conn = conn;
		}

        public IEnumerable<Product> GetAllProducts()
        {
            return _conn.Query<Product>("SELECT * FROM PRODUCTS;");
        }
    }
}

