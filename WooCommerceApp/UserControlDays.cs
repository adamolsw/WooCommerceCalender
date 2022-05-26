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

namespace WooCommerceApp
{
    public partial class UserControlDays : UserControl
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            DayDetails dayDetails = new DayDetails();
            //dayDetails.Year = Year;
            //dayDetails.Month = Month;
            //dayDetails.Day = Day;
            dayDetails.CurrentDateTime = new DateTime(Year, Month, Day);
            dayDetails.SetlbDayMonthYear(); 
            dayDetails.Show();
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

        public void SetlbNumOfOrdersText(int numOfOrders)
        {
            lbNumOfOrders.Text = numOfOrders.ToString();
        }

        private void UserControlDays_Load_1(object sender, EventArgs e)
        {

        }
    }
}
