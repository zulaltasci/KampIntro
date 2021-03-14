using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Tüzel Müşteri
    class CoorporateCustomer:Customer//İnheritance

    {
        public string CompanyName { get; set; }//Şirket adı
        public string TaxNum { get; set; }//Vergi no
       
    }
}
