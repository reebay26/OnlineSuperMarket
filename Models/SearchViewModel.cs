namespace OnlineSuperMarket.Models
{
    public class SearchViewModel
    {
        public List<Product_Model> Products { get; set; } = new List<Product_Model>();
        public List<CategoryBrandViewModel> CategoryBrandList { get; set; } = new List<CategoryBrandViewModel>();
    }
}
