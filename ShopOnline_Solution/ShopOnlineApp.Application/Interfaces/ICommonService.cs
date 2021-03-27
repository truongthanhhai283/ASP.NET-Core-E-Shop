using System;
using System.Collections.Generic;
using System.Text;
using ShopOnlineApp.Application.ViewModels.Common;

namespace ShopOnlineApp.Application.Interfaces
{
    public interface ICommonService
    {
        FooterViewModel GetFooter();
        List<SlideViewModel> GetSlides(string groupAlias);
        SystemConfigViewModel GetSystemConfig(string code);
    }
}
