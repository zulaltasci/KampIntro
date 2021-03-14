using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface ICreditManager//Sınıf iken interface yaptım bunun nedeni türemiş sınıflardaki her hesapla metodunun içeriğinin farklı olmasıdır.!!!
    {
        void Calculate();//hesapla

        void Test();
        
    }
}
