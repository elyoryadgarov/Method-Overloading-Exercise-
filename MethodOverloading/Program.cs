namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public static string Add(int a, int b, bool val)
        {
            string dol = " dollars";
            if (val == true)
            {
                if (a + b == 1)
                {
                    dol = " dollar";
                }
                return a+b+dol;
            }
            return "False";
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Add(5, 4, true));
            Console.WriteLine(Add(3, 8));
            Console.WriteLine(Add(6.23m, 8.36m));
            Console.WriteLine(Add(1,0,true));
            Console.WriteLine(Add(1,0,false));
            Console.WriteLine(Add(1,3,true));
            Console.WriteLine(Add(2.45m, 125.75m));
        }
    }
}
