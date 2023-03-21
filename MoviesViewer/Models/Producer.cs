﻿using System.ComponentModel.DataAnnotations;

namespace MoviesViewer.Models
{
    public class Producer
    {
        [Key]
        public int ProducerId { get; set; }
        [Display(Name = "Name")]
        public string? Name { get; set; }
        [Display(Name = "Profile Picture")]
        public string? ProfilePictureUrl { get; set; }
        [Display(Name = "Biography")]
        public string? Bio { get; set; }

        //Relationships 
        public List <Movie>? Movies { get; set; }

    }
}
