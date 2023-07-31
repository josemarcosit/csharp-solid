using System.Runtime.Serialization;

namespace LiskovSubstitutionSolution
{
    public enum RefuelType
    {
        [EnumMember(Value = "Gasoline")]
        Gasoline,

        [EnumMember(Value = "Alcohol")]
        Alcohol,

        [EnumMember(Value = "Diesel")]
        Diesel
    }
}
