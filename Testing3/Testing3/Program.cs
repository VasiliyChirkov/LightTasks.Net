using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> table = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split(' ');
                table.Add(arr[0], int.Parse(arr[1]));
            }
            string[] match = Console.ReadLine().Split('-');

            
            ResultAfterMatch(table, match, 3, 0);
            ResultAfterMatch(table, match, 1, 1);
            ResultAfterMatch(table, match, 0, 3);
        }

        private static void ResultAfterMatch(Dictionary<string, int> table, string[] match, int first, int second)
        {
            table[match[0]] += first;
            table[match[1]] += second;
            List<string> list = new List<string>();

            foreach (var pair in table.OrderByDescending(v => v.Value).ThenBy(k => k.Key))
            {
                list.Add(pair.Key);
            }
            Console.Write((list.IndexOf(match[0]) + 1) + " ");
            table[match[0]] -= first;
            table[match[1]] -= second;
        }
    }
}
