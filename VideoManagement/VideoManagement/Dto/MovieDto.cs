using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VideoManagement.Models;

namespace VideoManagement.Dto
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the movie's Title")]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the release date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        [Required(ErrorMessage = "The number in stock must be between 1 - 20")]
        [Range(1, 20)]
        public int NumberInStock { get; set; }

        public int GenreId { get; set; }
    }
}