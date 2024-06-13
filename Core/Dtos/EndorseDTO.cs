using Data.Enums;
using System.Text.Json.Serialization;

namespace Core.Dtos
{
    public class EndorseDTO
    {
        [JsonIgnore]
        public string? UserId { get; set; }
        public string StoreName { get; set; }
        public string Comment { get; set; }
        public EndorseReport Endorse { get; set; }
    }

    public class EndorseToReturnDTO
    {
        public string Comment { get; set; }
        public string StoreName { get; set; }
        public string DateTime { get; set; }
    }
}
