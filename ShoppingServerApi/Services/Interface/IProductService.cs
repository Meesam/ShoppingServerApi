using ShoppingServerApi.Model;

namespace ShoppingServerApi.Services.Interface
{
    public interface IProductService
    {
        void AddProduct(Product product);
        IQueryable<Product> GetAllProducts();
        Product? GetProductById(int id);
        void DeleteProduct(int id);
        void UpdateProduct(Product product);

    }
}
