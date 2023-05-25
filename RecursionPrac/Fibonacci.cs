using System;

namespace RecursionPrac
{
    internal class Fibonacci
    {
        public long Get(int n)
        {//Get(3) -> Get(2)+Get(1)
            Console.WriteLine(n+" ");
            if(n < 0) { return 0; }
            if(n == 1) {  return 1; }
            return Get(n-2)+Get(n-1);
        }
    }
}