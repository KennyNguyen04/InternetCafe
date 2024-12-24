using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Server.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Server.DTO;

namespace Server.GUI
{
    public partial class ProductDetailForm : Form
    {
        private ProcessProduct pcProduct = new ProcessProduct();
        private MenuControl mnControll = new MenuControl();
        private Cloudinary cloudinary;

        private string Id;
        private string Name;
        private string Type;
        private string Price;
        private string Number;
        private string Url;
        private string uploadedUrl;
        public ProductDetailForm(string id, string name, string type, string price, string number, string url)
        {
            InitializeComponent();
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.Price = price;
            this.Number = number;
            this.Url = url;

            Account account = new Account(
                "dyfbgpyet",
                "944657157576957",
                "1ko-FqNjGYibGa0M43_YYJEswOI"
            );
            cloudinary = new Cloudinary(account);
        }
        private void UploadFileToCloudinary(string filePath)
        {
            try
            {
                // Tạo đối tượng upload
                var uploadParams = new ImageUploadParams()
                {
                    File = new FileDescription(filePath)
                };

                // Thực hiện upload
                var uploadResult = cloudinary.Upload(uploadParams);

                // Kiểm tra kết quả và hiển thị URL của file đã upload
                if (uploadResult.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    uploadedUrl = uploadResult.Url.ToString();
                    //MessageBox.Show("Upload thành công! URL: " + uploadedUrl);
                }
                else
                {
                    MessageBox.Show("Upload thất bại.");
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void ProductDetailForm_Load(object sender, EventArgs e)
        {
            cbxType.DataSource = pcProduct.getAllCategory();
            cbxType.DisplayMember = "CategoryName";
            cbxType.DropDownStyle = ComboBoxStyle.DropDown;
            btnSave.Enabled = false;
            btnPickImage.Enabled = false;

            txtName.Text = this.Name;
            txtPriceSP.Text = this.Price;
            txtNumber.Text = this.Number;
            cbxType.Text = this.Type;
            txtImageUrl.Text = this.Url;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtName.Enabled = true;
            txtPriceSP.Enabled = true;
            txtNumber.Enabled = true;
            cbxType.Enabled = true;
            btnSave.Enabled = true;
            btnPickImage.Enabled = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            pcProduct.DeleteProduct(this.Id);
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Product product = new Product();
            product.ProductName = txtName.Text;
            product.Price = double.Parse(txtPriceSP.Text);
            product.Category = cbxType.Text;
            product.InventoryNumber = int.Parse(txtNumber.Text);
            product.ProductID = int.Parse(this.Id);
            pcProduct.UpdateProduct(product);
            this.Close();
        }

        private void btnPickImage_Click(object sender, EventArgs e)
        {
            // Mở hộp thoại OpenFileDialog để chọn file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn của file đã chọn
                string filePath = openFileDialog.FileName;


                // Gọi hàm để upload file lên Cloudinary
                UploadFileToCloudinary(filePath);
                txtImageUrl.Text = uploadedUrl;
            }
        }
    }
}
