using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Vehicle:taşıt
    class VehicleCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Taşıt Kredisi Ödeme Planı Hesaplandı.");
        }

        public void Test()
        {
            throw new NotImplementedException();
        }
    }
}
