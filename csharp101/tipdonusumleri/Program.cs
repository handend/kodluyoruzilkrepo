using System;

namespace tipdonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion (Bilinçsiz dönüşüm) düşük kapasiteli bir değişkenin kendinden daha yüksek kappasiyeli bir dğeişkene atanması
            Console.WriteLine("****** Implicit Conversion ********");

        byte a = 5;
        sbyte b = 30;
        short c = 10;

        int d = a+b+c;
        Console.WriteLine("d:"+d);
        
        long h = d;
        Console.WriteLine("h:"+h);

        float i = h;
        Console.WriteLine("i:"+i);

        string e= "hande";
        char f= 'k';
        object g = e+f+d;
        Console.WriteLine("g:"+g);  //

            // Explicit Conversion (Bilinçli dönüşüm) kendi kendine yapamayacağı dönüşümler

            Console.WriteLine("****** Explicit Conversion ********");
            int x = 4;
            byte y = (byte)x; //sağdaki veri tipini dönüştürür.

            Console.WriteLine("y:"+y);

            int z= 100;
            byte t = (byte)z;
            Console.WriteLine("t:"+t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v:"+v);
            

        // ***** ToString Metodu ******

        Console.WriteLine("****** ToString Metodu ********");

        int xx= 6;
        string yy= xx.ToString();
        Console.WriteLine("yy:"+yy);

        string zz= 12.5f.ToString();
        Console.WriteLine("zz:"+zz);

        // System.Convert
        Console.WriteLine("****** System.Convert sınıfı ********");

        string s1="10", s2="20";
        int sayi1, sayi2;
        int Toplam; 

        sayi1 = Convert.ToInt32(s1);
        sayi2 = Convert.ToInt32(s2);

        Toplam = sayi1 + sayi2;
        Console.WriteLine("Toplam:"+ Toplam);

        //Parse 

        Console.WriteLine("****** Parse Metodu  *******");
        ParseMethod();
        

        }

        public static void ParseMethod()
        {
        string metin1 = "10";
        string metin2= "10.25";
        int rakam1;
        double double1; 

        //string bir değişken parse kullanılarak integer bir değişkene çevrildi. Parse string ifadeleri dönüştürmek için kullanılır v her zaman string alır. 

        rakam1= Int32.Parse(metin1);
        double1= Double.Parse(metin2);

        Console.WriteLine("rakam1:"+rakam1);
        Console.WriteLine("double1:"+double1);


        }

    }
}
