using Newtonsoft.Json;

namespace Core.Dtos
{
    public class Customers
    {
        public Customers(string email)
        {
            Email = email;
        }

        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}