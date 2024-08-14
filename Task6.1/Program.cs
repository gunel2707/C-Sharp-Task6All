namespace Task6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Istifadeciden 1 eded alin ve bir array yaradin. Hemin ededin arrayin icinde olub olmadigini yoxlayin
            Random r = new Random();
            int[] array = new int[8];
            int t = 0;
            Console.WriteLine("Ededi daxil edin:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Massiv asagidaki kimidir:");
            for (int i = 0; i < array.Length; i++) {
                array[i] = r.Next(1, 100);
                Console.WriteLine(array[i]);
            }
             if(t>0)  { Console.WriteLine(n + "ededi massivde"+t+"defe var"); }
                else { Console.WriteLine(n + "ededi massive daxil deyil"); }
            


        }
    }
}
