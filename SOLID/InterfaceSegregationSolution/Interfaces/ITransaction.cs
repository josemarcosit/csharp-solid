namespace InterfaceSegregationSolution
{
    public interface ITransaction
    {
        void Save();
        void Validate();
    }
}
