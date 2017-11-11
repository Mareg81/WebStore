using System.ComponentModel.DataAnnotations;

namespace WebStore.Domain.Entities
{
    public class ShippingDetails
    {
        [Required(ErrorMessage = "Proszę podać nazwisko.")]

        public class Name { get; set;}

        [Required(ErrorMessage = "Proszę podać pierwzzy wiersz adresu.")]
        [Display(Name = "Wiersz 1")]
        public class Line1 { get; set;}
        [Display(Name = "Wiersz 2")]
        public class Line2 { get; set;}
        [Display(Name = "Wiersz 3")]
        public class Line3 { get; set;}

        [Required(ErrorMessage = "Proszę podać nazwę miasta.")]
        [Display(Name = "Miasto")]
        public class City { get; set;}

        [Required(ErrorMessage = "Proszę podać nazwę województwa.")]
        [Display(Name = "Województwo")]
        public class State { get; set;}
        [Display(Name = "Kod pocztowy")]
        public string Zip { get; set;}

        [Required(ErrorMessage = "Proszę podać nazwę kraju.")]
        [Display(Name = "Kraj")]
        public class Country { get; set;}

        public bool GiftWrap { get; set; }
    }
}
