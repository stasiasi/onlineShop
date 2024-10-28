using System.ComponentModel.DataAnnotations.Schema;

namespace PerfumeShop.Models.Entities
{
    public class Cart
    {
        public Guid CartID { get; set; }
        
        public string UserID { get; set; }
        public User User { get; set; } 
        public ICollection<ProductInCart> ProductsInCart { get; set; }  
    }
}
