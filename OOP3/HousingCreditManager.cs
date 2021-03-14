using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //housing: konut
    class HousingCreditManager : ICreditManager
    {
        public void Calculate()//hesapla
        {
            Console.WriteLine("Konut Kredisi Ödeme Planı Hesaplandı.");
        }

        public void Test()
        {
            throw new NotImplementedException();
        }
    }
}
