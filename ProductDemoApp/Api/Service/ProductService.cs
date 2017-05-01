using ProductDemoApp.Api.Models;
using System.Collections.Generic;

namespace ProductDemoApp.Api.Service
{
    public class ProductService
    {
        /*
        * Returns a list of the next 12 products to be displayed, until 1000 total products have been returned. 
        * For demo purposes, these products are generated instead of being stored in a database.
        */
        public List<ProductModel> getProducts(int index)
        {
            List<ProductModel> products = new List<ProductModel>();

            int numProducts = 12;
            int maxProducts = 1000;

            if (index + numProducts > maxProducts)
            {
                numProducts = maxProducts - index;
            }
            for (int i = 1; i <= numProducts; i++)
            {
                ProductModel product = new ProductModel();
                product.Id = index + i;
                product.Name = "Product " + product.Id;
                product.Cost = "$" + product.Id + ".00";
                product.Description = product.Name + " is the best in class for what it does. "
                                      + "It offers a superior benefit compared to the other products on the market. "
                                      + "For the low price of " + product.Cost + ", you won't find another product like it.";
                product.Image = "/images/image_" + i + ".jpeg";
                products.Add(product);
            }
            return products;
        }

        /*
        * Returns a product by the product id
        * For demo purposes, this product information is generated instead of being stored in a database.
        */
        public ProductModel getProduct(int id)
        {
            ProductModel product = new ProductModel();
            product.Id = id;
            product.Name = "Product " + product.Id + 1;
            product.Cost = "$" + product.Id + ".00";
            product.Description = "This is a description for product " + product.Id + ".";
            product.Image = "/images/image_" + (product.Id % 12) + ".jpeg";

            return product;
        }
    }
}