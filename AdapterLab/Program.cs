using System;
using AdapterLibrary;

namespace AdapterLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Lab 3: Adapter + Singleton + DLL ===\n");

            Console.WriteLine("Connecting to library via Singleton...");
            var connection = LibraryConnection.Instance;

            IDigitalTime digitalClock = connection.CreateAdapter(90, 180);

            Console.WriteLine($"Digital Output: {digitalClock.GetTime()}");

            Console.ReadKey();
        }
    }
}