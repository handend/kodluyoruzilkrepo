using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atama ve İşlemli Atama
            int x= 3;
            int y= 3;
            
            y = y+2; 
            Console.WriteLine(y);
            y +=2;     //aynı işlemi görür.
            Console.WriteLine(y);

            
            y/=1 ;
            Console.WriteLine(y);
            x *=2;
            Console.WriteLine(x);

            //mantıksal operatorler

            // veya ||,  ve &&  , değil !

            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
                Console.WriteLine("perfect!"); // isSuccess ve isCompleted doğru ise perfect! yazdır.

            if(isSuccess || isCompleted)
                Console.WriteLine("great!"); // isSuccess veya isCompleted doğru ise great! yazdır.
            
            if(isSuccess && !isCompleted)
                Console.WriteLine("awesome!"); // isSuccess'se ve isCompleted değil ise awesome! yazdır.
            
            // İlişkisel Operatörler
            // < küçüktür, > büyüktür,  <= küçük eşittir,  >= büyük eşittir, == eşit eşittir , != eşit değildir
            
            Console.WriteLine("*********İlişkisel Operatorler***********************");
            
            int a= 3;
            int b=4;
            bool sonuc= a<b;

            Console.WriteLine(sonuc);
            
            sonuc = a>b;
            Console.WriteLine(sonuc);
            sonuc= a>=b;
            Console.WriteLine(sonuc);
            sonuc= a<=b;
            Console.WriteLine(sonuc);
            sonuc= a==b;
            Console.WriteLine(sonuc);
            sonuc= a!=b;
            Console.WriteLine(sonuc);
            
            Console.WriteLine("*********Aritmetik Operatorler***********************");

            // bölü / , çarpı * , artı +, eksi -

            int sayi1= 10;
            int sayi2= 5;

            int sonuc1 = sayi1/sayi2 ;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1*sayi2;
            Console.WriteLine(sonuc1);
            sonuc1= sayi1+sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 =sayi1++;
            Console.WriteLine(sonuc1);

            // % mod alır

            int sonuc2 = 20%3 ;
            Console.WriteLine(sonuc2);





        
        }
    }
}