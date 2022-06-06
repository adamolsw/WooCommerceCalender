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
        public string DateStart { get; set; }
        public string DateEnd { get; set; }
        public string DietDescription { get; set; }
        public ClientModel Client { get; set; }
    }
}
