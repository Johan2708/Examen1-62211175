using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Examen1_62211175.Domain.Entities
{
    public class Cliente : AuditedAggregateRoot<Guid>
    {
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        
        public virtual ICollection<Caso> Casos { get; set; }
    }
}
