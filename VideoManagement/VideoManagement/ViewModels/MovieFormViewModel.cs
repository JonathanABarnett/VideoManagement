using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VideoManagement.Models;

namespace VideoManagement.ViewModels
{
    public class MovieFormViewModel
    {
        public int? Id { get; set; }

        [Required(ErrorMessage = "Please enter the movie's Title")]
        [Display(Name = "Title")]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the release date")]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Required(ErrorMessage = "The number in stock must be between 1 - 20")]
        [Range(1, 20)]
        [Display(Name = "Number in Stock")]
        public int? NumberInStock { get; set; }

        public int? GenreId { get; set; }

        public IEnumerable<Genre> Genres { get; set; }

        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }
    }

}