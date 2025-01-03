using Server.BLL;
using Server.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.GUI
{
    public partial class MenuControl : UserControl
    {
        private DataAccessLayer DAL = new DataAccessLayer();
        private ProcessProduct pcProduct = new ProcessProduct();
        public Boolean add = false;
        public Boolean update = false;
        private ProductDetailForm detailform;
        private int x;
        private int y;
        public MenuControl()
        {
            InitializeComponent();
            this.x = this.Location.X + this.Width + 534;
            this.y = this.Location.Y + this.Height - 198;
        }

        private void MenuControl_Load(object sender, EventArgs e)
        {

            lsvProduct.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            DataTable dt = pcProduct.getAllProduct();
            AddDataTableToListView(dt, lsvProduct);


            lsvProduct.SelectedIndexChanged += lsvProduct_SelectedIndexChanged;

        }


        private void AddProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataTable dt = pcProduct.getAllProduct();
            UpdateListView(dt, lsvProduct);
        }

        private void ProductDetailForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataTable dt = pcProduct.getAllProduct();
            UpdateListView(dt, lsvProduct);
        }

        private void lsvProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvProduct.SelectedItems.Count > 0) // Nếu có mục được chọn
            {
                ListViewItem selectedItem = lsvProduct.SelectedItems[0]; // Lấy mục được chọn
                string selecttedId = lsvProduct.SelectedItems[0].SubItems[0].Text;
                string selecttedName = lsvProduct.SelectedItems[0].SubItems[1].Text;
                string selecttedCategory = lsvProduct.SelectedItems[0].SubItems[2].Text;
                string selecttedPrice = lsvProduct.SelectedItems[0].SubItems[3].Text;
                string selecttedNumber = lsvProduct.SelectedItems[0].SubItems[4].Text;
                string selecttedImage = lsvProduct.SelectedItems[0].SubItems[5].Text;
                // Kiểm tra nếu form phụ chưa tồn tại hoặc đã đóng, tạo mới
                if (detailform == null || detailform.IsDisposed)
                {
                    detailform = new ProductDetailForm(selecttedId, selecttedName, selecttedCategory, selecttedPrice, selecttedNumber, selecttedImage); // Tạo Form phụ
                    detailform.StartPosition = FormStartPosition.Manual;
                    detailform.Location = new System.Drawing.Point(x, y);
                    detailform.FormClosed += new FormClosedEventHandler(ProductDetailForm_FormClosed);
                    detailform.Show();
                }
            }
            else
            {
                // Nếu không có mục nào được chọn, đóng Form phụ
                if (detailform != null && !detailform.IsDisposed)
                {
                    detailform.Close();
                }
            }
        }

        void AddDataTableToListView(DataTable dataTable, ListView listView)
        {
            // Đặt chế độ hiển thị cho ListView
            listView.View = View.Details;
            listView.Columns.Add("ID", 100);
            listView.Columns.Add("Tên Sản phẩm", 200);
            listView.Columns.Add("Loại Sản phẩm", 200);
            listView.Columns.Add("Giá", 100);
            listView.Columns.Add("Số lượng", 100);


            // Duyệt qua từng hàng của DataTable
            foreach (DataRow row in dataTable.Rows)
            {
                ListViewItem item = new ListViewItem(row["ProductId"].ToString());
                item.SubItems.Add(row["ProductName"].ToString());
                item.SubItems.Add(row["CategoryName"].ToString());
                item.SubItems.Add(row["Price"].ToString());
                item.SubItems.Add(row["InventoryNumber"].ToString());
                item.SubItems.Add(row["ImageUrl"].ToString());

                //LoadImagesToListView(row["ImageUrl"].ToString());

                listView.Items.Add(item);
            }
        }

        public void UpdateListView(DataTable newDataTable, ListView listView)
        {
            // Xóa toàn bộ các item cũ
            lsvProduct.Items.Clear();

            // Duyệt qua các hàng dữ liệu trong DataTable và thêm vào ListView
            foreach (DataRow row in newDataTable.Rows)
            {
                // Tạo một ListViewItem với dữ liệu mới
                ListViewItem item = new ListViewItem(row["ProductId"].ToString());
                item.SubItems.Add(row["ProductName"].ToString());
                item.SubItems.Add(row["CategoryName"].ToString());
                item.SubItems.Add(row["Price"].ToString());
                item.SubItems.Add(row["InventoryNumber"].ToString());
                item.SubItems.Add(row["ImageUrl"].ToString());

                // Thêm item vào ListView
                lsvProduct.Items.Add(item);
            }
        }

        public void LoadImagesToListView(string imageUrl)
        {
            // Khởi tạo ImageList
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(64, 64); // Kích thước ảnh cho ListView

            lsvProduct.LargeImageList = imageList;  // Gán ImageList cho ListView

            try
            {
                // Tải ảnh từ URL
                WebRequest request = WebRequest.Create(imageUrl);
                using (WebResponse response = request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                {
                    // Chuyển đổi stream thành Image
                    Image image = Image.FromStream(stream);

                    // Thêm ảnh vào ImageList
                    imageList.Images.Add(imageUrl, image);

                    // Tạo ListViewItem và gán khóa ảnh (imageUrl) cho nó
                    ListViewItem item = new ListViewItem();
                    item.ImageKey = imageUrl;

                    // Thêm item vào ListView
                    lsvProduct.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải ảnh: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.StartPosition = FormStartPosition.Manual;
            addProductForm.Location = new System.Drawing.Point(x, y);
            addProductForm.FormClosed += new FormClosedEventHandler(AddProductForm_FormClosed);
            addProductForm.ShowDialog();
            add = true;
        }
    }
}
