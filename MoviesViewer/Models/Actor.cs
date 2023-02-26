using System.ComponentModel.DataAnnotations;

namespace MoviesViewer.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }
        [Display(Name = "Profile Picture URL")]
        public string? ProfilePictureUrl { get; set; }
        [Display(Name = "Actor's Name")]
        public string? ActorName { get; set; }
        [Display(Name = "Biography")]
        public string? Bio { get; set; }

        //Relationships 
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
