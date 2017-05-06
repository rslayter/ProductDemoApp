using ProductDemoApp.Api.Access;
using System.Collections.Generic;
using System.Data.Entity;

namespace ProductDemoApp.Api.Service
{
    public class ProductService
    {
        /*
        * Returns a list of the next 12 products to be displayed, until 1000 total products have been returned. 
        * For demo purposes, these products are generated instead of being stored in a database.
        */
        public List<product> getProducts(int index)
        {
            List<product> products = new List<product>();

            ProductAccess access = new ProductAccess();

            int numProducts = 12;
            int maxProducts = 1000;

            if (index + numProducts > maxProducts)
            {
                numProducts = maxProducts - index;
            }

            int lowerLimit = index + 1;
            int upperLimit = index + numProducts;
            products = access.getProducts(lowerLimit, upperLimit);

            return products;
        }

        /*
        * Returns a product by the product id
        * For demo purposes, this product information is generated instead of being stored in a database.
        */
        public product getProduct(int id)
        {
            product product = new product();
            product.product_id = id;
            product.name = "Product " + product.product_id + 1;
            product.price = "$" + product.product_id + ".00";
            product.description = "This is a description for product " + product.product_id + ".";
            product.image = "/images/image_" + (product.product_id % 12) + ".jpeg";

            return product;
        }
    }
}