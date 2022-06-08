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
            LoadData();
        }

        public void ReloadData(object sender, EventArgs e)
        {
            dgvDailyDetails.DataSource = null;
            dgvSummary.DataSource = null;
            LoadData();
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
            dgvSummary.DataSource = null;
            if (!(CurrentDateTime.IsSunday() || CurrentDateTime.IsSaturday()))
            {
                var date = string.Concat(CurrentDateTime.Year, "-", CurrentDateTime.Month, "-", CurrentDateTime.Day); 
                var orders = _dbService.GetOrdersDetailsForSingleDayByDay(date);
                dgvSummary.DataSource = GetSummary(orders);
                dgvDailyDetails.DataSource = orders;
                dgvDailyDetails.Columns[0].Visible = false;
                dgvDailyDetails.CurrentCell = dgvDailyDetails.Rows[0].Cells[1];
            }
            else
            {
                dgvSummary.DataSource = new List<DayDetailsSummaryModel>();
                dgvDailyDetails.DataSource = new List<DayDetailsModel>();
                dgvDailyDetails.Columns[0].Visible = false;
            }
        }

        private void lbArrowPrevious_Click(object sender, EventArgs e)
        {
            CurrentDateTime = CurrentDateTime.AddDays(-1);
            SetlbDayMonthYear();
            dgvDailyDetails.DataSource = null;
            dgvSummary.DataSource = null;
            if (!(CurrentDateTime.IsSunday() || CurrentDateTime.IsSaturday()))
            {
                var date = string.Concat(CurrentDateTime.Year, "-", CurrentDateTime.Month, "-", CurrentDateTime.Day);
                var orders = _dbService.GetOrdersDetailsForSingleDayByDay(date);
                dgvSummary.DataSource = GetSummary(orders);
                dgvDailyDetails.DataSource = orders;
                dgvDailyDetails.Columns[0].Visible = false;
                dgvDailyDetails.CurrentCell = dgvDailyDetails.Rows[0].Cells[1];
            }
            else
            {
                dgvSummary.DataSource = new List<DayDetailsSummaryModel>();
                dgvDailyDetails.DataSource = new List<DayDetailsModel>();
                dgvDailyDetails.Columns[0].Visible = false;
            }
        }

        private List<DayDetailsSummaryModel> GetSummary(List<DayDetailsModel> dayDetailsModels)
        {
            var result = dayDetailsModels.GroupBy(g => g.ProductName).ToList();
            DayDetailsSummaryModel sumOfAllDiets = new DayDetailsSummaryModel { ProductName = "Suma" };
            List<DayDetailsSummaryModel> dayDetailsSummaryModels = new List<DayDetailsSummaryModel>();
            foreach (var item in result)
            {
                dayDetailsSummaryModels.Add(new DayDetailsSummaryModel
                {
                    ProductName = item.Key,
                    Sum = item.Count()
                });
                sumOfAllDiets.Sum += item.Count();
            }
            dayDetailsSummaryModels.Add(sumOfAllDiets);
            return dayDetailsSummaryModels;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AddOrder addOrder = new AddOrder(_dbService);
            addOrder.CurrentDateTime = CurrentDateTime;
            addOrder.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveDayPerOrder removeDayPerOrder = new RemoveDayPerOrder(_dbService);
            if (dgvDailyDetails.CurrentCell != null)
            {
                int rowIndex = dgvDailyDetails.CurrentCell.RowIndex;
                removeDayPerOrder.OrderId = Convert.ToInt32(dgvDailyDetails.Rows[rowIndex].Cells[0].Value);
                removeDayPerOrder.CurrentDateTime = CurrentDateTime;
                removeDayPerOrder.FullName = string.Concat(dgvDailyDetails.Rows[rowIndex].Cells[1].Value, " ", dgvDailyDetails.Rows[rowIndex].Cells[2].Value);                
                removeDayPerOrder.ShowDialog();
            }
        }

        private void LoadData()
        {
            var date = string.Concat(CurrentDateTime.Year, "-", CurrentDateTime.Month, "-", CurrentDateTime.Day);
            var orders = _dbService.GetOrdersDetailsForSingleDayByDay(date);

            if (!(CurrentDateTime.IsSunday() || CurrentDateTime.IsSaturday()))
            {
                dgvSummary.DataSource = GetSummary(orders);
                dgvDailyDetails.DataSource = orders;
                dgvDailyDetails.Columns[0].Visible = false;
                dgvDailyDetails.CurrentCell = dgvDailyDetails.Rows[0].Cells[1];
            }
            else
            {
                dgvSummary.DataSource = new List<DayDetailsSummaryModel>();
                dgvDailyDetails.DataSource = new List<DayDetailsModel>();
                dgvDailyDetails.Columns[0].Visible = false;
            }
        }
    }
}
