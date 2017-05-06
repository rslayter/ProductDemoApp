using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SQLite.EF6;

namespace ProductDemoApp.Api.Access
{
    public class ProductAccess
    {
        public List<product> getProducts(int lowerLimit, int upperLimit)
        {
            using (var context = new DataModel())
            {
                //Query for the indexes within the given range
                List<product> products = context.products.SqlQuery("select * from products where product_id between @p0 AND @p1", lowerLimit, upperLimit).ToList();
                return products;
            }
        }
    }
}