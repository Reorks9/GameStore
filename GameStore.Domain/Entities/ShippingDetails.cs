using System.ComponentModel.DataAnnotations;

namespace GameStore.Domain.Entities
{
    public class ShippingDetails
    {
        [Required(ErrorMessage = "Enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter the first shipping address")]
        [Display(Name = "First shipping address")]
        public string Line1 { get; set; }

        [Display(Name = "Second shipping address")]
        public string Line2 { get; set; }

        [Display(Name = "Third shipping address")]
        public string Line3 { get; set; }

        [Required(ErrorMessage = "Enter the city")]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Enter the country")]
        [Display(Name = "Country")]
        public string Country { get; set; }

        public bool GiftWrap { get; set; }
    }
}