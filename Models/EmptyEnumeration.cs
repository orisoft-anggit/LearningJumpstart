using System;
using System.Text.Json.Serialization;

namespace LearningJumpstart.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EmptyEnumeration
    {
        Knight = 1,
        Mage = 2,
        Cleric = 3
    }
}

