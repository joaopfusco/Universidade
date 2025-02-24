using Universidade.Domain.Interfaces;
using System;
using System.Text.Json.Serialization;

namespace Universidade.Domain.Models
{
    public class BaseModel : IBaseModel<int>
    {
        [JsonIgnore]
        public int Id { get; set; }
    }
}
