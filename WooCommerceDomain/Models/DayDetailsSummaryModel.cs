using System.ComponentModel;

namespace WooCommerceDomain.Models
{
    public class DayDetailsSummaryModel
    {
        [DisplayName("Dieta")]
        public string ProductName { get; set; }
        [DisplayName("Ilość zamówień")]
        public int Sum { get; set; }
    }
}
