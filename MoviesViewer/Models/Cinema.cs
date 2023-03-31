﻿using System.ComponentModel.DataAnnotations;

namespace MoviesViewer.Models
{
    public class Cinema
    {
        [Key]
        public string CinemaId { get; set; }
        [Display (Name = "Logo")]
        public string? Logo { get; set; }
        [Display(Name = "Name")]
        public string? Name { get; set; }
        [Display(Name = "Description")]
        public string? Description { get; set; }

        //Relationships 
        public List<Movie>? Movies { get; set; }
    }
}
