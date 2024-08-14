using System;
using System.ComponentModel.DataAnnotations;

namespace Task6_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task1: 1 - dən 1000 - ə qədər olan ədədlərin içində 3 - ə və 5 - ə bölünən ədədləri konsola yazdırın.
            //for (int i = 1; i < 1000; i++) {
            //    if (i % 3 == 0 & i % 5 == 0) {
            //        Console.WriteLine(i);
            //    }
            //}



            //Task2: İstifadəçidən bir ədəd daxil etməsini istəyin və o ədəd qədər ekrana random ədədlər çap edin.
            //var rand = new Random();
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{

            //    Console.WriteLine(rand.Next(i));
            //}
            //Console.ReadKey();

            //Task3:Istifadəçidən 10 ilə 20 arasında bir rəqəm alın . Bir array yaradın və daxil edilən rəqəm sayı qədər arraya
            //            random rəqəm daxil edin.Daha sonra həmin arrayin içərisindən tək ədədləri ayrı, cüt ədələri ayrı şəkildə,
            //ardıcıllıqla konsola yazdırın.

            // Random rand = new Random();
            //int[] array = new int[n];
            //for (int n = 10; n < 20; n++)
            //{
            //    n = int.Parse(Console.ReadLine());
            //    // console.writeline(rand.next(n));
            //}


            //    for (int i = 0; i < n; i++)
            //    {
            //        array[i] = rand.Next(i);
            //        if (array[i] % 2 == 0)
            //        {
            //            Console.WriteLine("Cut eded:" + array[i]);
            //            Console.WriteLine(i);
            //        }
            //        else { Console.WriteLine("Tek eded:" + array[i]); }
            //    };

            //Console.ReadKey();



            //  int[] array = new int[1000];
            //for (int i = 10; i < 20; i++)
            //      {
            //          array[i] = rand.Next(10,20);
            //          if (array[i] % 2 == 0)
            //          {
            //              Console.WriteLine("Cut eded:" + array[i]);
            //              Console.WriteLine(i);
            //          }
            //          else { Console.WriteLine("Tek eded:" + array[i]); }
            //      };

            //  Console.ReadKey();


            //Random r = new Random();
            //int n = r.Next(10, 20);
            //Console.WriteLine("Arrayin olcusu:" + n);
            //int[] array = new int[n];
            //for (int i = 0; i < n; i++) { 
            //    array[i] = r.Next(1,100);
            //    if (array[i] % 2 == 0)
            //    {

            //        Console.WriteLine(i+")Cut eded:" + array[i]);

            //         }
            //         else
            //    {

            //        Console.WriteLine(i+")Tek eded:" + array[i]); }
            //}

            //Console.ReadKey();


            //Task4:3 rəqəmli ədədin rəqəmləri cəmini tapın

            //Console.WriteLine("Ededi daxil edin:");
            //int n = int.Parse(Console.ReadLine());
            //int s = 0;
            //while (n > 0) {
            //    int m = n % 10; s += m;
            //    n = n / 10;
            //}
            //Console.WriteLine("Reqemlerinin cemi:"+s);
            //Console.ReadKey();


            // Task5:  Verilmiş 3 ədəddən ən böyük və ən kiçiyini tapın
            // Random r = new Random();
            // int[] array = new int[3];


            //for (int i = 0; i < 3; i++) { 
            //     array[i] = r.Next(1, 1000);
            //     Console.WriteLine(array[i]); }
            // int max = array[0];
            // int min = array[0];
            // for (int i = 0; i < 3; i++)
            // {

            //     if (array[i] > max)
            //     {
            //         max = array[i];

            //     }
            //     if (array[i] < min)

            //     {
            //         min = array[i];

            //     }

            // }
            // Console.WriteLine("maximum:" + max);
            // Console.WriteLine("minimum:" + min);

            // Console.ReadKey();


            //int[] array = { 3, 1, 4, 1, 5, 9, 2, 6 };
            //if (array.Length == 0)
            //{
            //    Console.WriteLine("Array is empty.");
            //    return;
            //}

            //int max = array[0];
            //int min = array[0];

            //for (int i = 1; i < array.Length; i++)
            //{
            //    if (array[i] > max)
            //    {
            //        max = array[i];
            //    }
            //    if (array[i] < min)
            //    {
            //        min = array[i];
            //    }
            //}

            //Console.WriteLine("Maximum: " + max);
            //Console.WriteLine("Minimum: " + min);





            // Task8: 3 rəqəmli ədədlərdən 7 və 8 - ə bölünən ədədlərin cəmini tapın
            //int s = 0;
            //for (int i = 100; i < 999; i++) {
            //    if (i % 7 == 0 & i % 8 == 0) { Console.WriteLine(i); s += i; }

            //}
            //Console.WriteLine("result:" + s);
            //Console.ReadKey();


        }
    }
}
