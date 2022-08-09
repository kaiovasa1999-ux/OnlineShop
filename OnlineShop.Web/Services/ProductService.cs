using OnlineShop.Web.Services.Contracts;
using ShopOnline.Model.DTO;
using System.Net.Http.Json;

namespace OnlineShop.Web.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient httpClient;
        public ProductService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<ProductDTO>> GetItems()
        {
            try
            {
                var product = await this.httpClient.GetFromJsonAsync<IEnumerable<ProductDTO>>("api/Product");
                return product;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<ProductDTO> GetProduct(int id)
        {
            throw new NotImplementedException();
        }
    }
}
