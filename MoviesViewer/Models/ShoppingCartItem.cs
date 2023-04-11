using System.ComponentModel.DataAnnotations;

namespace MoviesViewer.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int Id { get; set; }

        public Movie Movie { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }

        public string ShoppingCartId { get; set; }
    }
}
