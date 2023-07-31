namespace LiskovSubstitutionProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var truck = new Truck(RefuelType.Gasoline);
            truck.Run();
            truck.Refuel(2);
            truck.Run();

            var toyTruck = new ToyTruck(RefuelType.None);
            toyTruck.Run();
            toyTruck.Refuel(3); //InvalidOperationException("ToyTruck does not need to refuel")
            toyTruck.Run();            
        }
    }
}