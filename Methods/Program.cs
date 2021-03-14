using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya Elması";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 30;
            product2.Aciklama = "Diyarbakır Karpuzu";

            Product[] products = new Product[] { product1, product2 };
            //Type safe --Tip güvenli --C# ürün tipini bilmek ister
            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("----------------------");

            }

            Console.WriteLine("------------Metotlar----------");
            SepetManager sepetManager = new SepetManager();
            //Add metodunda yapılan işlem ENCAPSULATİON'dur.(sarmalama)
            sepetManager.Add(product1);
            sepetManager.Add(product2);


            sepetManager.Add2("çilek", "muz", 44);
            sepetManager.Add2("karpuz", "elma", 12);
            sepetManager.Add2("armut", "kivi", 32);
            //bu sağlıklı bir kullanım değil nedeni de bu özelliklere bir özellik mesela stok adedi de eklemek istesek
            //Add2 olan tüm metotların içine stok adedi bilgisi de girmem gerekir ve bu da beni tek tek uğraştırır.

            Console.ReadLine();
        }
    }
}
