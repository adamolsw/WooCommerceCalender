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
using WooCommerceWorkerService.Services;

namespace WooCommerceApp
{
    public partial class UserControlDays : UserControl
    {
        private IDbService _dbService;

        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public UserControlDays(IDbService dbService)
        {
            _dbService = dbService;
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            DayDetails dayDetails = new DayDetails(_dbService);
            dayDetails.CurrentDateTime = new DateTime(Year, Month, Day);
            dayDetails.SetlbDayMonthYear(); 
            dayDetails.ShowDialog();
        }

        public void Days(int numDay)
        {
            lbDays.Text = numDay + "";
        }

        public void SetlbDaysBackColor(Color color)
        {
            lbDays.BackColor = color;
            lbDescriptionNumOfOrders.BackColor = color;
            lbNumOfOrders.BackColor = color;
        }

        public void SetlbDaysTextColor(Color color)
        {
            lbDays.ForeColor = color;
        }

        public void SetlbDescriptionNumOfOrdersTextColor(Color color)
        {
            lbDescriptionNumOfOrders.ForeColor = color;
        }

        public void SetlbNumOfOrdersTextColor(Color color)
        {
            lbNumOfOrders.ForeColor = color;
        }

        public void SetlbNumOfOrdersText(int numOfOrders)
        {
            lbNumOfOrders.Text = numOfOrders.ToString();
        }

        private void UserControlDays_Load_1(object sender, EventArgs e)
        {

        }
    }
}
