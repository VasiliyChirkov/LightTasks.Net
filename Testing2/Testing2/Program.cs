using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing2
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            var num = 0;
            int[] arr = new int [int.Parse(n)];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            foreach (int i in arr)
            {
                num += i;
            }
            Console.WriteLine(-num);
        }
    }
}
