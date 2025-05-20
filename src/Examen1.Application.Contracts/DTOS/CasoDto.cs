using System;

namespace Examen1_62211175.Application.Contracts.Dtos
{
    public class CasoDto
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public int Tipo { get; set; } // Usar enum en el futuro si lo necesitas
        public int Estado { get; set; }
        public Guid ClienteId { get; set; }
    }
}