using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        /*Kahve dükkanları için müşteri yönetimi yapan bir proje.
        //Starbucks ve Nero firmaları ile çalışıyorum , iki firma da müşterilerini veritabanına kaydetmek istiyor
        //Sturbucks müşterileri kaydederken mutlaka mernis doğrulaması istiyor,Nero için böyle bir şart yok
        Sturbucks her kahve alımında müşterilere yıldız kazandırmak istiyor.*/
       
        /* A project that does customer management for coffee shops.
        // I work with Starbucks and Nero companies, both companies want to save their customers in the database
        // Sturbucks always requires mernis verification when registering customers, no such requirement for Nero
        Sturbucks wants to earn stars for customers with every coffee purchase.*/
        static void Main(string[] args)
        {
            //BaseCustomerManager customerManager = new NeroCustomerManager();
            BaseCustomerManager customerManager1 = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager1.Save(new Customer { DateOfBirth = new DateTime(2000, 6, 14),FirsName=" Zülal",LastName="Taşçı",NationalId="234" });

            Console.Read();
        }
    }
}
