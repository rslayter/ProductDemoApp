using ProductDemoApp.Api.Service;
using System.Collections.Generic;
using System.Web.Http;

namespace ProductDemoApp.Api.Controllers
{
    public class ProductsController : ApiController
    {
        ProductService productService;

        // GET: api/products?index=12
        public IEnumerable<product> getProducts(int index)
        {
            productService = new ProductService();
            IEnumerable<product> products = new List<product>();
            products = productService.getProducts(index);
            return products;
        }

        // GET: api/products/{id}
        public IHttpActionResult getProduct(int id)
        {
            productService = new ProductService();
            product product = productService.getProduct(id);

            return Ok(product);
        }
    }
}