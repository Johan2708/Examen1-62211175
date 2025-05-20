using System;

namespace Examen1_62211175.Application.Contracts.Dtos
{
    public class CrearCasoDto
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public int Tipo { get; set; }
        public Guid ClienteId { get; set; }
    }
}