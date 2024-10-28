namespace PerfumeShop.Models.Entities
{
    public class OrderedProduct
    {
        public Guid OrderedProductID { get; set; }
        public Guid OrderID { get; set; }
        public Order Order { get; set; } 
        public Guid ProductID { get; set; }
        public Product Product { get; set; }  
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
