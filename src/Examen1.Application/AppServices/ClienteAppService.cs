using Volo.Abp.Application.Services;
using Examen1_62211175.Domain.Entities;
using Examen1_62211175.Application.Contracts.Dtos;
using Volo.Abp.Domain.Repositories;
using System;
using System.Threading.Tasks;

namespace Examen1_62211175.Application.Services
{
    public class ClienteAppService : CrudAppService<
        Cliente, //Entidad
        ClienteDto, //DTO para mostrar
        Guid, //Primary Key
        PagedAndSortedResultRequestDto, //Paginación
        CrearClienteDto //DTO para crear/actualizar
    >, IApplicationService
    {
        public ClienteAppService(IRepository<Cliente, Guid> repository) : base(repository)
        {
        }
    }
}