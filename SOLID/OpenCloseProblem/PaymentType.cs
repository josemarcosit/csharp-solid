using System.Runtime.Serialization;

namespace OpenCloseProblem
{
    public enum PaymentType
    {
        [EnumMember(Value = "Cash")]
        Cash,

        [EnumMember(Value = "Card")]
        Card
    }
}
