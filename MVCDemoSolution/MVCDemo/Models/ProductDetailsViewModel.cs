namespace MVCDemo.Models
{
    public class ProductDetailsViewModel
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public Category ProductCategory { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime? OrderedDate { get; set; }
    }

    public enum Category
    {
        CPUs,
        GraphicCards,
        Keyboards
    }

    public enum OrderStatus
    {
        Ordered,
        InTransit,
        Delivered
    }
}