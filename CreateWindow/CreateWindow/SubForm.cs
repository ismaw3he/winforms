using System;
using System.Windows.Forms;

namespace CreateWindow
{
    public partial class SubForm : Form
    {
        private Product product = new Product();

        public Product GetProduct()
        {
            product.Title = titleTextBox.Text;
            product.Vendor = vendorTextBox.Text;
            product.Price = (float)priceNumericUD.Value;
            return product;
        }

        public void SetProduct(Product product)
        {
            this.product = product;
            titleTextBox.Text = product.Title;
            vendorTextBox.Text = product.Vendor;
            priceNumericUD.Value = (decimal)product.Price;
        }

        public SubForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
