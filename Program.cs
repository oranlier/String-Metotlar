using System;

namespace String_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz Csharp, hosgeldiniz!";
            string degisken2 = "Dersimiz Csharp";
            Console.WriteLine(degisken.Length);
            Console.WriteLine(degisken.ToLower());
            Console.WriteLine(degisken.ToUpper());

            //Concat
            Console.WriteLine(string.Concat(degisken,"Merhaba!"));

            //CompareTo
            //1. degisken 2. degiskene eşit olursa asagıdaki esitlik sıfır dondurur.
            //1. degisken 2. degiskenden daha buyuk birt karakter sayısına sahipse 1 dondurur.
            //1. degisken 2. degiskenden daha küçük birt karakter sayısına sahipse -1 dondurur.
            Console.WriteLine(degisken.CompareTo(degisken2));

            //compare
            //aşağıdaki "true" karşılastırmayı buyuk kucuk harf duyarsız hale getirir. false olunca buyuk kucuk harf duyarlıdır.
            Console.WriteLine(string.Compare(degisken,degisken2,true));

            //Contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken2.EndsWith("hosgeldiniz!"));
            Console.WriteLine(degisken2.StartsWith("Merhaba"));

            //Indexof
            Console.WriteLine(degisken2.IndexOf("CS"));//CS yi buldugu yerin ilk indexi verir, bulamazsa -1 doner
            Console.WriteLine(degisken2.LastIndexOf("i"));
            //insert
            Console.WriteLine(degisken.Insert(0, "Merhaba!"));
            //Padleft, PadRight
            //degıskenın sagına ya da soluna, degıskenın uzunlugunu verılen sayıya tamamlayacak kadar bosluk ekler
            //karakter verirse bosluk yerıne karakter de eklenebilir
            Console.WriteLine(degisken+degisken2.PadLeft(30));
            Console.WriteLine(degisken+degisken2.PadLeft(30,'*'));

            //Remove
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));
            Console.WriteLine(degisken.Remove(0,1));

            //Replace
            Console.WriteLine(degisken.Replace("CSharp","c#"));
            Console.WriteLine(degisken.Replace(" ","*"));

            //Split
            //asagıda verilen karaktere gore parcalayıp diziye atar ve dizinin 1 nolu elemanını verır
            Console.WriteLine(degisken.Split(' ')[1]);

            //Substring
            Console.WriteLine(degisken.Substring(4));// 4. indexten baslyarak cumlenın sonuna kadar getırır
            Console.WriteLine(degisken.Substring(4,6));// 4. indexten 6. indexe kadar getirir
        }
    }
}
