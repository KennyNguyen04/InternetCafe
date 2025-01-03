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
            foreach (Cart cart in MenuForm.listCart)
            {
                CartItem item = new CartItem
                {
                    Cart = cart
                };
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

        private bool CheckBalance(double itemPrice)
        {
            if (clientManager.totalMoney < itemPrice)
            {
                MessageBox.Show("Số tiền trong tài khoản không đủ để thanh toán món ăn này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            this.Close();
            foreach (CartItem item in pnlCart.Controls)
            {
                foreach (Cart cart in listCart)
                {
                    if (cart.Product.ProductID == item.Cart.Product.ProductID)
                    {
                        cart.Quantity = item.getQuantity();
                    }
                }
            }

            // Tính tổng tiền của đơn hàng
            double totalOrderAmount = listCart.Sum(cart => cart.Product.Price * cart.Quantity);
            if (!CheckBalance(totalOrderAmount))
            {
                // Nếu không đủ tiền, hiển thị thông báo và thoát.
                return;
            }
            // Gửi đơn hàng
            DateTime time = DateTime.Now;
            clientManager.sendOrder(time, orderToString(listCart));

            // Cập nhật tổng tiền trong ClientForm
            clientForm.UpdateTotalMoney(totalOrderAmount);

            BillForm billForm = new BillForm(clientManager, time);
            billForm.Show();
        }


        public void UpdateCartTotal()
        {
            double totalAmount = 0;

            foreach (Cart cart in listCart)
            {
                totalAmount += cart.Product.Price * cart.Quantity;
            }

            // Cập nhật label hiển thị tổng tiền, giả sử bạn có label tên lblTotalAmount
            //lblTotalAmount.Text = totalAmount.ToString("C"); // Hiển thị định dạng tiền tệ
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

        private void pnlProductContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
