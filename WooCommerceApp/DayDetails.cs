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
    public partial class DayDetails : Form
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }

        public DateTime CurrentDateTime = new DateTime();

        public DayDetails()
        {
            InitializeComponent();
        }

        private void DayDetails_Load(object sender, EventArgs e)
        {
            Random rnd = new Random(); 
            int num = rnd.Next(1, 40);
            dgvDailyDetails.DataSource = userModels.OrderBy(x => Guid.NewGuid()).Take(num).ToList();
            
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
            dgvDailyDetails.DataSource = userModels.OrderBy(x => Guid.NewGuid()).Take(num).ToList();
        }

        private void lbArrowPrevious_Click(object sender, EventArgs e)
        {
            CurrentDateTime = CurrentDateTime.AddDays(-1);
            SetlbDayMonthYear();
            dgvDailyDetails.DataSource = null;
            Random rnd = new Random();
            int num = rnd.Next(1, 40);
            dgvDailyDetails.DataSource = userModels.OrderBy(x => Guid.NewGuid()).Take(num).ToList();
        }

        private List<DayDetailsModel> userModels = new List<DayDetailsModel>
        {
            new DayDetailsModel
            {
                FirstName = "Adam",
                LastName = "Kowalski",
                Address = "Nadmorski Dwór",
                City = "Gdańsk",
                CustomerNote = "Kod do domofonu 380800",
                Phone = "+48690874605",
                DietName = "Dieta z niskim indeksem",
                Email = "email@nomail.com",
                Kcal = "1500",
                PostCode = "80-186"
            },
            new DayDetailsModel
            {
                FirstName = "Jarosław",
                LastName = "Kaczyński",
                Address = "Kocia 3/4",
                City = "Warszawa",
                CustomerNote = "Coś dla kota",
                Phone = "+48655590205",
                DietName = "Dieta z wysokim indeksem",
                Email = "poczta@nomail.com",
                Kcal = "2000",
                PostCode = "94-186"
            },
            new DayDetailsModel
            {
                FirstName = "Donald",
                LastName = "Tusk",
                Address = "Berlińska 9",
                City = "Berlin",
                CustomerNote = "Cathegingh",
                Phone = "+54612347845",
                DietName = "Dieta z wysokim indeksem",
                Email = "poczta@nomail.com",
                Kcal = "2000",
                PostCode = "94-186"
            },
            new DayDetailsModel
            {
                FirstName = "Wateusz",
                LastName = "Morawiecki",
                Address = "Vatowa 100",
                City = "Warszawa",
                CustomerNote = "Opodatkowana",
                Phone = "",
                DietName = "Dieta redukcyjna",
                Email = "wp@pl.com",
                Kcal = "1750",
                PostCode = "10-100"
            },
            new DayDetailsModel
            {
                FirstName = "Adam",
                LastName = "Kowalski",
                Address = "Nadmorski Dwór",
                City = "Gdańsk",
                CustomerNote = "",
                Phone = "+48690874605",
                DietName = "Dieta z wysokim indeksem",
                Email = "poczta@nomail.com",
                Kcal = "2000",
                PostCode = "94-186"
            },
            new DayDetailsModel
            {
                FirstName = "Jarosław",
                LastName = "Kaczyński",
                Address = "Kocia 3/4",
                City = "Warszawa",
                CustomerNote = "Coś dla kota",
                Phone = "+48655590205"
            },
            new DayDetailsModel
            {
                FirstName = "Donald",
                LastName = "Tusk",
                Address = "Berlińska 9",
                City = "Berlin",
                CustomerNote = "Cathegingh",
                Phone = "+54612347845"
            },
            new DayDetailsModel
            {
                FirstName = "Wateusz",
                LastName = "Morawiecki",
                Address = "Vatowa 100",
                City = "Warszawa",
                CustomerNote = "Opodatkowana",
                Phone = "+999999999"
            },
            new DayDetailsModel
            {
                FirstName = "Adam",
                LastName = "Kowalski",
                Address = "Nadmorski Dwór",
                City = "Gdańsk",
                CustomerNote = "Kod do domofonu 380800",
                Phone = "+48690874605"
            },
            new DayDetailsModel
            {
                FirstName = "Jarosław",
                LastName = "Kaczyński",
                Address = "Kocia 3/4",
                City = "Warszawa",
                CustomerNote = "Coś dla kota",
                Phone = "+48655590205"
            },
            new DayDetailsModel
            {
                FirstName = "Donald",
                LastName = "Tusk",
                Address = "Berlińska 9",
                City = "Berlin",
                CustomerNote = "Cathegingh",
                Phone = "+54612347845"
            },
            new DayDetailsModel
            {
                FirstName = "Wateusz",
                LastName = "Morawiecki",
                Address = "Vatowa 100",
                City = "Warszawa",
                CustomerNote = "Opodatkowana",
                Phone = "+999999999"
            },
            new DayDetailsModel
            {
                FirstName = "Adam",
                LastName = "Kowalski",
                Address = "Nadmorski Dwór",
                City = "Gdańsk",
                CustomerNote = "Kod do domofonu 380800",
                Phone = "+48690874605"
            },
            new DayDetailsModel
            {
                FirstName = "Jarosław",
                LastName = "Kaczyński",
                Address = "Kocia 3/4",
                City = "Warszawa",
                CustomerNote = "Coś dla kota",
                Phone = "+48655590205"
            },
            new DayDetailsModel
            {
                FirstName = "Donald",
                LastName = "Tusk",
                Address = "Berlińska 9",
                City = "Berlin",
                CustomerNote = "Cathegingh",
                Phone = "+54612347845"
            },
            new DayDetailsModel
            {
                FirstName = "Wateusz",
                LastName = "Morawiecki",
                Address = "Vatowa 100",
                City = "Warszawa",
                CustomerNote = "Opodatkowana",
                Phone = "+999999999"
            },
            new DayDetailsModel
            {
                FirstName = "Adam",
                LastName = "Kowalski",
                Address = "Nadmorski Dwór",
                City = "Gdańsk",
                CustomerNote = "Kod do domofonu 380800",
                Phone = "+48690874605"
            },
            new DayDetailsModel
            {
                FirstName = "Jarosław",
                LastName = "Kaczyński",
                Address = "Kocia 3/4",
                City = "Warszawa",
                CustomerNote = "Coś dla kota",
                Phone = "+48655590205"
            },
            new DayDetailsModel
            {
                FirstName = "Donald",
                LastName = "Tusk",
                Address = "Berlińska 9",
                City = "Berlin",
                CustomerNote = "Cathegingh",
                Phone = "+54612347845"
            },
            new DayDetailsModel
            {
                FirstName = "Wateusz",
                LastName = "Morawiecki",
                Address = "Vatowa 100",
                City = "Warszawa",
                CustomerNote = "Opodatkowana",
                Phone = "+999999999"
            },
            new DayDetailsModel
            {
                FirstName = "Adam",
                LastName = "Kowalski",
                Address = "Nadmorski Dwór",
                City = "Gdańsk",
                CustomerNote = "Kod do domofonu 380800",
                Phone = "+48690874605"
            },
            new DayDetailsModel
            {
                FirstName = "Jarosław",
                LastName = "Kaczyński",
                Address = "Kocia 3/4",
                City = "Warszawa",
                CustomerNote = "Coś dla kota",
                Phone = "+48655590205"
            },
            new DayDetailsModel
            {
                FirstName = "Donald",
                LastName = "Tusk",
                Address = "Berlińska 9",
                City = "Berlin",
                CustomerNote = "Cathegingh",
                Phone = "+54612347845"
            },
            new DayDetailsModel
            {
                FirstName = "Wateusz",
                LastName = "Morawiecki",
                Address = "Vatowa 100",
                City = "Warszawa",
                CustomerNote = "Opodatkowana",
                Phone = "+999999999"
            },
            new DayDetailsModel
            {
                FirstName = "Adam",
                LastName = "Kowalski",
                Address = "Nadmorski Dwór",
                City = "Gdańsk",
                CustomerNote = "Kod do domofonu 380800",
                Phone = "+48690874605"
            },
            new DayDetailsModel
            {
                FirstName = "Jarosław",
                LastName = "Kaczyński",
                Address = "Kocia 3/4",
                City = "Warszawa",
                CustomerNote = "Coś dla kota",
                Phone = "+48655590205"
            },
            new DayDetailsModel
            {
                FirstName = "Donald",
                LastName = "Tusk",
                Address = "Berlińska 9",
                City = "Berlin",
                CustomerNote = "Cathegingh",
                Phone = "+54612347845"
            },
            new DayDetailsModel
            {
                FirstName = "Wateusz",
                LastName = "Morawiecki",
                Address = "Vatowa 100",
                City = "Warszawa",
                CustomerNote = "Opodatkowana",
                Phone = "+999999999"
            },
            new DayDetailsModel
            {
                FirstName = "Adam",
                LastName = "Kowalski",
                Address = "Nadmorski Dwór",
                City = "Gdańsk",
                CustomerNote = "Kod do domofonu 380800",
                Phone = "+48690874605"
            },
            new DayDetailsModel
            {
                FirstName = "Jarosław",
                LastName = "Kaczyński",
                Address = "Kocia 3/4",
                City = "Warszawa",
                CustomerNote = "Coś dla kota",
                Phone = "+48655590205"
            },
            new DayDetailsModel
            {
                FirstName = "Donald",
                LastName = "Tusk",
                Address = "Berlińska 9",
                City = "Berlin",
                CustomerNote = "Cathegingh",
                Phone = "+54612347845"
            },
            new DayDetailsModel
            {
                FirstName = "Wateusz",
                LastName = "Morawiecki",
                Address = "Vatowa 100",
                City = "Warszawa",
                CustomerNote = "Opodatkowana",
                Phone = "+999999999"
            },
            new DayDetailsModel
            {
                FirstName = "Adam",
                LastName = "Kowalski",
                Address = "Nadmorski Dwór",
                City = "Gdańsk",
                CustomerNote = "Kod do domofonu 380800",
                Phone = "+48690874605"
            },
            new DayDetailsModel
            {
                FirstName = "Jarosław",
                LastName = "Kaczyński",
                Address = "Kocia 3/4",
                City = "Warszawa",
                CustomerNote = "Coś dla kota",
                Phone = "+48655590205"
            },
            new DayDetailsModel
            {
                FirstName = "Donald",
                LastName = "Tusk",
                Address = "Berlińska 9",
                City = "Berlin",
                CustomerNote = "Cathegingh",
                Phone = "+54612347845"
            },
            new DayDetailsModel
            {
                FirstName = "Wateusz",
                LastName = "Morawiecki",
                Address = "Vatowa 100",
                City = "Warszawa",
                CustomerNote = "Opodatkowana",
                Phone = "+999999999"
            },
            new DayDetailsModel
            {
                FirstName = "Adam",
                LastName = "Kowalski",
                Address = "Nadmorski Dwór",
                City = "Gdańsk",
                CustomerNote = "Kod do domofonu 380800",
                Phone = "+48690874605"
            },
            new DayDetailsModel
            {
                FirstName = "Jarosław",
                LastName = "Kaczyński",
                Address = "Kocia 3/4",
                City = "Warszawa",
                CustomerNote = "Coś dla kota",
                Phone = "+48655590205"
            },
            new DayDetailsModel
            {
                FirstName = "Donald",
                LastName = "Tusk",
                Address = "Berlińska 9",
                City = "Berlin",
                CustomerNote = "Cathegingh",
                Phone = "+54612347845"
            },
            new DayDetailsModel
            {
                FirstName = "Wateusz",
                LastName = "Morawiecki",
                Address = "Vatowa 100",
                City = "Warszawa",
                CustomerNote = "Opodatkowana",
                Phone = "+999999999"
            },
            new DayDetailsModel
            {
                FirstName = "Adam",
                LastName = "Kowalski",
                Address = "Nadmorski Dwór",
                City = "Gdańsk",
                CustomerNote = "Kod do domofonu 380800",
                Phone = "+48690874605"
            },
            new DayDetailsModel
            {
                FirstName = "Jarosław",
                LastName = "Kaczyński",
                Address = "Kocia 3/4",
                City = "Warszawa",
                CustomerNote = "Coś dla kota",
                Phone = "+48655590205"
            },
            new DayDetailsModel
            {
                FirstName = "Donald",
                LastName = "Tusk",
                Address = "Berlińska 9",
                City = "Berlin",
                CustomerNote = "Cathegingh",
                Phone = "+54612347845"
            },
            new DayDetailsModel
            {
                FirstName = "Wateusz",
                LastName = "Morawiecki",
                Address = "Vatowa 100",
                City = "Warszawa",
                CustomerNote = "Opodatkowana",
                Phone = "+999999999"
            },
            new DayDetailsModel
            {
                FirstName = "Adam",
                LastName = "Kowalski",
                Address = "Nadmorski Dwór",
                City = "Gdańsk",
                CustomerNote = "Kod do domofonu 380800",
                Phone = "+48690874605"
            },
            new DayDetailsModel
            {
                FirstName = "Jarosław",
                LastName = "Kaczyński",
                Address = "Kocia 3/4",
                City = "Warszawa",
                CustomerNote = "Coś dla kota",
                Phone = "+48655590205"
            },
            new DayDetailsModel
            {
                FirstName = "Donald",
                LastName = "Tusk",
                Address = "Berlińska 9",
                City = "Berlin",
                CustomerNote = "Cathegingh",
                Phone = "+54612347845"
            },
            new DayDetailsModel
            {
                FirstName = "Wateusz",
                LastName = "Morawiecki",
                Address = "Vatowa 100",
                City = "Warszawa",
                CustomerNote = "Opodatkowana",
                Phone = "+999999999"
            },
            new DayDetailsModel
            {
                FirstName = "Adam",
                LastName = "Kowalski",
                Address = "Nadmorski Dwór",
                City = "Gdańsk",
                CustomerNote = "Kod do domofonu 380800",
                Phone = "+48690874605"
            },
            new DayDetailsModel
            {
                FirstName = "Jarosław",
                LastName = "Kaczyński",
                Address = "Kocia 3/4",
                City = "Warszawa",
                CustomerNote = "Coś dla kota",
                Phone = "+48655590205"
            },
            new DayDetailsModel
            {
                FirstName = "Donald",
                LastName = "Tusk",
                Address = "Berlińska 9",
                City = "Berlin",
                CustomerNote = "Cathegingh",
                Phone = "+54612347845"
            },
            new DayDetailsModel
            {
                FirstName = "Wateusz",
                LastName = "Morawiecki",
                Address = "Vatowa 100",
                City = "Warszawa",
                CustomerNote = "Opodatkowana",
                Phone = "+999999999"
            },
            new DayDetailsModel
            {
                FirstName = "Adam",
                LastName = "Kowalski",
                Address = "Nadmorski Dwór",
                City = "Gdańsk",
                CustomerNote = "Kod do domofonu 380800",
                Phone = "+48690874605"
            },
            new DayDetailsModel
            {
                FirstName = "Jarosław",
                LastName = "Kaczyński",
                Address = "Kocia 3/4",
                City = "Warszawa",
                CustomerNote = "Coś dla kota",
                Phone = "+48655590205"
            },
            new DayDetailsModel
            {
                FirstName = "Donald",
                LastName = "Tusk",
                Address = "Berlińska 9",
                City = "Berlin",
                CustomerNote = "Cathegingh",
                Phone = "+54612347845"
            },
            new DayDetailsModel
            {
                FirstName = "Wateusz",
                LastName = "Morawiecki",
                Address = "Vatowa 100",
                City = "Warszawa",
                CustomerNote = "Opodatkowana",
                Phone = "+999999999"
            },
            new DayDetailsModel
            {
                FirstName = "Adam",
                LastName = "Kowalski",
                Address = "Nadmorski Dwór",
                City = "Gdańsk",
                CustomerNote = "Kod do domofonu 380800",
                Phone = "+48690874605"
            },
            new DayDetailsModel
            {
                FirstName = "Jarosław",
                LastName = "Kaczyński",
                Address = "Kocia 3/4",
                City = "Warszawa",
                CustomerNote = "Coś dla kota",
                Phone = "+48655590205"
            },
            new DayDetailsModel
            {
                FirstName = "Donald",
                LastName = "Tusk",
                Address = "Berlińska 9",
                City = "Berlin",
                CustomerNote = "Cathegingh",
                Phone = "+54612347845"
            },
            new DayDetailsModel
            {
                FirstName = "Wateusz",
                LastName = "Morawiecki",
                Address = "Vatowa 100",
                City = "Warszawa",
                CustomerNote = "Opodatkowana",
                Phone = "+999999999"
            },
            new DayDetailsModel
            {
                FirstName = "Adam",
                LastName = "Kowalski",
                Address = "Nadmorski Dwór",
                City = "Gdańsk",
                CustomerNote = "Kod do domofonu 380800",
                Phone = "+48690874605"
            },
            new DayDetailsModel
            {
                FirstName = "Jarosław",
                LastName = "Kaczyński",
                Address = "Kocia 3/4",
                City = "Warszawa",
                CustomerNote = "Coś dla kota",
                Phone = "+48655590205"
            },
            new DayDetailsModel
            {
                FirstName = "Donald",
                LastName = "Tusk",
                Address = "Berlińska 9",
                City = "Berlin",
                CustomerNote = "Cathegingh",
                Phone = "+54612347845"
            },
            new DayDetailsModel
            {
                FirstName = "Wateusz",
                LastName = "Morawiecki",
                Address = "Vatowa 100",
                City = "Warszawa",
                CustomerNote = "Opodatkowana",
                Phone = "+999999999"
            },
            new DayDetailsModel
            {
                FirstName = "Adam",
                LastName = "Kowalski",
                Address = "Nadmorski Dwór",
                City = "Gdańsk",
                CustomerNote = "Kod do domofonu 380800",
                Phone = "+48690874605"
            },
            new DayDetailsModel
            {
                FirstName = "Jarosław",
                LastName = "Kaczyński",
                Address = "Kocia 3/4",
                City = "Warszawa",
                CustomerNote = "Coś dla kota",
                Phone = "+48655590205"
            },
            new DayDetailsModel
            {
                FirstName = "Donald",
                LastName = "Tusk",
                Address = "Berlińska 9",
                City = "Berlin",
                CustomerNote = "Cathegingh",
                Phone = "+54612347845"
            },
            new DayDetailsModel
            {
                FirstName = "Wateusz",
                LastName = "Morawiecki",
                Address = "Vatowa 100",
                City = "Warszawa",
                CustomerNote = "Opodatkowana",
                Phone = "+999999999"
            },
            new DayDetailsModel
            {
                FirstName = "Adam",
                LastName = "Kowalski",
                Address = "Nadmorski Dwór",
                City = "Gdańsk",
                CustomerNote = "Kod do domofonu 380800",
                Phone = "+48690874605"
            },
            new DayDetailsModel
            {
                FirstName = "Jarosław",
                LastName = "Kaczyński",
                Address = "Kocia 3/4",
                City = "Warszawa",
                CustomerNote = "Coś dla kota",
                Phone = "+48655590205"
            },
            new DayDetailsModel
            {
                FirstName = "Donald",
                LastName = "Tusk",
                Address = "Berlińska 9",
                City = "Berlin",
                CustomerNote = "Cathegingh",
                Phone = "+54612347845"
            },
            new DayDetailsModel
            {
                FirstName = "Wateusz",
                LastName = "Morawiecki",
                Address = "Vatowa 100",
                City = "Warszawa",
                CustomerNote = "Opodatkowana",
                Phone = "+999999999"
            },
            new DayDetailsModel
            {
                FirstName = "Vladimir",
                LastName = "Putin",
                Address = "Stalinowska 100c",
                City = "Moskwa",
                CustomerNote = "Operacja specjalna",
                Phone = "+80021548"
            }
        };
    }
}
