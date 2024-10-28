using System.ComponentModel.DataAnnotations.Schema;

namespace PerfumeShop.Models.Entities
{
    public enum StatusTypes
    {
        New,
        Processing,
        Completed,
        Cancelled
    }
    public class Order
    {
        public Guid OrderID { get; set; }
        
        public string UserID { get; set; }
        public User User { get; set; }
        [Column(TypeName = "SMALLDATETIME")]
        public DateTime OrderDate { get; set; }
        public int TotalAmount { get; set; }
        public StatusTypes Status { get; set; }  
        public ICollection<OrderedProduct> OrderedProducts { get; set; } 
    }
}
