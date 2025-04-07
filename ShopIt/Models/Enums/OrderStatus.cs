using System.Runtime.Serialization;

namespace ShopIt.Models.Enums
{
    public enum OrderStatus
    {
        [EnumMember(Value = "Pending")]
        Pending = 1,
        [EnumMember(Value = "Cancelled")]
        Cancelled = 2,
        [EnumMember(Value = "Transit")]
        Transit = 3,
        [EnumMember(Value = "Delivered")]
        Delivered = 4,
    }
}
