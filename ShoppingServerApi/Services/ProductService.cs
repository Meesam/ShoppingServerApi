using ShoppingServerApi.Data;
using ShoppingServerApi.Model;
using ShoppingServerApi.Services.Interface;

namespace ShoppingServerApi.Services
{
    public class ProductService : IProductService
    {
        private readonly ShoppingCartDbContext _context;

        public ProductService(ShoppingCartDbContext context)
        {
            _context = context;
        }

        public void AddProduct(Product product)
        {
            if (product is null) return;
            _context.products.Add(product);
            _context.SaveChanges();
        }

        public IQueryable<Product> GetAllProducts()
        {
            return _context.products.AsQueryable<Product>();
        }

        public Product? GetProductById(int id)
        {
            if (id <= 0) return null;
            return _context.products.SingleOrDefault(p => p.Id == id);
        }

        public void DeleteProduct(int id)
        {
            if (id <= 0) return;
            var product = _context.products.SingleOrDefault(x => x.Id == id);
            if (product is null) return;
            _context.products.Remove(product);
            _context.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            if (product is null) return;
            var productData = _context.products.SingleOrDefault(x => x.Id == product.Id);
            if (productData is null) return;
            productData.Name = product.Name;
            productData.Description = product.Description;
            productData.Category = product.Category;
            productData.ModifiedDate = DateTime.Now;
            _context.products.Update(productData);
            _context.SaveChanges();

        }
    }
}
