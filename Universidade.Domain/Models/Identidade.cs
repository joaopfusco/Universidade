using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Universidade.Domain.Models
{
    public class Identidade : BaseModel
    {
        public string Cpf { get; set; }
        public string Matricula { get; set; }

        public int AlunoId { get; set; }

        [JsonIgnore]
        public Aluno Aluno { get; set; }
    }
}
