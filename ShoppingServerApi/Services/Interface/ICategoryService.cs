using ShoppingServerApi.Model;

namespace ShoppingServerApi.Services.Interface
{
    public interface ICategoryService
    {
        void AddCategory(Category category);
        void UpdateCategory(Category category);
        IQueryable<Category> GetAllCategories();
        Category? GetCategorybyId(int id);
        void DeleteCategory(int id);
    }
}
