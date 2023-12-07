using System;

namespace Ipet.Domain.Models
{
    public abstract class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
            DataCadastro = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("America/Sao_Paulo"));
        }

        public Guid Id { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}