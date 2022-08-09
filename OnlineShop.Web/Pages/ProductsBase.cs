using Microsoft.AspNetCore.Components;
using OnlineShop.Web.Services.Contracts;
using ShopOnline.Model.DTO;

namespace OnlineShop.Web.Pages
{
    public class ProductsBase : ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }

        public IEnumerable<ProductDTO> Products { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Products = await ProductService.GetItems();
        }

    }
}
