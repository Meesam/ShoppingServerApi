using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingServerApi.Model;
using ShoppingServerApi.Services;
using ShoppingServerApi.Services.Interface;

namespace ShoppingServerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        [Route("/getAllCategory")]
        public IActionResult GetAllCategory()
        {
            var result = _categoryService.GetAllCategories();
            return Ok(result);
        }

        [HttpPost]
        [Route("/addNewCategory")]
        public IActionResult AddCategory(Category category)
        {
            if (category == null) return BadRequest();
            _categoryService.AddCategory(category);
            return Ok();
        }




    }
}
