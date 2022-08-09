using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.Model.DTO
{
    public class CartItemToAddDTO
    {
        public int CardId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }
    }
}
