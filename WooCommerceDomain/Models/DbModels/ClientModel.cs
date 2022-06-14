using System;

namespace WooCommerceDomain.Models.DbModels
{
    public class ClientModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public AddressModel Address { get; set; }
        public int AddressId { get; set; }
        public DateTime? Birthday { get; set; }
    }
}
