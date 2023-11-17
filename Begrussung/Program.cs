using Microsoft.VisualBasic;
using System;

namespace Begrussung {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hallo, wie heißt du?");
            String name = Console.ReadLine();
            Console.WriteLine("Hallo " + name);
            Console.WriteLine($"Heute ist der {DateTime.Now.ToShortDateString()} und wir haben {DateTime.Now.ToShortTimeString()} Uhr!");
        }
    }
}


