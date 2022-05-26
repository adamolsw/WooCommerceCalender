using System.ComponentModel;

namespace WooCommerceDomain.Models
{
    public class DayDetailsModel
    {
        [DisplayName("Imię")]
        public string FirstName { get; set; }
        [DisplayName("Nazwisko")]
        public string LastName { get; set; }
        [DisplayName("Dieta")]
        public string DietName { get; set; }
        [DisplayName("Kalorie")]
        public string Kcal { get; set; }
        [DisplayName("Ulica")]
        public string Address { get; set; }
        [DisplayName("Miasto")]
        public string City { get; set; }
        [DisplayName("Kod pocztowy")]
        public string PostCode { get; set; }
        [DisplayName("Telefon")]
        public string Phone { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; }
        [DisplayName("Notatka klienta")]
        public string CustomerNote { get; set; }
    }
}
