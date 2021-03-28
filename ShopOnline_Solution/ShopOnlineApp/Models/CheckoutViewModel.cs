using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopOnlineApp.Application.ViewModels.Common;
using ShopOnlineApp.Application.ViewModels.Product;
using ShopOnlineApp.Data.Enums;
using ShopOnlineApp.Utilities.Extensions;

namespace ShopOnlineApp.Models
{
    public class CheckoutViewModel : BillViewModel
    {
        public List<ShoppingCartViewModel> Carts { get; set; }
        public List<EnumModel> PaymentMethods
        {
            get
            {
                return ((PaymentMethod[])Enum.GetValues(typeof(PaymentMethod)))
                    .Select(c => new EnumModel
                    {
                        Value = (int)c,
                        Name = c.GetDescription()
                    }).ToList();
            }
        }
    }
}
