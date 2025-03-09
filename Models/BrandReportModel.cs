using Fingers10.ExcelExport.Attributes;

namespace OnlineSuperMarket.Models
{
    public class BrandReportModel
    {
        [IncludeInReport(Order = 1)]
        public string Brand { get; set; }
        [IncludeInReport(Order = 2)]
        public int TotalProductsSold { get; set; }
        [IncludeInReport(Order = 3)]
        public decimal TotalRevenue { get; set; }
    }
}
