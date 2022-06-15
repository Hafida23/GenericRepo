using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenericRepo.Models
{
    public class Product
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        [Column(TypeName="decimal(18,2)")]
        public decimal Price { get; set; }
    }
}
