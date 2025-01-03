﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class CartItem : UserControl
    {
        private Cart cart;
        public CartItem()
        {
            InitializeComponent();
        }
        public Cart Cart
        {
            get { return cart; }
            set 
            { 
                cart = value;
                ptbImage.Image = cart.Product.Image;
                lblName.Text = cart.Product.ProductName;
                nudQuantity.Minimum = 1;
                nudQuantity.Maximum = cart.Product.InventoryNumber;
            }
        }

        private void ptbDelete_Click(object sender, EventArgs e)
        {
            MenuForm.listCart.Remove(cart);
            MenuForm.listId.Remove(cart.Product.ProductID);
            MenuForm.checkClick = 1;
        }
        public int getQuantity()
        {
            return int.Parse(nudQuantity.Text);
        }
    }
}
