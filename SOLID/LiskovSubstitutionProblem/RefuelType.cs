using System.Runtime.Serialization;

namespace LiskovSubstitutionProblem
{
    public enum RefuelType
    {
        [EnumMember(Value = "Gasoline")]
        Gasoline,

        [EnumMember(Value = "Alcohol")]
        Alcohol,

        [EnumMember(Value = "Diesel")]
        Diesel,

        [EnumMember(Value = "None")]
        None
    }
}
