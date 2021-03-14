using System;

namespace OOP2
{
    class Program //INHERİTANCE:KALITIM
        //Çıkarılan not: Base sınıf referans tutucudur ,türemiş sınıflarının referansını tutar
    {
        static void Main(string[] args)
        {
            IndividualCustomer individualCustomer = new IndividualCustomer();
            individualCustomer.FirstName = "ZÜLAL";
            individualCustomer.LastName = "Taşçı";
            individualCustomer.TcNum = "1234567";
            individualCustomer.Id = 1;
            individualCustomer.CustomerNum = "2345";

            CoorporateCustomer coorporateCustomer = new CoorporateCustomer();
            coorporateCustomer.CompanyName = "Mokteyshop";
            coorporateCustomer.TaxNum = "1234";
            coorporateCustomer.Id = 2;
            coorporateCustomer.CustomerNum = "4567";


            Customer customer1 = new IndividualCustomer();
            Customer customer2 = new CoorporateCustomer();
            //Customer classı heö gerçek hemde tüzel müşterinin referans numarasını tutabiliyor.

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);// Base class olan Customer individualin parentıdır
            customerManager.Add(customer2);//Base class olan Customer coorporatenin parentedır
            customerManager.Add(individualCustomer);
            customerManager.Add(coorporateCustomer);
        }
    }
}
