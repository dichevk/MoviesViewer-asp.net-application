using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer
    {
        [Key]
        public int ProducerId { get; set; }
        public string? Name { get; set; }
        public string? ProfilePictureUrl { get; set; }   
        public string? Bio { get; set; }
    }
}
