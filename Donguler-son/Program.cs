using System;

class MainClass
{
    public static void Main(string[] args)
    {

        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("For Döngüsü:"); //Değişkenlerimizi tanımladık.

        string product1 = "Kadın";
        string product2 = "Erkek";
        string product3 = "Çoçuk";
        string product4 = "İndirim";
        string product5 = "Koleksiyon";

        //Console.WriteLine (product1); // İlk önce tüm değişkenlerimizi tek tek ekrana yazdırdık.
        //Console.WriteLine (product2);
        //Console.WriteLine (product3);
        //Console.WriteLine (product4);
        //Console.WriteLine (product5);

        string[] products = new string[] { product1, product2, product3, product4, product5 }; // Değişkenlerimizi listeye atadık. 


        for (int i = 0; i < products.Length; i += 1) // For döngüsüyle değişkenlerimizi ekrana yazdırdık. Listemizin sıfırıncı elemanından liste uzunluğuna kadar olan elemanları indexi birer arttırarak yazdırdık.
        {
            Console.WriteLine(products[i]);

        }

        Console.WriteLine("--------------------------------------------------------");

        Console.WriteLine("Foreach Döngüsü:"); 

        //Foreach döngüsü, listenin elemanları kadar yazdırmamızı sağlar.Eleman sayısını bilmediğimiz durumlarda çok kullanışlı bir döngü."

        foreach (string product in products)
        {
            Console.WriteLine(product);
        }

        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("While Döngüsü:"); 

        //string brand1 = "Nike";
        //string brand2 = "Adidas";
        //string brand3 = "Puma";
        //string brand4 = "Reebok";
        //string brand5 = "Skecher";

        //string[] brands = new string[] { brand1, brand2, brand3, brand4, brand5 };

        int k = 0;
        while (k < products.Length) //While döngüsü de for, foreach işlevi görür. k değişkenimize sıfırı atadık ve listemizin uzunluğundan küçük olma koşulu sağlandığı durumda, içerisinde yer alan kod çalışsın.
        {
            Console.WriteLine(products[k]);
            k++;

        }
        Console.WriteLine("--------------------------------------------------------"); //Güzel gözüksün istedim :)
        Console.WriteLine("The End!");


    }
}