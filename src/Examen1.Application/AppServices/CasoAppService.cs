using Volo.Abp.Application.Services;
using Examen1_62211175.Domain.Entities;
using Examen1_62211175.Application.Contracts.Dtos;
using Volo.Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen1_62211175.Application.Services
{
    public class CasoAppService : CrudAppService<
        Caso,
        CasoDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CrearCasoDto
    >, IApplicationService
    {
        private readonly IRepository<Caso, Guid> _casoRepository;

        public CasoAppService(IRepository<Caso, Guid> repository) : base(repository)
        {
            _casoRepository = repository;
        }

        // Consultar casos por cliente
        public async Task<List<CasoDto>> GetByClienteIdAsync(Guid clienteId)
        {
            var query = await _casoRepository.GetListAsync(x => x.ClienteId == clienteId);
            return ObjectMapper.Map<List<Caso>, List<CasoDto>>(query.ToList());
        }

        // Cambiar estado del caso
        public async Task CambiarEstadoAsync(Guid casoId, int nuevoEstado)
        {
            var caso = await _casoRepository.GetAsync(casoId);
            caso.Estado = (EstadoCaso)nuevoEstado;
            await _casoRepository.UpdateAsync(caso);
        }

        // Filtrar casos por tipo o estado
        public async Task<List<CasoDto>> GetByTipoEstadoAsync(int? tipo, int? estado)
        {
            var query = await _casoRepository.GetListAsync(x =>
                (!tipo.HasValue || (int)x.Tipo == tipo) &&
                (!estado.HasValue || (int)x.Estado == estado)
            );
            return ObjectMapper.Map<List<Caso>, List<CasoDto>>(query.ToList());
        }
    }
}