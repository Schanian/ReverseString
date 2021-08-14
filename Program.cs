using System;
using System.Diagnostics;
namespace reverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The number of iteraction each "+ 4294967.ToString());
            Stopwatch w1= new Stopwatch();
            w1.Start();
            for(uint c=0;c<4294967; c++){
                ReverseString("The quick brown fox jumps over the little lazy dog. poor dog was not saved."+ReverseString("The quick brown fox jumps over the little lazy dog. poor dog was not saved."));
            }
            w1.Stop();
            Console.WriteLine($"Slow algo took {w1.ElapsedTicks} ticks - {w1.Elapsed}");

            Stopwatch w2= new Stopwatch();
            w2.Start();

            for(uint c=0;c<4294967; c++){
                ReverseStringFast("The quick brown fox jumps over the little lazy dog. poor dog was not saved."+ReverseStringFast("The quick brown fox jumps over the little lazy dog. poor dog was not saved."));
            }
            w2.Stop();
            Console.WriteLine($"Fast algo took {w2.ElapsedTicks} ticks - {w2.Elapsed}");

            Stopwatch w3= new Stopwatch();
            w3.Start();
            for(uint c=0;c<4294967; c++){
                ReverseStringFaster("The quick brown fox jumps over the little lazy dog. poor dog was not saved."+ReverseStringFaster("The quick brown fox jumps over the little lazy dog. poor dog was not saved."));
            }
            w3.Stop();
            Console.WriteLine($"Faster algo took {w3.ElapsedTicks} ticks - {w3.Elapsed}");
        }

        // The number of iteraction each 4294967
        // Slow algo took 32327347990 ticks - 00:00:32.3273479
        // Fast algo took 2622064189 ticks - 00:00:02.6220641
        // Faster algo took 2431961945 ticks - 00:00:02.4319619
        // The number of iteraction each 4294967
        // Slow algo took 32982554901 ticks - 00:00:32.9825549
        // Fast algo took 2797517861 ticks - 00:00:02.7975178
        // Faster algo took 2578677613 ticks - 00:00:02.5786776

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
                if(chars[j] == chars[i]) continue; // this comparison makes it slow in general
                char t = chars[i];
                chars[i]=chars[j];
                chars[j]=t;
            }

            return new string(chars);
        }

        static string ReverseStringFaster(string str)
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
