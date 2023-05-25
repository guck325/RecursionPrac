using System;
using System.Collections.Generic;

namespace RecursionPrac
{
    internal class FibonacciAdv
    {
        //static 저장하는 역할?
        private static Dictionary<int, long> memo = new Dictionary<int, long>();
        public long Get(int n)
        {
            //throw new NotImplementedException(); 구현이 안되어있다는 코드?
            if(n<0) { return 0; }
            if(n ==1) { return 1;}

            if(memo.ContainsKey(n)) { return memo[n]; }
            else
            {
                long value = Get(n - 2) + Get(n - 1);
                memo[n] = value;
                return value;

            }
        }
    }
}