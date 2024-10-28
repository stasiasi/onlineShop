using System.ComponentModel.DataAnnotations.Schema;

namespace PerfumeShop.Models.Entities
{
    public class Product
    {
        public Guid ProductId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }
        public Guid BrandId { get; set; }
        public Brand Brand { get; set; }
        public ProductType Type { get; set; }
        public TargetGender ForWhom { get; set; }
        public FragranceFamily FragranceFamily { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string ManufacturedIn { get; set; }
        public int Volume { get; set; }
        public double Price { get; set; }
        [Column(TypeName = "nvarchar(1000)")]
        public string Description { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string ImageURL { get; set; }
        public int Stock { get; set; }
    }

    public enum FragranceFamily
    {
        Aldehydic,     // Альдегидные
        Aromatic,      // Ароматические
        Vanilla,       // Ванильные
        Aquatic,       // Водные
        Oriental,      // Восточные
        Woody,         // Древесные
        Leather,       // Кожаные
        Musky,         // Мускусные
        Spicy,         // Пряные
        Fresh,         // Свежие
        Fruity,        // Фруктовые
        Fougere,       // Фужерные
        Floral,        // Цветочные
        Citrus         // Цитрусовые
    }

    public enum ProductType
    {
        Perfume,              // Духи
        EauDeParfum,         // Парфюмерная вода
        EauDeToilette,       // Туалетная вода
        Cologne             // Одеколон
    }

    public enum TargetGender
    {
        Male,
        Female,
        Unisex
    }

}
