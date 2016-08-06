using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            for (int i = 0; i < 10; i++)
            {
                dict["11"] = i.ToString();
            }
            Console.WriteLine(dict.Values.Count);


        }
    }
}
