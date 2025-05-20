using System;

namespace Examen1_62211175.Application.Contracts.Dtos
{
    public class ComentarioDto
    {
        public Guid Id { get; set; }
        public Guid CasoId { get; set; }
        public string Texto { get; set; }
        public DateTime Fecha { get; set; }
    }
}