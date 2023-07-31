namespace InterfaceSegregationProblem
{
    public interface ITransaction
    {
        void Validate();
        void Save();
        void SendEmail();
    }
}
