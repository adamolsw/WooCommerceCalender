using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WooCommerceWorkerService.Services;

namespace WooCommerceApp
{
    public partial class RemoveDayPerOrder : Form
    {
        public DateTime CurrentDateTime { get; set; }
        public int OrderId { get; set; }
        public string FullName { get; set; }
        private IDbService _dbService;

        public RemoveDayPerOrder(IDbService dbService)
        {
            _dbService = dbService;
            InitializeComponent();
        }

        private void lblConfirm_Click(object sender, EventArgs e)
        {
            _dbService.AddExcludedDay(OrderId, CurrentDateTime);
            this.Close();
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemoveDayPerOrder_Load(object sender, EventArgs e)
        {
            lblWarningText01.Text = string.Concat("Klient:  ", FullName);
            lblWarningText02.Text = string.Concat("Data:    ", CurrentDateTime.ToString("yyyy-MM-dd"));
        }

        private void lblWarningText01_Click(object sender, EventArgs e)
        {
        }

        private void lblCancel_MouseHover(object sender, EventArgs e)
        {
            lblCancel.Image = ((Image)(Properties.Resources.buttonOnHover_ConfirmRemove));
        }

        private void lblCancel_MouseLeave(object sender, EventArgs e)
        {
            lblCancel.Image = ((Image)(Properties.Resources.buttonOnLeave_ConfirmRemove));
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.Image = ((Image)(Properties.Resources.buttonOnHover_ConfirmRemove));
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.Image = ((Image)(Properties.Resources.buttonOnLeave_ConfirmRemove));
        }
    }
}
