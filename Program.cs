using System;

namespace Abax
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Initalize objects
            var bil1 = new Car("NF123456", 147, "Bil", 200, "Grønn", "Lett kjøretøy");
            var bil2 = new Car("NF654321", 150, "bil", 195, "blå", "lett kjøretøy");
            var fly = new Plane("LN1234", 1000, "fly", 30, 2, 10, "Jetfly");
            var boat = new Boat("ABC123", 100, "båt",500, 30);
            

            ShowCars(bil1, bil2);

            ShowPlane(fly);

            ShowBoat(boat);

            Console.WriteLine("********************************");

            ShowCommands(fly, bil1);

            Console.WriteLine("********************************");
        }

        private static void ShowBoat(Boat boat)
        {
            Console.WriteLine($"Kjennetegn: {boat.Kjennetegn}, {boat.Kw}Effekt, Maksfart: {boat.Maksfart}, {boat.BruttoTonnasje}KG Bruttotonnasje");
        }

        private static void ShowPlane(Plane fly)
        {
            Console.WriteLine(
                $"Reg.nr: {fly.Kjennetegn}, {fly.Kw}Kw effekt, Vingespenn: {fly.Vingespenn}, Lasteevne: {fly.Lasteevne}, Egenvekt: {fly.Egenvekt}, Type: {fly.Type}");
        }

        private static void ShowCars(Car bil1, Car bil2)
        {
            Console.WriteLine(
                $"Reg.nr: {bil1.Kjennetegn}, {bil1.Kw}Kw effekt, Maksfart: {bil1.MaxSpeed} Farge: {bil1.Color}, Type: {bil1.Type}");
            Console.WriteLine(
                $"Reg.nr: {bil2.Kjennetegn}, {bil2.Kw}Kw effekt, Maksfart: {bil2.MaxSpeed} Farge: {bil2.Color}, Type: {bil2.Type}");
            Console.WriteLine($"\n");
            IsDifferentOrNotCar(bil1, bil2);
            Console.WriteLine($"\n");
        }

        private static void ShowCommands(Plane fly, Car bil1)
        {
            while (true)
            {
                Console.Write("Skriv inn navn på kjøretøy som skal kjøre, fly eller bil: ");
                var command = Console.ReadLine().ToLower();

                if (command == "fly")
                {
                    Console.WriteLine(fly.IsMoving(fly.TransportType));
                }

                else if (command == "bil")
                {
                    Console.WriteLine(bil1.IsMoving(bil1.TransportType));
                }

            }
        }


        private static void IsDifferentOrNotCar(Car bil1, Car bil2)
        {
            if (bil1.Kjennetegn == bil2.Kjennetegn)
            {
                Console.WriteLine("Bil 1 og Bil 2 er samme bilen");
            }
            else
            {
                Console.WriteLine("Bil 1 og Bil 2 er ikke samme bilen");
            }
        }
    }
}
