using ProductDemoApp.Api.Models;
using ProductDemoApp.Api.Service;
using System.Collections.Generic;
using System.Web.Http;

namespace ProductDemoApp.Api.Controllers
{
    public class ProductsController : ApiController
    {
        ProductService productService;

        // GET: api/products?index=12
        public IEnumerable<ProductModel> getProducts(int index)
        {
            productService = new ProductService();
            IEnumerable<ProductModel> products = new List<ProductModel>();
            products = productService.getProducts(index);
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