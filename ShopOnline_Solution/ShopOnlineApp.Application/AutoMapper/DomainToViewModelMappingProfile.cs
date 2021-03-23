using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using ShopOnlineApp.Application.ViewModels.Product;
using ShopOnlineApp.Data.Entities;

namespace ShopOnlineApp.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ProductCategory, ProductCategoryViewModel>();
        }
    }
}
