using System.ComponentModel.DataAnnotations;

namespace inovayt.Models
{
    public class Asset
    {
        [Key]
        public System.Guid userId { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? PurchasePrice { get; set; }
        public string? AssetValue { get; set; }
        public string? PurchaseDate { get; set; }
        public string? Description { get; set; }
    }
}
