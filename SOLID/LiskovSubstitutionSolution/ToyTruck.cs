namespace LiskovSubstitutionSolution
{
    public class ToyTruck
    {
        public virtual void Start()
        {
            Console.WriteLine($"ToyTruck started");
        }

        public virtual void Run()
        {            
            Console.WriteLine($"ToyTruck is running");
        }
        public virtual void Stop()
        {
            Console.WriteLine("ToyTruck stopped");
        }
    }
}

