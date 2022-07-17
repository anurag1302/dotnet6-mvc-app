namespace MVCDemo.Models
{
    public class BaseProductViewModel
    {
        public IReadOnlyList<ProductDetailsViewModel> Products { get; set; }
        public int Count { get; set; }
        public DateTime LatestOrderDate { get; set; }
    }
}