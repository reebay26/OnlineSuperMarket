namespace OnlineSuperMarket.Models
{
    public class CategoryBrandViewModel
    {
        public string CategoryName { get; set; }
        public string BrandName { get; set; }
        public List<Product_Model> Products { get; set; }
    }
}
