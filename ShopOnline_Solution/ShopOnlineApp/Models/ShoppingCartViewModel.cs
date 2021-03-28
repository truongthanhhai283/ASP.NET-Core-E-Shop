using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopOnlineApp.Application.ViewModels.Product;

namespace ShopOnlineApp.Models
{
    public class ShoppingCartViewModel
    {
        public ProductViewModel Product { set; get; }

        public int Quantity { set; get; }

        public decimal Price { set; get; }

        public ColorViewModel Color { get; set; }

        public SizeViewModel Size { get; set; }
    }
}
