using System;
using System.ComponentModel;

namespace WooCommerceDomain.Models
{
    public class DayDetailsModel
    {
        public int Id { get; set; }
        [DisplayName("Imię")]
        public string FirstName { get; set; }
        [DisplayName("Nazwisko")]
        public string LastName { get; set; }
        [DisplayName("Dieta")]
        public string ProductName { get; set; }
        [DisplayName("Kalorie")]
        public string DietDescription { get; set; }
        [DisplayName("Ulica")]
        public string Street { get; set; }
        [DisplayName("Miasto")]
        public string City { get; set; }
        [DisplayName("Telefon")]
        public string Phone { get; set; }
        [DisplayName("Urodziny")]
        public DateTime Birthday { get; set; }
    }
}
