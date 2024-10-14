using ShoppingServerApi.Data;
using ShoppingServerApi.Model;

namespace ShoppingServerApi.Services
{
    public class CategoryService
    {
        private readonly ShoppingCartDbContext _context;

        public CategoryService(ShoppingCartDbContext context)
        {
            _context = context;
        }

        public void AddCategory(Category category)
        {
            if (category is null) return;
            _context.categories.Add(category);
            _context.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            if (category is null) return;
            var categoryData = _context.categories.SingleOrDefault(x => x.Id == category.Id);
            if (categoryData is null) return;
            categoryData.Title = category.Title;
            categoryData.ModifiedDate = DateTime.Now;
            _context.categories.Update(categoryData);
            _context.SaveChanges();

        }

        public IQueryable<Category> GetAllCategories()
        {
            return _context.categories.AsQueryable<Category>();
        }

        public Category? GetCategorybyId(int id)
        {
            if (id <= 0) return null;
            return _context.categories.SingleOrDefault(c => c.Id == id);
        }

        public void DeleteCategory(int id)
        {
            if (id <= 0) return;
            var categoryData = _context.categories.SingleOrDefault(x => x.Id == id);
            if (categoryData is null) return;
            _context.categories.Remove(categoryData);
            _context.SaveChanges();
        }

    }
}
