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

            int a= 3;
            int b=4;
            bool sonuc= a<b;

            Console.WriteLine(sonuc);
            
            

        
        }
    }
}