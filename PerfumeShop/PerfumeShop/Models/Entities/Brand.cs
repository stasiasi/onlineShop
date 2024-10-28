using System.ComponentModel.DataAnnotations.Schema;

namespace PerfumeShop.Models.Entities
{
    public class Brand
    {
        public Guid BrandID { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string BrandName { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string BrandCountry { get; set; }
        public ICollection<Product> Products { get; set; }  
    }
}
