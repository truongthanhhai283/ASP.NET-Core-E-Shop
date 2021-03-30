using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ShopOnlineApp.Application.Dapper.ViewModels;

namespace ShopOnlineApp.Application.Dapper.Interfaces
{
    public interface IReportService
    {
        Task<IEnumerable<RevenueReportViewModel>> GetReportAsync(string fromDate, string toDate);
    }
}
