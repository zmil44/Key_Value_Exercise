using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key_Value_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new MyDictionary<int>();
            try
            {
                Console.WriteLine(d["Cats"]);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            d["Cats"] = 42;
            d["Dogs"] = 17;
            Console.WriteLine($"{d["Cats"]}, {d["Dogs"]}");
        }
    }
}
