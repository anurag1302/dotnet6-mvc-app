using MVCDemo.Models;

namespace MVCDemo.Data
{
    public class ProductRepository
    {
        public static IReadOnlyList<ProductDetailsViewModel> GetProducts()
        {
            return new List<ProductDetailsViewModel>()
            {
                new ProductDetailsViewModel
                {
                    Id=Guid.NewGuid(),
                    ProductName="Intel Core i9",
                    ProductCategory=Category.CPUs,
                    Status=OrderStatus.Ordered,
                    OrderedDate=DateTime.Today
                },
                new ProductDetailsViewModel
                {
                    Id=Guid.NewGuid(),
                    ProductName="AMD Ryzen 7",
                    ProductCategory=Category.CPUs,
                    Status=OrderStatus.InTransit,
                    OrderedDate=DateTime.Today.AddDays(-3)
                },
                new ProductDetailsViewModel
                {
                    Id=Guid.NewGuid(),
                    ProductName="Nvidia RTX 3080",
                    ProductCategory=Category.GraphicCards,
                    Status=OrderStatus.Delivered,
                    OrderedDate=DateTime.Today.AddDays(-10)
                },
                new ProductDetailsViewModel
                {
                    Id=Guid.NewGuid(),
                    ProductName="Logitech LTX 90",
                    ProductCategory=Category.Keyboards,
                    Status=OrderStatus.Ordered,
                    OrderedDate=DateTime.Today.AddDays(-1)
                }
            };
        }
    }
}