using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    //MANAGER,DATAACCES,SERVİCE,DALL,CONTOLLER GİBİ CLASS İSİMLENDİRMELERİ GENELLİKLE OPERASYON TUTARLAR
    //YANİ METOTLAR VARDIR
    class SepetManager
    {
        public void Add(Product product)//ekle
        {
            Console.WriteLine("Sepete eklendi : " + product.Adi);
        }
        public void Add2(string urunAdi, string aciklama, double fiyat)//Sağlıklı bir kullanım değil Program.cs de açıklandı
        {
            Console.WriteLine("Tebrikler.Sepete eklendi : " + urunAdi);
        }
    }
}
