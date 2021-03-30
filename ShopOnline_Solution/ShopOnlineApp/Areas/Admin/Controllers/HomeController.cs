using Microsoft.AspNetCore.Mvc;
using ShopOnlineApp.Application.Dapper.Interfaces;
using ShopOnlineApp.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopOnlineApp.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IReportService _reportService;

        public HomeController(IReportService reportService)
        {
            _reportService = reportService;
        }
        public IActionResult Index()
        {
            var email = User.GetSpecificClaim("Email");
            return View();
        }

        public async Task<IActionResult> GetRevenue(string fromDate, string toDate)
        {
            return new OkObjectResult(await _reportService.GetReportAsync(fromDate, toDate));
        }
    }
}
