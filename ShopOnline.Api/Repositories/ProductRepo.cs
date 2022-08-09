using Microsoft.EntityFrameworkCore;
using ShopOnline.Api.Data;
using ShopOnline.Api.Entities;
using ShopOnline.Api.Repositories.Contracts;

namespace ShopOnline.Api.Repositories
{
    public class ProductRepo : IProductRepo
    {
        private readonly ShopOnlineDbContext shopOnlineDbContext;
        public ProductRepo(ShopOnlineDbContext shopOnlineDbContext)
        {
            this.shopOnlineDbContext = shopOnlineDbContext;
        }
        public  async Task<IEnumerable<ProductCategory>> GetCategories()
        {
            var categories = await shopOnlineDbContext.ProductCategories.ToListAsync();
            return categories;
        }

        public async Task<ProductCategory> GetCategory(int id)
        {
            var category = await shopOnlineDbContext.ProductCategories.FindAsync();
            return category;
        }

        public async Task<Product> GetItem(int id)
        {
            var product = await shopOnlineDbContext.Products.FirstOrDefaultAsync();
            if(product == null)
            {
                throw new Exception($"Product with this Id does not exist in database");
            }
            return product;
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await shopOnlineDbContext.Products.ToListAsync();
            return products;
        }
    }
}
