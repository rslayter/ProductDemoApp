using ProductDemoApp.Api.Models;
using ProductDemoApp.Api.Service;
using System.Collections.Generic;
using System.Web.Http;

namespace ProductDemoApp.Api.Controllers
{
    public class ProductsController : ApiController
    {
        ProductService productService;

        // GET: api/products
        public IEnumerable<ProductModel> getProducts()
        {
            productService = new ProductService();
            List<ProductModel> products = new List<ProductModel>();
            products = productService.getProducts(0);
            return products;
        }

        // GET: api/products/{id}
        public IHttpActionResult getProduct(int id)
        {
            productService = new ProductService();
            ProductModel product = productService.getProduct(id);

            return Ok(product);
        }
    }
}