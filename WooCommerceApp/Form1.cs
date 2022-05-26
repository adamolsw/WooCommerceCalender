using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WooCommerceApp.Enums;

namespace WooCommerceApp
{
    public partial class Form1 : Form
    {
        private int _month, _year, _currentMonth, _currentYear, _currentDay;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayDays();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (_month == 12)
            {
                _month = 1;
                _year++;
            }
            else
            {
                _month++;
            }
            dayContainer.Controls.Clear();
            SetUpMonthDays(_month, _year);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (_month == 1)
            {
                _month = 12;
                _year--;
            }
            else
            {
                _month--;
            }
            dayContainer.Controls.Clear();
            SetUpMonthDays(_month, _year);
        }

        private void DisplayDays()
        {
            _currentMonth = DateTime.Now.Month;
            _currentYear = DateTime.Now.Year;
            _currentDay = DateTime.Now.Day;
            _month = _currentMonth;
            _year = _currentYear;
            SetUpMonthDays(_month, _year);
        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            if(_month == 12)
            {
                _month = 1;
                _year++;
            }
            else
            {
                _month++;
            }
            dayContainer.Controls.Clear();
            SetUpMonthDays(_month, _year);
        }

        private void btnPreviousMonth_Click(object sender, EventArgs e)
        {
            if (_month == 1)
            {
                _month = 12;
                _year--;
            }
            else
            {
                _month--;
            }
            dayContainer.Controls.Clear();
            SetUpMonthDays(_month, _year);
        }

        private void SetUpMonthDays(int month, int year)
        {
            var startOfTheMonth = new DateTime(year, month, 1);
            int daysInMonth = DateTime.DaysInMonth(year, month);
            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) == 0 ? 7 : Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"));

            var monthName = (Months)month;
            lbMonthYear.Text = monthName + " " + year;

            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlBlank userControlBlank = new UserControlBlank();
                dayContainer.Controls.Add(userControlBlank);
            }

            for (int i = 1; i <= daysInMonth; i++)
            {
                UserControlDays userControlDays = new UserControlDays();
                if(_currentDay == i && _currentMonth == _month && _currentYear == _year)
                {
                    userControlDays.BackColor = Color.FromArgb(15, 53, 111);
                    userControlDays.SetlbDaysBackColor(Color.FromArgb(15, 53, 111));
                }

                DateTime processingDay = new DateTime(_year, _month, i);
                if(IsSunday(processingDay))
                {
                    userControlDays.SetlbDaysTextColor(Color.FromArgb(219, 92, 33));
                }

                Random rnd = new Random();
                int num = rnd.Next(1, 100);
                userControlDays.SetlbNumOfOrdersText(num);

                userControlDays.Days(i);
                dayContainer.Controls.Add(userControlDays);

                userControlDays.Year = _year;
                userControlDays.Month = _month;
                userControlDays.Day = i;
            }
        }

        private bool IsSunday(DateTime dateTime)
        {
           return dateTime.DayOfWeek == DayOfWeek.Sunday;
        }

        private void lbMonthYear_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

            UserDetails userDetails = new UserDetails();
            //dayDetails.Year = Year;
            //dayDetails.Month = Month;
            //dayDetails.Day = Day;
            userDetails.SetlbDayMonthYear();
            userDetails.Show();
        }

        private void SetArrowNextOnHover(object sender, EventArgs e)
        {
            lbArrowNext.BorderStyle = BorderStyle.FixedSingle;
        }
        private void SetArrowNextOnLeave(object sender, EventArgs e)
        {
            lbArrowNext.BorderStyle = BorderStyle.None;
        }

        private void SetArrowPreviousOnHover(object sender, EventArgs e)
        {
            lbArrowPrevious.BorderStyle = BorderStyle.FixedSingle;
        }
        private void SetArrowPreviousOnLeave(object sender, EventArgs e)
        {
            lbArrowPrevious.BorderStyle = BorderStyle.None;
        }
    }
}
