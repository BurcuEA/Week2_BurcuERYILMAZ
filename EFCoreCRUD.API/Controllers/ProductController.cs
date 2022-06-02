using EFCoreCRUD.Business.Abstract;
using EFCoreCRUD.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreCRUD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService _productService;

        public ProductController(IProductService pService)
        {
            _productService = pService; // new ProductManager();
        }

        [HttpGet]
        public List<Product> Get()
        {
            return _productService.GetAllProducts();
        }

        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _productService.GetProductById(id);
        }

        //[HttpPost("insert")]  --- https://localhost:7071/api/product/insert
        [HttpPost]
        public Product Post([FromBody]Product product) //https://localhost:7071/api/product
        {
            return _productService.CreateProduct(product);
        }

        [HttpPut]
        public Product Put([FromBody] Product product)
        {
             _productService.UpdateProduct(product);                  
            return product;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _productService.DeleteProduct(id);
        }
    }
}
