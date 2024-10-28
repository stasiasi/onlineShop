namespace PerfumeShop.Models.Entities
{
    public class ProductInCart
    {
        public Guid ProductInCartID { get; set; }
        public Guid CartID { get; set; }
        public Cart Cart { get; set; }
        public Guid ProductID { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
