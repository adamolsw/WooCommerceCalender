using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WooCommerceApp.Enums;
using WooCommerceApp.Utils;
using WooCommerceDomain.Models;
using WooCommerceWorkerService.Services;

namespace WooCommerceApp
{
    public partial class DayDetails : Form
    {
        private IDbService _dbService;
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }

        public DateTime CurrentDateTime = new DateTime();

        public DayDetails(IDbService dbService)
        {
            _dbService = dbService;
            InitializeComponent();
        }

        private void DayDetails_Load(object sender, EventArgs e)
        {
            var date = string.Concat(CurrentDateTime.Year, "-", CurrentDateTime.Month, "-", CurrentDateTime.Day);
            dgvDailyDetails.DataSource = _dbService.GetOrdersDetailsForSingleDayByDay(date); 
        }

        public void SetlbDayMonthYear()
        {
            var monthName = (Months)CurrentDateTime.Month;
            var dayName = (Days)CurrentDateTime.DayOfWeek;
            lbDayMonthYear.Text = string.Concat(CurrentDateTime.Day, " ", monthName, " ", CurrentDateTime.Year, " (", dayName, ")");
        }
        private void lbArrowNext_Click(object sender, EventArgs e)
        {
            CurrentDateTime = CurrentDateTime.AddDays(1);
            SetlbDayMonthYear();
            dgvDailyDetails.DataSource = null;
            if (!(CurrentDateTime.IsSunday() || CurrentDateTime.IsSaturday()))
            {
                var date = string.Concat(CurrentDateTime.Year, "-", CurrentDateTime.Month, "-", CurrentDateTime.Day);
                dgvDailyDetails.DataSource = _dbService.GetOrdersDetailsForSingleDayByDay(date);
            }
        }

        private void lbArrowPrevious_Click(object sender, EventArgs e)
        {
            CurrentDateTime = CurrentDateTime.AddDays(-1);
            SetlbDayMonthYear();
            dgvDailyDetails.DataSource = null;
            if (!(CurrentDateTime.IsSunday() || CurrentDateTime.IsSaturday()))
            {
                var date = string.Concat(CurrentDateTime.Year, "-", CurrentDateTime.Month, "-", CurrentDateTime.Day);
                dgvDailyDetails.DataSource = _dbService.GetOrdersDetailsForSingleDayByDay(date);
            }
        }
    }
}
