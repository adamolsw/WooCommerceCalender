using System;

namespace WooCommerceDomain.Models
{
    public class UserActiveDayModel
    {
        public UserDetailsModel UserDetailsModel { get; set; }
        public int UserId { get; set; }

        public DateTime ActiveDateTime { get; set; }

    }
}
