using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Examen1_62211175.Domain.Entities
{
    public class Comentario : AuditedAggregateRoot<Guid>
    {
        public Guid CasoId { get; set; }
        public virtual Caso Caso { get; set; }

        public string Texto { get; set; }
    }
}
