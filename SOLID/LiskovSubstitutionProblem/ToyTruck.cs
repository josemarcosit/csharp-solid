namespace LiskovSubstitutionProblem
{
    public class ToyTruck : Truck
    {
        public ToyTruck(RefuelType refuelType) : base(refuelType)
        {
            
        }      

        public override void Start()
        {
            Console.WriteLine($"ToyTruck started");
        }

        public override void Run()
        {
            if (TotalLiters <= 0)
            {
                Console.WriteLine($"ToyTruck needs to refuel");
                return;
            }

            TotalLiters -= 1;
            Console.WriteLine($"ToyTruck is running: {TotalLiters}");
        }
        public override void Stop()
        {
            Console.WriteLine("ToyTruck stopped");
        }

        public override void Refuel(int amount)
        {
            throw new InvalidOperationException("ToyTruck does not need to refuel");
        }
    }
}
