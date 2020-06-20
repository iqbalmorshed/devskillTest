using System;

namespace BigMath
{
    static class BigMath
    {
        public static T1 sum<T1,T2>(T1 val1, T2 val2)
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //BigMath bm = new BigMath();
            Console.WriteLine(BigMath.sum<int, double>(3, 4.5));
        }
    }
}
