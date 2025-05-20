using System;

namespace Examen1_62211175.Application.Contracts.Dtos
{
    public class CrearComentarioDto
    {
        public Guid CasoId { get; set; }
        public string Texto { get; set; }
    }
}