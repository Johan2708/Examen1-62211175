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
    public class ComentarioAppService : CrudAppService<
        Comentario,
        ComentarioDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CrearComentarioDto
    >, IApplicationService
    {
        private readonly IRepository<Comentario, Guid> _comentarioRepository;

        public ComentarioAppService(IRepository<Comentario, Guid> repository) : base(repository)
        {
            _comentarioRepository = repository;
        }

        // Agregar comentario a un caso (ya lo hace el CRUD, pero puedes agregar lógica)
        public override async Task<ComentarioDto> CreateAsync(CrearComentarioDto input)
        {
            var comentario = ObjectMapper.Map<CrearComentarioDto, Comentario>(input);
            comentario.Fecha = DateTime.Now;
            await _comentarioRepository.InsertAsync(comentario);
            return ObjectMapper.Map<Comentario, ComentarioDto>(comentario);
        }

        // Ver comentarios de un caso
        public async Task<List<ComentarioDto>> GetByCasoIdAsync(Guid casoId)
        {
            var query = await _comentarioRepository.GetListAsync(x => x.CasoId == casoId);
            return ObjectMapper.Map<List<Comentario>, List<ComentarioDto>>(query.ToList());
        }
    }
}