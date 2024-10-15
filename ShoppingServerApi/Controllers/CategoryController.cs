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

        [HttpPost]
        [Route("/updateCategory")]
        public IActionResult UpdateCategory(Category category)
        {
            if (category == null) return BadRequest();
            _categoryService.UpdateCategory(category);
            return Ok();
        }

        [HttpGet]
        [Route("/getCategory/{id}")]
        public IActionResult GetCategoryById(int id)
        {
            if (id <= 0) return BadRequest();
            var category = _categoryService.GetCategorybyId(id);
            return Ok(category);
        }

        [HttpDelete]
        [Route("/deleteCategory/{id}")]
        public IActionResult DeleteCategory(int id)
        {
            if (id <= 0) return BadRequest();
            _categoryService.DeleteCategory(id);
            return Ok();
        }
    }
}
