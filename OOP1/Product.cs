using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product//ürün
    {
        public int Id { get; set; }//ıd: tc kimlik no gibi
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }//ürünün fiyatı

        public int UnitsInStock { get; set; }//stok adedi

        



    }
}
