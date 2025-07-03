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
            Console.WriteLine("Hello, World!");
            Console.WriteLine(Add(1,0,true));
            Console.WriteLine(Add(1,0,false));
            Console.WriteLine(Add(1,3,true));
        }
    }
}
