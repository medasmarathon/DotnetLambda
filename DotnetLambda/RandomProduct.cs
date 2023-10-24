using System.Text.Json.Serialization;

namespace DotnetLambda
{
    public class RandomProduct
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("summary")]
        public string? Summary { get; set; }
    }
}