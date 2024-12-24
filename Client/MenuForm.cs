using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Client
{
    public partial class MenuForm : Form
    {
        private List<Product> products;
        private List<string> listCategory;
        public static List<Cart> listCart = new List<Cart>();
        public static List<int> listId = new List<int>();
        public static int checkClick = -1;
        private ClientForm clientForm;
        private ClientManager clientManager;
        public MenuForm(ClientForm clientForm, ClientManager clientManager)
        {
            InitializeComponent();
            this.clientForm = clientForm;
            this.clientManager = clientManager;
            checkClick = -1;
            listCart.Clear();
            listId.Clear();
            products = clientManager.productList;
            listCategory = clientManager.categoryList;
            cbCategory.DataSource = clientManager.categoryList;
            
        }
        public void loadAllDataProduct()
        {
            pnlProductContainer.Controls.Clear();
            foreach (Product product in products)
            {
                ProductItem item = new ProductItem();
                item.Product = product;
                pnlProductContainer.Controls.Add(item);
            }
        }
        public void loadDataProduct(string category)
        {
            pnlProductContainer.Controls.Clear();
            foreach (Product product in products)
            {
                if(product.Category == category)
                {
                    ProductItem item = new ProductItem();
                    item.Product = product;
                    pnlProductContainer.Controls.Add(item);
                }               
            }
        }
        private void MenuForm_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Start();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width - clientForm.Width, 0);
        }
        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbCategory.SelectedIndex == 0) {
                loadAllDataProduct();
            }
            else
            {
                loadDataProduct(cbCategory.SelectedValue.ToString());
            }
        }
        private void loadCart()
        {
            pnlCart.Controls.Clear();
            pnlCart.BringToFront();
            foreach (Cart cart in listCart)
            {
                CartItem item = new CartItem();
                item.Cart = cart;
                pnlCart.Controls.Add(item);
                
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkClick == 1)
            {
                addControl();
                checkClick = -1;
            }
        }
        private void addControl()
        {
            Cart cart = listCart[listCart.Count - 1];
            CartItem cartItem = new CartItem();
            cartItem.Cart = cart;
            pnlCart.Controls.Add((cartItem));
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            this.Close();
            foreach (CartItem item in pnlCart.Controls)
            {
                foreach(Cart cart in listCart)
                {
                    if(cart.Product.ProductID == item.Cart.Product.ProductID)
                    {
                        cart.Quantity = item.getQuantity();
                    }
                }
            }
            DateTime time = DateTime.Now;
            clientManager.sendOrder(time, orderToString(listCart));
            BillForm billForm = new BillForm(clientManager, time);
            billForm.Show();
            
        }
        private string orderToString(List<Cart> carts)
        {
            string str = "";
            foreach(Cart cart in carts)
            {
                str += "|" + cart.Product.ProductID.ToString() + "|" + cart.Quantity.ToString();
            }
            return str;
        }

        private void pnlCart_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pnlCart_ControlAdded(object sender, ControlEventArgs e)
        {
        }
    }
}
