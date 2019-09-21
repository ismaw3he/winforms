using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateWindow
{
    public partial class MainForm : Form
    {
        private BindingList<Product> products;
        public MainForm()
        {
            InitializeComponent();

            products = new BindingList<Product>()
            {
                new Product(){ Title = "Apple", Price = 1.43F, Vendor = "AZ" },
                new Product(){ Title = "Orange", Price = 2.43F, Vendor = "SP" },
                new Product(){ Title = "Pear", Price = 3.43F, Vendor = "AZ" },
            };

            itemsListBox.DataSource = products;
            itemsListBox.DisplayMember = "Title";
            itemsListBox.ValueMember = "Price";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            SubForm productForm = new SubForm();
            if (productForm.ShowDialog() == DialogResult.OK)
            {
                Product prod = productForm.GetProduct();
                products.Add(prod);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedIndex != -1)
            {
                Product editProd = itemsListBox.SelectedItem as Product;
                SubForm productForm = new SubForm();
                productForm.SetProduct(editProd);
                if (productForm.ShowDialog() == DialogResult.OK)
                {
                    products.Remove(editProd);
                    products.Add(productForm.GetProduct());
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedIndex != -1)
            {
                products.Remove(itemsListBox.SelectedItem as Product);
            }
        }
    }
}
