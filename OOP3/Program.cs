using System;
using System.Collections.Generic;

namespace OOP3
{

    //NOT: Interface leri genellikle operasyonel metotlarda kullanırız.
    //Interfaceler de onu implemente eden classın referens numarasını tutabilir!!
    //Interfaces can also keep the reference number of the class that implemented it !!
    //Interfaceleri birbirinin alternatifi olan fakat farklı işlemler yaptıracağımız kodlar için kullanırız.
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager needCreditManager = new NeedCreditManager();
           

            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            

            ICreditManager housingCreditManager = new HousingCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Application(housingCreditManager, databaseLoggerService);
            applicationManager.Application(needCreditManager,fileLoggerService);//Başvuru metoduna ihtiyaç kredisini gönderir ve oradaki hesapla butonunda çalışmasını sağlar


            List<ICreditManager> credits = new List<ICreditManager>() {needCreditManager ,vehicleCreditManager};


            //applicationManager.CreditPreInformation(credits);
            Console.Read();
        }
    }
}
