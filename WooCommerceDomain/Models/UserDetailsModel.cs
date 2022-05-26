using System.Collections.Generic;
using System.ComponentModel;

namespace WooCommerceDomain.Models
{
    public class UserDetailsModel
    {
        public int UserId { get; set; }
        [DisplayName("Imię i nazwisko")]
        public string UserName { get; set; }
        [DisplayName("Dieta")]
        public virtual List<UserActiveDayModel> UserActiveDayList { get; set; }
       
    }
}
