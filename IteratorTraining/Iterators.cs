using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorTraining
{
    public static class Iterators
    {
        public static IEnumerable<string> OtherWay(this string a)
        {
            if(string.IsNullOrEmpty(a))
            {
                Console.WriteLine("Null");
                yield break;
            }
            for (int i = a.Length - 1; i >= 0; i--)
            {
                yield return a[i].ToString().ToUpperInvariant();
            }
        }

        public static void ooo(Action<int> action)
        {
            action(1);
        }
    }
}
