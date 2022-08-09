using ShopOnline.Api.Entities;

namespace ShopOnline.Api.Repositories.Contracts
{
    public interface IProductRepo
    {
        Task<IEnumerable<Product>> GetItems();

        Task<IEnumerable<ProductCategory>> GetCategories();

        Task<Product> GetItem(int id);

        Task<ProductCategory> GetCategory(int id);
    }
}
