﻿namespace Task6._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Task6   Istifadəçidən bir ədəd alın. O ədəd qədər fibonnaci sırası yaradın. 
            
            Console.Write("Ededi daxil edin");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            arr[0] = 1; arr[1] = 1;
            for (int i = 2; i < arr.Length; i++) { arr[i ] = arr[i-1] + arr[i - 2];
               
            }
            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
    }
}
