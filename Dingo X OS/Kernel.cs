using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace Dingo_X_OS
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.WriteLine("Welcome to the Dingo X OS!");
        }

        protected override void Run()
        {
        start:
            Console.WriteLine("User: ");
            string command = Console.ReadLine();
            if (command == "/echo.on") goto echo;
            if (command == "/help") Console.WriteLine("Type in echo to turn on echo mode.");
            if (command == "cls") goto cls;
            else
                Console.WriteLine("Incorrect Command.");
            goto start;
        echo:
            Console.WriteLine("Echo: ");
            string echo = Console.ReadLine();
            if (echo == "echo.off") goto start;
            else
            Console.WriteLine("Echo: " + echo);
            goto echo;
        cls:
            Console.Clear();
            goto start;
        }
    }
}
