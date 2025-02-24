using System.Text.Json.Serialization;

namespace Universidade.Domain.Models
{
    public class Aluno : BaseModel
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }

        [JsonIgnore]
        public Identidade Identidade { get; set; }
    }
}
