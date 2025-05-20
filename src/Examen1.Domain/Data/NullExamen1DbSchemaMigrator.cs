using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Examen1.Data;

/* This is used if database provider does't define
 * IExamen1DbSchemaMigrator implementation.
 */
public class NullExamen1DbSchemaMigrator : IExamen1DbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
