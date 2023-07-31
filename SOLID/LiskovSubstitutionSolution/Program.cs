namespace LiskovSubstitutionSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {              
            var truck = new Truck(RefuelType.Gasoline);
            truck.Start();
            truck.Run();
            truck.Refuel(2);
            truck.Run();
            truck.Stop();

            var eletronicToyTruck = new EletronicToyTruck();
            eletronicToyTruck.Start();
            eletronicToyTruck.Run();
            eletronicToyTruck.Stop();
        }
    }
}