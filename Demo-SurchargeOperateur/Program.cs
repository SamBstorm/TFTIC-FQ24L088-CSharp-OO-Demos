namespace Demo_SurchargeOperateur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle car1 = new Vehicle(4);
            car1.SetConductor("Charlie");
            car1.AddPassenger("Thierry");
            car1.AddPassenger("Michaël");
            car1.AddPassenger("Mauritcio");

            Vehicle car2 = new Vehicle(3);
            car2.SetConductor("Samuel");
            car2.AddPassenger("Aude");
            car2.AddPassenger("Arthur");
            car2.AddPassenger("Charlote");

            Vehicle bus = car1 + car2;

            //Console.WriteLine($"Pour contenir l'ensemble des passagers des 2 voitures, mon bus à une limite de {bus._limit}.");
            Console.WriteLine($"Sera conduit par le conducteur de la première voiture : {bus.ConductorName}.");
            Console.WriteLine("Tous les autres sont passagers :");
            foreach (string name in bus.PassengerNames)
            {
                Console.WriteLine($"\t- {name}");
            }

            Vehicle monBus = new Vehicle(8);

            if(monBus >= bus)
            {
                Console.WriteLine("Oui, ce bus est suffisant pour transporter les passagers!");
            }
            else
            {
                Console.WriteLine("Non, votre bus n'a pas la place requise pour transporter les passagers.");
            }

            Console.WriteLine($"Voici la seconde voiture, elle est conduite par : {car2.ConductorName}.");
            Console.WriteLine($"Thomas veut monter en voiture.");
            car2 = car2 + "Thomas";

            Console.WriteLine("Tous les autres sont passagers :");
            foreach (string name in car2.PassengerNames)
            {
                Console.WriteLine($"\t- {name}");
            }
            Console.WriteLine($"Thomas veut monter dans la première voiture.");
            car1 = car1 + "Thomas";

            Console.WriteLine("Tous les autres sont passagers :");
            foreach (string name in car1.PassengerNames)
            {
                Console.WriteLine($"\t- {name}");
            }
        }
    }
}
