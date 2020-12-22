using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LinqTemelleri1
{
    //delegate bool KontrolHandler(int a);

    
    class Program
    {
        public static bool Kontrol(int a)
        {
            if (a > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Selamla(string name)
        {
            Console.WriteLine("Merhaba {0}", name);
        }

        //static IEnumerable<int> Test(IEnumerable<int> sayilar)
        //{
        //    List<int> sonuc = new List<int>();

        //    foreach(var item in sayilar)
        //    {
        //        if(item > 5)
        //        {
        //            sonuc.Add(item);
        //        }
        //    }
        //    return sonuc;
        //}
        static void Main(string[] args)
        {
            //KontrolHandler kontrolHandler = new KontrolHandler(Kontrol)
            //Console.WriteLine(kontrolHandler.Invoke(8));

            //Kisa yoldan void method olmayan handler
            Func<int, bool> kontrolHandler = new Func<int, bool>(Kontrol);
            //Kisa yoldan void method olan handler 
            Action<string> selamlaHandler = new Action<string>(Selamla);

            int[] sayilar = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<int> testSayilar = (List<int>)Test(sayilar);
            //foreach (var item in testSayilar)
            //{
            //    Console.WriteLine(item);
            //}

            //var testSayilar = sayilar.ExtensionTestMethod(s => s > 5);
            //foreach (var item in testSayilar)
            //{
            //    Console.WriteLine(item);
            //}

            var testSayilar = sayilar.Where(s => s > 5);
            foreach (var item in testSayilar)
            {
                Console.WriteLine(item);
            }

            var doesExist = sayilar.Any(s => s == 6);
            if(doesExist)
            {
                Console.WriteLine("Aranan sayi kaynakta mevcut");
            }
            else
            {
                Console.WriteLine("Aranan sayi kaynakta mevcut degil");
            }

            //Contains int bir parametre alir ve bool bir deger dondurur.
            sayilar.Contains(7);

            var num = sayilar.Where(s => s > 21).FirstOrDefault();
            Console.WriteLine("Donen sayi {0}", num);

            var num2 = sayilar.Where(s => s > 6).FirstOrDefault();
            Console.WriteLine("Bir sonraki sayi {0}", num2);
        }
    }
}

public static class ExtensionMethods
{
    public static IEnumerable<int> ExtensionTestMethod(this IEnumerable<int> kaynak, Func<int,bool> filter)
    {
        foreach (var item in kaynak)
        {
            //if(item > 5)
            //{
            //    //yield kullanarak 5'ten buyuk sayilari tekrardan bir degiskene atamamiza gerek kalmiyor. Yield arka planda bir liste olusturuyor ve 5'ten buyuk sayilari bu listeye atiyor.
            //    yield return item;
            //}
            if (filter(item))
            {
                yield return item;
            }
        }
    }
}