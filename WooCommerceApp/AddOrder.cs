using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WooCommerceDomain.Models.DbModels;
using WooCommerceWorkerService.Services;

namespace WooCommerceApp
{
    public partial class AddOrder : Form
    {
        public DateTime CurrentDateTime { get; set; }
        private IDbService _dbService;

        public AddOrder(IDbService dbService)
        {
            _dbService = dbService;
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddOrder_Load(object sender, EventArgs e)
        {
            var products = _dbService.GetProducts();
            foreach (var product in products)
            {
                cbxProducts.Items.Add(product.Name);
            }
            cbxProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            txbDate.Text = CurrentDateTime.ToString("yyyy-MM-dd");
            cbxProducts.SelectedIndex = 0;

            var descriptions = _dbService.GetDietDescription();
            foreach (var item in descriptions)
            {
                cbxDietDescription.Items.Add(item);
            }
            cbxDietDescription.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxDietDescription.SelectedIndex = 0;
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            var cbxSelectedIndex = cbxProducts.SelectedIndex;
            var cbxSelectedText = cbxProducts.SelectedItem.ToString();

            var maxOrderId = _dbService.GetMaxOrderid();
            maxOrderId = maxOrderId < 900000001 ? 900000001 : maxOrderId + 1; 

            AddressModel addressModel = new AddressModel
            {
                Street = txbStreet.Text,
                City = txbCity.Text,
                PostCode = txbPhone.Text
            };

            ClientModel clientModel = new ClientModel
            {
                FirstName = txbFirstName.Text,
                LastName = txbLastName.Text,
                Email = txbEmail.Text,
                Phone = txbPhone.Text,
                Birthday = null,
                Address = addressModel
            };

            DbOrderModel dbOrderModel = new DbOrderModel
            {
                Client = clientModel,
                DateCreated = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"),
                DateEnd = Convert.ToDateTime(txbDate.Text),
                DateStart = Convert.ToDateTime(txbDate.Text),
                DaysCount = 1,
                DietDescription = cbxDietDescription.SelectedItem.ToString(),
                ProductName = cbxSelectedText,
                Status = "processing",
                Total = "0.0",
                Id = maxOrderId
            };

            _dbService.AddOrder(dbOrderModel);
            this.Close();
        }
    }
}
