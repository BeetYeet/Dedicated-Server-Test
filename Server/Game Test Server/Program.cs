using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Test_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Game Dedicated Server";

            Server.Start(10, 26950);

            Console.ReadKey();
        }
    }
}
