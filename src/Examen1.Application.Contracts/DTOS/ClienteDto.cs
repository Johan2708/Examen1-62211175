using System;

namespace Examen1_62211175.Application.Contracts.Dtos
{
    public class ClienteDto
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
    }
}