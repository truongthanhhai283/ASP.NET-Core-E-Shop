﻿using System;
using System.Collections.Generic;
using System.Text;
using ShopOnlineApp.Application.ViewModels.Product;
using ShopOnlineApp.Utilities.Dtos;

namespace ShopOnlineApp.Application.Interfaces
{
    public interface IProductService : IDisposable
    {
        List<ProductViewModel> GetAll();

        PagedResult<ProductViewModel> GetAllPaging(int? categoryId, string keyword, int page, int pageSize);
    }
}
