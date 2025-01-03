using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class Product
    {
        public int id;
        public string name;
        public string category;
        public double price;
        public int iventory;
        public Image img;
        public int ProductID
        {
            get { return id; }
            set { id = value; }
        }
        public string ProductName
        {
            get { return name; }
            set { name = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public Image Image
        {
            get { return img; }
            set { img = value; }
        }
        public int InventoryNumber
        {
            get { return iventory; }
            set { iventory = value; }
        }
    }
}
