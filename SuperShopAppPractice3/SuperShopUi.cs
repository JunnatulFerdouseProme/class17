using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShopAppPractice3
{
    public partial class SuperShopUi : Form
    {
        public SuperShopUi()
        {
            InitializeComponent();
        }

        public Supershop asuperShop = null;

        private void ShopSaveButton_Click(object sender, EventArgs e)
        {
            asuperShop = new Supershop(nameTextBox.Text,addressTextBox.Text);


        }

        private Product aproduct = null;
        private void ProductSaveButton_Click(object sender, EventArgs e)
        {
            Product aproduct=new Product(itemTextBox.Text,Convert.ToInt32(quantityTextBox.Text));

        }

        private void ShowDetailsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asuperShop.getinfo());
        }
    }
}
