﻿using System.Collections.Generic;
using ShopOnlineApp.Application.ViewModels.Blog;
using ShopOnlineApp.Application.ViewModels.Common;
using ShopOnlineApp.Application.ViewModels.Product;

namespace ShopOnlineApp.Models
{
    public class HomeViewModel
    {
        public List<BlogViewModel> LastestBlogs { get; set; }
        public List<SlideViewModel> HomeSlides { get; set; }
        public List<ProductViewModel> HotProducts { get; set; }
        public List<ProductViewModel> TopSellProducts { get; set; }

        public List<ProductCategoryViewModel> HomeCategories { set; get; }

        public string Title { set; get; }
        public string MetaKeyword { set; get; }
        public string MetaDescription { set; get; }
    }
}
