using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProductDemoApp.Api.Service
{
    public class ProductDemoAppDbInitializer : SqliteDropCreateDatabaseAlways<DataModel>
    {
        public ProductDemoAppDbInitializer(DbModelBuilder modelBuilder) : base(modelBuilder)
        {
        }

        protected override void Seed(DataModel context)
        {
            List<product> products = new List<product>();

            // add 12 products at a time until you reach 1000, similar to the api call
            for (int index = 0; index < 1000; index = index + 12)
            {
                List<product> newProducts = new List<product>();

                int numProducts = 12;
                int maxProducts = 1000;

                if (index + numProducts > maxProducts)
                {
                    numProducts = maxProducts - index;
                }
                // initialize each of the 12 products with unique data
                for (int i = 1; i <= numProducts; i++)
                {
                    product p = new product();
                    p.product_id = index + i;
                    p.name = "Product " + p.product_id;
                    p.price = "$" + p.product_id + ".00";
                    p.description = p.name + " is the best in class for what it does. "
                                          + "It offers a superior benefit compared to the other products on the market. "
                                          + "For the low price of " + p.price + ", you won't find another product like it.";
                    p.image = "/images/image_" + i + ".jpg";
                    newProducts.Add(p);
                }

                products.AddRange(newProducts);
            }

            products.ForEach(p => context.products.Add(p));
            context.SaveChanges();

            base.Seed(context);
        }
    }
}