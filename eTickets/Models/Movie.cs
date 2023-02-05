using eTickets.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }

        public double Price { get; set; }
        /*
        public Cinema Cinema { get; set; }

        public List <Actor> Actors { get; set; }
        */
        public MovieCategory MovieCategory { get; set; }
        public string? Producer { get; set; }
        public string? ImageUrl { get; set; }
    }
}
