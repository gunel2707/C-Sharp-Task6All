namespace Task6._7
{
    internal class Program
    {
        static void Main(string[] args)
        { int x ;
            int y;
            int mySum1 = Sum(8, 9);
            double mySum2 = Sum(43.45, 456.2);
            string myStr = Sum("Hello ", "World");
            float mySum3 = Sum(3.21F,45.53F,78.089F);
            Console.WriteLine("int:   "+mySum1);
            Console.WriteLine("double:  "+ mySum2);
            Console.WriteLine("string:  " + myStr);
            Console.WriteLine("float:   " + mySum3);
        }
       public static int Sum(int a, int b){
         return a + b;
          
        }

        public static double Sum(double a, double b) {
            return a + b;
        }


        public static string Sum(string a, string b)
        {
            return a + b;
        }

        public static float Sum(float a, float b,float c)
        {
            return a + b+c;

        }


    }






}
