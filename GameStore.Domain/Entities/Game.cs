using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace GameStore.Domain.Entities
{
    public class Game
    {
        [HiddenInput(DisplayValue = false)]
        public int GameId { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Please, enter the game's name")]
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Please, enter the game's description")]
        public string Description { get; set; }

        [Display(Name = "Category")]
        [Required(ErrorMessage = "Please, enter the game's Category")]
        public string Category { get; set; }

        [Display(Name = "Cost (руб)")]
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please, enter the game's Cost")]
        public decimal Price { get; set; }

        public byte[] ImageData { get; set; }

        public string ImageMimeType { get; set; }
    }
}