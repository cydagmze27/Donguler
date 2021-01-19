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
            Console.WriteLine(sayi1); //30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);//999

            //sayısal veri tipleri int decimal float double bool = değer tip
            //array class interface = referans tip
            //bellekte stack e heap diye iki alan var sen değişken tanımladığında değer tip olanlar stack de 
            //sayi1=10 sayi=30 sayi1=30 oldu. Değeri kopyalar direkt.
            //int array de referans tip olduğundan bir tanımlama yaptığında stack de sayılar=1 diye değişken tanımladın. 
            //new yazdığında heap de [10,20,30] sayilar=1 in direkt karşılığı oluyor.new demek yeni bir yer oluştur demek. (bellekten)
            //sayilar1 in referans numarası sayilar2 nin referasn numarasına eşittir diye okuyorsun
            //değer tiplerde değeri atıyorsun. referans tiplerde adresi atıyorsun.
            //101(diyelim adres numarası)[10,20,30]
            //102[100,200,300] 
            //sayilar1 = sayilar2; 101 iken 102 oluyor.
            //sayilar2[0] = 999; 102 nin 0.elemanı 999 oluyır o yüzden 101, 102 olduğu için değer 999 oluyor. :D



        }
    }
}
