namespace Task6._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //    Task3 While ilə dövr yaradın.
        //        Hər dövrdə istifadəçidən 2 ədəd istəyin.
        //        Əgər bu 2 ədədin cəmi 6 - ya qalıqsız bölünürsə
        //        bu zaman dövrü sonlandırın.Əks halda dövrü təkrarlayın.
            while (true)
            {
                Console.WriteLine("Birinci ededi daxil edin:");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Ikinci ededi daxil edin:");
                int m = int.Parse(Console.ReadLine());
                if ((m + n) % 6 == 0) 
                { 
                  break; 
                }
            }
        }
    }
}
