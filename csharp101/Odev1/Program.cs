using System;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            int deger= 2;
            
            Console.WriteLine(deger);
            
            byte b=5; // 1 byte yer kaplar 0-255 arası değer alır.
            sbyte c = 5; //1 byte yer kaplar -228-128 arası değer alır.
            short d = 5; // 2 byte yer kaplar  -32726-32726 arası değer alır.
            ushort e = 5; // 2 byte yer kaplar.  0 ile 65365 arası değer alır.
            
            Int16 i16 = 2; //2 byte yer kaplar 
            int i = 2; // 4 byte yer kaplar -2 milyar 147 milyon 483 bin 648 den artı karşılığına kadar yer alır.
            Int32 i32 = 2; //4 byte yer kaplar
            Int64 i64 = 2; // 8 byte yer kaplar

            uint ui = 2; // 4 byte yer kaplar
            long l = 4; // 8 byte yer kaplar, biraz daha büyük tam sayılarda kullanılır.
            ulong ul = 4; // 8 byte negatif değer alamayan long

            float f = 5; //4 byte yer kaplar -reel sayılar içindir
            double db =5 ; //8 byte yer kaplar
            decimal de = 5; // 16 byte kaplar

            char ch = '2' ; // 2 byte yer kaplar tek karakter
            string str = "Hande" ; // sınırsız

            bool b1 = true ;  // true false tutar
            bool b2 = false ; 

            DateTime dt = DateTime.Now; // çalıştırdığı anın tarih ve saatini verir
            Console.WriteLine(dt) ;

            object o1 = "x" ; //string değer tuttu.
            object o2 = 'y' ; // char değer tuttu.
            object o3 =  4; // integer tuttu.
            object o4 = 4.3 ; // reel sayı tuttu.
            //her türlü veri object e atanabilir.

            // String ifadeler

            string str1 = string.Empty ;
            str1 = "Handenur Dogan" ;
            string ad = "Handenur";
            string soyad = "Dogan" ;
            string tamIsim = ad + " " + soyad ;

            // integer tanımlama şekilleri

            int integer1 = 5; 
            int integer2 = 3;
            int integer3 = integer1 * integer2;

            //boolean

            bool bool1 = 10 < 2 ; // false atama yapar.

            // Değişken dönüşümleri

            string str20 = "20";
            int int20 = 20 ;

            string yeniDeger = str20 + int20.ToString(); // int değişkenini stringe dönüştürdü.
            Console.WriteLine(yeniDeger); // Çıktısı 2020

            int int21 = int20 + Convert.ToInt32(str20); // integer dönüşümü
            Console.WriteLine(int21) ; // Çıktısı 40

            int int22= int20 + int.Parse(str20) ; // çıktısı 40  Parse stringten dönüşümde kullanılır.

            // datetime

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime); 

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2); 

           // saat
            string hour = DateTime.Now.ToString("HH.mm");
            Console.WriteLine(hour); 
    
        }
    }
}