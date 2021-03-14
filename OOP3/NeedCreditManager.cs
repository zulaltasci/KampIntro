using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //need:ihtiyaç
    class NeedCreditManager : ICreditManager
    {
        public void Calculate()//hesapla
        {
            Console.WriteLine("İhtiyaç Kredisi Ödeme Planı Hesaplandı.");
        }

        public void Test()
        {
            throw new NotImplementedException();
        }
    }
}
