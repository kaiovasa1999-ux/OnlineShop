using ShopOnline.Model.DTO;

namespace OnlineShop.Web.Services.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetItems();

        Task<ProductDTO> GetProduct(int id);
    }
}
