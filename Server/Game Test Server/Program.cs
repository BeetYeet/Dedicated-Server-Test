using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Game_Test_Server
{
    class Program
    {
        static bool isRunning = false;
        static void Main(string[] args)
        {
            Console.Title = "Game Dedicated Server";
            isRunning = true;

            Thread mainThread = new Thread(new ThreadStart(MainThread));
            mainThread.Start();

            Server.Start(10, 26950);
        }

        static void MainThread()
        {
            Console.WriteLine($"Main thread started. Running at {Constants.TICKS_PER_SEC} ticks per second.");
            DateTime nextLoop = DateTime.Now;

            while (isRunning)
            {
                while (nextLoop < DateTime.Now)
                {
                    GameLogic.Update();
                    nextLoop = nextLoop.AddMilliseconds(Constants.MS_PER_TICK);

                    if(nextLoop > DateTime.Now)
                    {
                        Thread.Sleep(nextLoop - DateTime.Now);
                    }
                }
            }
        }
    }
}
