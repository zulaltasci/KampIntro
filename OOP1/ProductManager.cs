using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //CRUD operasyonları: eklemek,güncellemek,silmek vs
    class ProductManager//Manager olan isimlendirmelerde genelde Crud operasyonları yapılı
    {
        public void Add(Product product)//Product klası türünde product değişkeni 
        {
            Console.WriteLine(product.ProductName + "eklendi");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi");
        }
        
    }
}
