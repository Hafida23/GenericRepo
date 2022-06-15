using System.ComponentModel.DataAnnotations;

namespace GenericRepo.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string FirstName { get; set; }
        [MaxLength(30)]
        public string LastName { get; set; }
        [MaxLength(20)]
        public string Email  { get; set; }
        [MaxLength(50)]
        public string Phone { get; set; }
    }
}
