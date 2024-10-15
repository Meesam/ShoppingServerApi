using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingServerApi.Model;
using ShoppingServerApi.Services;
using ShoppingServerApi.Services.Interface;

namespace ShoppingServerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [Route("/getAllProducts")]
        public IActionResult GetAllProduct()
        {
            var result = _productService.GetAllProducts();
            return Ok(result);
        }

        [HttpPost]
        [Route("/addNewProduct")]
        public IActionResult AddProduct(Product product)
        {
            if (product == null) return BadRequest();
            _productService.AddProduct(product);
            return Ok();
        }

        [HttpPost]
        [Route("/updateProduct")]
        public IActionResult UpdateProduct(Product product)
        {
            if (product == null) return BadRequest();
            _productService.UpdateProduct(product);
            return Ok();
        }

        [HttpGet]
        [Route("/getProduct/{id}")]
        public IActionResult GetProductById(int id)
        {
            if (id <= 0) return BadRequest();
            var product = _productService.GetProductById(id);
            return Ok(product);
        }

        [HttpDelete]
        [Route("/deleteProduct/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            if (id <= 0) return BadRequest();
            _productService.DeleteProduct(id);
            return Ok();
        }
    }
}
