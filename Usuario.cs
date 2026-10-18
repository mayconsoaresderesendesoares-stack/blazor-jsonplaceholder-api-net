using System.Text.Json.Serialization;

namespace BlazorUsersJsonPlaceHolderApi.Models
{
    public class Usuario
    {
        [JsonPropertyName("name")]
        public string Nome { get; set; } = string.Empty;

        [JsonPropertyName("address")]
        public Endereco? Address { get; set; }

        [JsonPropertyName("company")]
        public Empresa? Company { get; set; }
    }

    public class Endereco
    {
        [JsonPropertyName("city")]
        public string Cidade { get; set; } = string.Empty;
    }

    public class Empresa
    {
        [JsonPropertyName("name")]
        public string Nome { get; set; } = string.Empty;
    }
}