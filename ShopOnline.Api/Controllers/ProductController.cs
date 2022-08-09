using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopOnline.Api.Extensions;
using ShopOnline.Api.Repositories.Contracts;
using ShopOnline.Model.DTO;

namespace ShopOnline.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepo _productRepo;
        public ProductController(IProductRepo productRepo)
        {
            this._productRepo = productRepo;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> GetItems()
        {
            try
            {
                var product = await this._productRepo.GetItems();
                var productCategory = await this._productRepo.GetCategories(); 
                if(productCategory == null || productCategory == null)
                {
                    return NotFound();
                }
                else
                {
                    var productDtos = product.ConvertToDTO(productCategory);
                    return Ok(productDtos);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");
            }
        }
    }
}
