using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Examen1_62211175.Domain.Entities
{
    public enum CasoTipo
    {
        Queja,
        Sugerencia,
        Solicitud
    }

    public enum CasoEstado
    {
        Abierto,
        EnProceso,
        Cerrado
    }

    public class Caso : AuditedAggregateRoot<Guid>
    {
        public Guid ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }

        public string Titulo { get; set; }
        public string Descripcion { get; set; }

        public CasoTipo Tipo { get; set; }
        public CasoEstado Estado { get; set; }

        public virtual ICollection<Comentario> Comentarios { get; set; } = new List<Comentario>();
    }
}
