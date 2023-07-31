
namespace LiskovSubstitutionSolution
{
    public class EletronicToyTruck : ToyTruck
    {
        public override void Start()
        {
            Console.WriteLine($"EletronicToyTruck started");
        }

        public override void Run()
        {
            Console.WriteLine($"EletronicToyTruck is running");
        }
        public override void Stop()
        {
            Console.WriteLine("EletronicToyTruck stopped");
        }
    }
}
