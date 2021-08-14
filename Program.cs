using System;
using System.Diagnostics;
namespace reverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch w1= new Stopwatch();
            w1.Start();
            Console.WriteLine(ReverseString("Hello World!Hello World!Hello World!Hello World!Hello World!Hello World!Hello World!Hello World!Hello World!Hello World!Hello World!"));
            w1.Stop();

            Stopwatch w2= new Stopwatch();
            w2.Start();
            Console.WriteLine(ReverseStringFast("Hello World!Hello World!Hello World!Hello World!Hello World!Hello World!Hello World!Hello World!Hello World!Hello World!Hello World!"));
            w2.Stop();

            Console.WriteLine($"Slow algo took {w1.ElapsedTicks} ticks");
            Console.WriteLine($"Fast algo took {w2.ElapsedTicks} ticks");

            Console.WriteLine(w1.ElapsedTicks/w2.ElapsedTicks);

        }

        static string ReverseString(string str)
        {
            var chars = str.ToCharArray();
            var len = str.Length;
            string s = string.Empty;
            for(int j=len-1; j>=0; j--){
                s+=chars[j];
            }

            return s;
        }
        static string ReverseStringFast(string str)
        {
            var chars = str.ToCharArray();
            var len = str.Length/2;
            for(int i=0, j=str.Length-1; i<len;i++, j--){
                char t = chars[i];
                chars[i]=chars[j];
                chars[j]=t;
            }

            return new string(chars);
        }

    }
}
