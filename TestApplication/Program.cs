using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{

    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new DatabaseContext())
            {
               var ret =  ctx.Users.FirstOrDefault();
               Console.WriteLine("a!!sdasdssasas:::"+ret.NAME);
            }
            
            Console.ReadLine();
        }

    }
}
