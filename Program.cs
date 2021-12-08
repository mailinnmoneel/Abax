using System;

namespace Abax
{
    class Program
    {
        static void Main(string[] args)
        {
            var bil1 = new Car("NF123456", 147, "Bil", 200, "Grønn", "Lett kjøretøy");
            var bil2 = new Car("NF654321", 150, "bil", 195, "blå", "lett kjøretøy");
            var fly = new Plane("LN1234", 1000, "fly", 30, 2, 10, "Jetfly");
            var boat = new Boat("ABC123", 100, "båt",500, 30);
            

            bil1.Show();
            bil2.Show();
            fly.Show();
            boat.Show();
            bil1.Compare(bil2);
            ShowCommands(fly, bil1);
        }

        private static void ShowCommands(Plane fly, Car bil1)
        {
            while (true)
            {
                Console.Write("Tilgjengelige kommandoer er fly eller bil: ");
                var command = Console.ReadLine().ToLower();

                if (command == "fly")
                {
                    Console.WriteLine(fly.Run(fly.TransportType));
                }

                else if (command == "bil")
                {
                    Console.WriteLine(bil1.Run(bil1.TransportType));
                }

            }
        }


        
    }
}
