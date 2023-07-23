using eTickets.Data.Base;
using eTickets.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class NewMovieVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Movie name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [Display(Name = "Movie description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Display(Name = "Price in $")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Movie poster is required")]
        [Display(Name = "Movie poster URL")]
        public string ImageURL { get; set; }

        [Required(ErrorMessage = "Start date is required")]
        [Display(Name = "Start date")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "End date is required")]
        [Display(Name = "End date")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Movie category is required")]
        [Display(Name = "Select a category")]
        public MovieCategory MovieCategory { get; set; }

        [Required(ErrorMessage = "Movie actor(s) is required")]
        [Display(Name = "Select actor(s)")]
        public List<int> ActorIds { get; set; }

        [Required(ErrorMessage = "Cinema is required")]
        [Display(Name = "Select a cinema")]
        public int CinemaId { get; set; }

        [Required(ErrorMessage = "Producer is required")]
        [Display(Name = "Select a producer")]
        public int ProducerId { get; set; }
        
    }
}
