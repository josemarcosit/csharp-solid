namespace LiskovSubstitutionProblem
{
    public class Truck 
    {
        private readonly RefuelType _refuelType;
        public virtual int TotalLiters { get; set; } 

        public Truck(RefuelType refuelType)
        {
            _refuelType = refuelType;
        }
        public virtual void Start()
        {           
            Console.WriteLine($"Truck started: {_refuelType}");
        }

        public virtual void Run()
        {
            if(TotalLiters <= 0)
            {
                Console.WriteLine($"Truck needs to refuel");
                return;
            }

            TotalLiters -= 1;
            Console.WriteLine($"Truck is running: {TotalLiters}");
        }
        public virtual void Stop()
        {
            Console.WriteLine("Truck stopped");
        }

        public virtual void Refuel(int amount)
        {
            TotalLiters += amount;
        }          
    }
}
