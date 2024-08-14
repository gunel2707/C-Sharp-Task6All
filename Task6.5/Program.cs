namespace Task6._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task5   Verilmiş ədədin faktorialını hesablayın
            int s = 1;
            Console.WriteLine(" Ededi daxil edin");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) {
                s = s * i; }
            Console.WriteLine(n+"!="+s);
        }
       
    }
}
