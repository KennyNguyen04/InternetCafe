using Server.DAL;
using Server.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.BLL
{
    public class ProcessProduct
    {
        private DataAccessLayer DAL = new DataAccessLayer();

        public List<DTO.Product> getAllProducts()
        {
            string query = "select * from Product where InventoryNumber > 0";
            DataTable dt = DAL.getDataTable(query);
            List<DTO.Product> productList = dt.AsEnumerable()
                .Select(row => new Product
                {
                    ProductID = row.Field<int>("ProductID"),
                    ProductName = row.Field<string>("ProductName"),
                    Category = row.Field<string>("CategoryName"),
                    Price = row.Field<double>("Price"),
                    InventoryNumber = row.Field<int>("InventoryNumber"),
                    ImageUrl = row.Field<string>("ImageUrl")
                }).ToList();
            return productList;
        }

        public List<string> getAllCategory()
        {
            string query = "select * from Category";
            DataTable dt = DAL.getDataTable(query);
            List<string> list = new List<string>();
            foreach (DataRow dataRow in dt.Rows)
            {
                string s = dataRow.Field<string>("CategoryName");
                list.Add(s);
            }

            return list;
        }

        public bool updateProductInventory(int productId, int quantity)
        {
            int m = getProduct(productId).InventoryNumber - quantity;
            string query = "update Product set InventoryNumber = '" + m.ToString() + "' where ProductID = '" +
                           productId.ToString() + "'";
            if (DAL.runQuery(query)) return true;
            return false;
        }

        public Product getProduct(int productID)
        {
            string query = "select * from Product where ProductID = '" + productID + "'";
            DataTable dt = DAL.getDataTable(query);
            DataRow row = dt.Rows[0];
            Product product = new Product
            {
                ProductID = row.Field<int>("ProductID"),
                ProductName = row.Field<string>("ProductName"),
                Category = row.Field<string>("CategoryName"),
                Price = row.Field<double>("Price"),
                InventoryNumber = row.Field<int>("InventoryNumber"),
                ImageUrl = row.Field<string>("ImageUrl")
            };
            return product;
        }

        public double getPrice(int productID)
        {
            string query = "select Price from Product where ProductID = '" + productID + "'";
            DataTable dt = DAL.getDataTable(query);
            DataRow dr = dt.Rows[0];
            return dr.Field<double>("Price");
        }

        public string getProductName(int productID)
        {
            string query = "select ProductName from Product where ProductID = '" + productID + "'";
            DataTable dt = DAL.getDataTable(query);
            DataRow dr = dt.Rows[0];
            return dr.Field<string>("ProductName");
        }

        public DataTable GetAllCategory()
        {
            string strquery = "SELECT * FROM Category";
            return DAL.getDataTable(strquery);
        }

        public DataTable getAllProduct()
        {
            string strquery = "SELECT * FROM Product";
            return DAL.getDataTable(strquery);
        }

        public DataTable getProductbyId(string Id)
        {
            string strquery = "SELECT * FROM Product WHERE ProductId='" + Id + "'";
            return DAL.getDataTable(strquery);
        }

        public void AddProduct(Product product)
        {
            string sqlquery = "INSERT INTO Product VALUES( N'" + product.ProductName + "', N'" + product.Category + "', '" + product.Price + "', '" + product.InventoryNumber + "', '" + product.ImageUrl + "')";
            if (DAL.runQuery(sqlquery))
            {
                MessageBox.Show("Thêm thành công!");
            }
        }


        public void DeleteProduct(string Id)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này không?", "Thông báo!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string strquery = "DELETE FROM Product WHERE ProductID='" + Id + "'";
                string strquery2 = "DELETE FROM Bill_Item WHERE ProductID='" + Id + "'";
                if (DAL.runQuery(strquery) && DAL.runQuery(strquery2))
                {
                    MessageBox.Show("Đã xóa thành công sản phẩm!!", "Thông báo!!");
                }
            }
        }

        public void UpdateProduct(Product product)
        {
            string strquery = "UPDATE Product SET ProductName=N'" + product.ProductName + "', CategoryName=N'" + product.Category + "', Price='" + product.Price + "', InventoryNumber='" + product.InventoryNumber + "' WHERE ProductID='" + product.ProductID + "'";
            if (DAL.runQuery(strquery))
            {
                MessageBox.Show("Cập nhật dữ liệu thành công!");
            }
        }

        public bool checkFieldData(string name)
        {
            if (DAL.checkField("Product", "ProductName", name)) return true;
            return false;
        }
        public bool checkSave(Product product)
        {

            if (checkFieldData(product.ProductName))
            {
                //Nếu đã tồn tại
                MessageBox.Show("Đã tồn tại Sản phẩm này!", "Thông báo");
                return false;
            }
            if (product.InventoryNumber.Equals(""))
            {
                MessageBox.Show("Số lượng sản phẩm không được để trống!", "Thông báo");
                return false;
            }
            if (product.ProductName.Equals(""))
            {
                MessageBox.Show("Tên sản phẩm không được để trống!", "Thông báo");
                return false;
            }
            if (product.Price.Equals(""))
            {
                MessageBox.Show("Giá sản phẩm không được để trống!", "Thông báo");
                return false;
            }
            if (product.Price < 0)
            {
                MessageBox.Show("Giá sản phẩm không được nhỏ hơn 0!", "Thông báo");
                return false;
            }

            return true;
        }
    }
}
