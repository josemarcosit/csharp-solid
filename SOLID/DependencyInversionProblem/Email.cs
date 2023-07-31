namespace DependencyInversionProblem
{
    public class Email
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Body { get; set; }
        public bool IsValid()
        {
            if(string.IsNullOrEmpty(From)) return false;
            if(string.IsNullOrEmpty(To)) return false;
            
            return From.Contains("@") && To.Contains("@");
        }
    }
}
