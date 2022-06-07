using System;

namespace WooCommerceDomain.Models.DbModels
{
    public class DbOrderModel
    {
        public int Id { get; set; }

        public string Status { get; set; }
        public string DateCreated { get; set; }
        public string ProductName { get; set; }
        public string Total { get; set; }
        public int DaysCount { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string DietDescription { get; set; }
        public ClientModel Client { get; set; }
    }
}
