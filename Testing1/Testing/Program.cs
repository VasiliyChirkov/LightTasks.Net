using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            List<char> list = new List<char>();
            foreach (char ch in x)
            {
                list.Add(ch);
            }
            list.Sort();
            string min = "";
            foreach (char ch in list)
            {
                min += ch;
            }
            list.Reverse();
            string max = "";
            foreach (char ch in list)
            {
                max += ch;
            }
            Console.WriteLine(int.Parse(max)-int.Parse(min));
        }
    }
}
