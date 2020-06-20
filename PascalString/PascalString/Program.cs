using System;

namespace PascalString
{
    public static class stringExtension
    {
        public static string ConvertPascal(this string str)
        {
            //return str + "abc";
            string[] tokens = str.Split();
            string newStr = "";
            foreach(string token in tokens)
            {
                newStr += char.ToUpper(token[0]);
                newStr += token.Substring(1);
            }
            return newStr;
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string str = "hello world welcome";
            Console.WriteLine(str.ConvertPascal());
            
        }
    }
}
