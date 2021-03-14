using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>//T tüm tipleri ifade ediyor
    {
        T[] items;
        //constructur:kurucu metot,,ctor+tab+tab
        public MyList()
        {
            items = new T[0];//boş dizimin örneğini oluşturdum
        }
        public void Add(T item)
        {
            T[] tempArray = items;//geçici dizinin referansı itemsın referansını tutar
            items = new T[items.Length+1];//0 olan dizinin sayısını bir artırdım
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];//itemsın eleman eklemeden çnceki değerlerini tutan geçici arrayden itemsa tekrardan aktarım sağlıyorum
            }
            items[items.Length - 1] = item;//dizinin uzunluğu -1 son eleman olmuş olur
        }
            
    }
}
