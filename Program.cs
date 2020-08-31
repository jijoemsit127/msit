using System;
using System.Linq;
namespace test0831
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new msit127_4Context();
            var ret = from c in db.Tuser
                      select c;

            foreach (var item in ret)
            {
                Console.WriteLine($"{item.Uname} - {item.Uage} - {item.Umale} ");
            }
        }
    }
}
