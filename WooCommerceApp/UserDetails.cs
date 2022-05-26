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
using WooCommerceDomain.Models;

namespace WooCommerceApp
{
    public partial class UserDetails : Form
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }

        public DateTime CurrentDateTime = new DateTime();

        public UserDetails()
        {
            InitializeComponent();
        }

        private void DayDetails_Load(object sender, EventArgs e)
        {
            Random rnd = new Random(); 
            int num = rnd.Next(1, 40);
            dgvDailyDetails.DataSource = userModels.Take(num).ToList();
            
        }

        public void SetlbDayMonthYear()
        {
            var monthName = (Months)CurrentDateTime.Month;
            lbDayMonthYear.Text = string.Concat(CurrentDateTime.Day, " ", monthName, " ", CurrentDateTime.Year);
        }
        private void lbArrowNext_Click(object sender, EventArgs e)
        {
            CurrentDateTime = CurrentDateTime.AddDays(1);
            SetlbDayMonthYear();
            dgvDailyDetails.DataSource = null;
            Random rnd = new Random();
            int num = rnd.Next(1, 40);
            dgvDailyDetails.DataSource = userModels.Take(num).ToList();
        }

        private void lbArrowPrevious_Click(object sender, EventArgs e)
        {
            CurrentDateTime = CurrentDateTime.AddDays(-1);
            SetlbDayMonthYear();
            dgvDailyDetails.DataSource = null;
            Random rnd = new Random();
            int num = rnd.Next(1, 40);
            dgvDailyDetails.DataSource = userModels.Take(num).ToList();
        }

        private List<UserDetailsModel> userModels = new List<UserDetailsModel>
        {
            new UserDetailsModel
            {
                UserId = 1,
                UserName = "Jarosław Kaczynski",
                UserActiveDayList = new List<UserActiveDayModel>
                {
                    new UserActiveDayModel
                    {
                        UserId = 1,
                        ActiveDateTime = new DateTime(2022,05,26)
                    }
                }
            },
            new UserDetailsModel
            {
                UserId = 2,
                UserName = "Andrew Dudeł",
                UserActiveDayList = new List<UserActiveDayModel>
                {
                    new UserActiveDayModel
                    {
                        UserId = 2,
                        ActiveDateTime = new DateTime(2000,05,26)
                    }
                }
            }
        };
    }
}
