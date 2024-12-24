using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Client
{
    public partial class ProductItem : UserControl
    {
        Product product = new Product();
        public ProductItem()
        {
            InitializeComponent();
        }
        public Product Product { 
            get { return product; } 
            set 
            { 
                product = value;
                lblProductName.Text = product.ProductName;
                lblProductPrice.Text = currencyFormat(product.Price);
                ptbProductImg.SizeMode = PictureBoxSizeMode.Zoom;
                ptbProductImg.Image = product.Image;
            }
        }
        private string currencyFormat(double money) => string.Format(new CultureInfo("vi-VN"), "{0:C}", money);

        private void panel1_Click(object sender, EventArgs e)
        {

            int id = product.ProductID;
            if (!MenuForm.listId.Contains(id))
            {
                MenuForm.listId.Add(id);
                Cart item = new Cart
                {
                    Product = product,
                    Quantity = 1
                };
                MenuForm.listCart.Add(item);
                MenuForm.checkClick = 1;
            }
            
        }
    }
}
