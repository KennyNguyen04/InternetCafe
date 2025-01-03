using Server.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Server.DTO;

namespace Server.GUI
{
    public partial class AddProductForm : Form
    {
        private ProcessProduct pcProduct = new ProcessProduct();
        private Boolean allowClose = false;
        private Cloudinary cloudinary;
        private string uploadedUrl;
        public AddProductForm()
        {
            InitializeComponent();
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



        private void AddProductForm_Load(object sender, EventArgs e)
        {
            cbxType.DataSource = pcProduct.getAllCategory();
            cbxType.DisplayMember = "CategoryName";
            cbxType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void AddProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (allowClose)
            {
                allowClose = false;
                e.Cancel = false;
            }
            else
            {
                if (MessageBox.Show("Bạn có có chắn chắn muốn thoát mà không lưu sản phẩm này?", "Thông báo!!",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No
                   )
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ProductName = txtName.Text;
            product.Price = double.Parse(txtPriceSP.Text);
            product.InventoryNumber = int.Parse(txtNumber.Text);
            product.Category = cbxType.Text;
            product.ImageUrl = txtFilePath.Text;

            if (pcProduct.checkSave(product))
            {
                pcProduct.AddProduct(product);
                allowClose = true;
                this.Close();
            }
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
                txtFilePath.Text = uploadedUrl;
            }
        }
    }
}
