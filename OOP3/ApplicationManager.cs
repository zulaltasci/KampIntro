using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager//Başvuru
    {
        //Method injection
        public void Application(ICreditManager creditManager, ILoggerService loggerService)
        {
            creditManager.Calculate();//İnterfacein implemente ettiği sınıflardan hangi parametre gönderilirse onu çalıştırır
            loggerService.Log();
        }
        public void CreditPreInformation(List<ICreditManager> credits)//kredi önbilgilendirmesi için (ICreditManager veri türünde bir liste oluştur.)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
