using ShopOnline.Api.Entities;
using ShopOnline.Model.DTO;

namespace ShopOnline.Api.Extensions
{
    public static class DtoConversions
    {
        public static IEnumerable<ProductDTO> ConvertToDTO(this IEnumerable<Product> products,
                                                                IEnumerable<ProductCategory> productCategories)
        {
            return (from product in products
                    join category in productCategories
                    on product.CategoryId equals category.Id
                    select new ProductDTO
                    {
                        Id = product.Id,
                        Name = product.Name,
                        Description = product.Description,
                        ImageURL = product.ImageURL,
                        Price = product.Price,
                        Quantity = product.Quantity,
                        CategoryId = product.CategoryId,
                        CategoryName = category.Name

                    }).ToList();
        }
    }
}
