using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1?? ->30
            //int,decimal,float,double,bool=değer tip
            //değer tipler stackte tutulur
            //sayi1=10 denildiğinde stackte sayı1 in değeri eşittir 10 olarak okunur
            //sayi1=sayi2 sayi1 in değeri eşittir sayi2 dinin değerine yani 30 a
            //sayi2=65 sayi2 nin değeri eşittir 65 olur


            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 100 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] ?? ->999
            //array,class,interface=referans tip
            //int[] sayilar1= stackta sayilar1 isimli bir değişken oluştur
            //new denildiği anda heap te dizinin değerleri için bellek tahsis edilier ve 
            //şunlar yazar->[10,20,30]
            /* Her bir heap bölgesinin bir adresi vardır örn 101 olsun ve sayilar1 referansı örn 101 di
             * belleğin o adresini işaret eder.
             * sayilar 2 nin ref numarası de 102 ,heapteki alanı [100,200,300] olsun
             * sayilar1=sayilar2 denildiği zaman=sayilar1 in referans numarası
             * sayilar2 nin referans numarasına eşittir diye okunur ve
             * sayilar1 nin referans numarası 102 olarak değişir ve artık 102 ref numarası [100,200,3000] dizisini gösteriyordur   
             * sayilar2[0]=999 ise sayilar1[0] ne olur sorusunun cevabı 99 dur çünkü
             * sayilar1 dizisi artık [999,200,300] olmuştur*/


        }
    }
}
