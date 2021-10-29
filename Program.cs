using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("*****Atama ve islemli atama*****");
            //Atama Ve işlemli Atama
            int x = 3;
            int y = 3;
            y = y + 2;
            System.Console.WriteLine(y); //ciktisi 5

            y += 2;
            System.Console.WriteLine(y); //ciktisi 7

            y /= 1;
            System.Console.WriteLine(y); //ciktisi 7

            x *= 2;
            System.Console.WriteLine(x); //ciktisi 6

            System.Console.WriteLine("*****Mantiksal operatorler*****");

            //Mantiksal Operatorler
            // ||, &&, !

            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
                System.Console.WriteLine("Perfect!");

            if(isSuccess || isCompleted)
                System.Console.WriteLine("Great!");

            if(isSuccess && !isCompleted)
                System.Console.WriteLine("Fine!");

            System.Console.WriteLine("*****Iliskisel operatorler*****");

            //iliskisel operatorler
            // <, >, <=, >=, ==, !=

            int a = 3;
            int b = 4;

            bool sonuc = a<b;
            System.Console.WriteLine(sonuc);

            sonuc = a>b;
            System.Console.WriteLine(sonuc);

            sonuc = a>=b;
            System.Console.WriteLine(sonuc);

            sonuc = a<=b;
            System.Console.WriteLine(sonuc);

            sonuc = a==b;
            System.Console.WriteLine(sonuc);

            sonuc = a!=b;
            System.Console.WriteLine(sonuc);

            System.Console.WriteLine("*****Aritmetik operatorler*****");
            // /, *, +, -

            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1/sayi2;
            System.Console.WriteLine(sonuc1);

            sonuc1 = sayi1*sayi2;
            System.Console.WriteLine(sonuc1);

            sonuc1 = sayi1+sayi2;
            System.Console.WriteLine(sonuc1);

            sonuc1 = sayi1++;
            System.Console.WriteLine(sonuc1);

            // % mod alir

            int sonuc2 = 20%3;
            System.Console.WriteLine(sonuc2);
            
            



        }
    }
}
