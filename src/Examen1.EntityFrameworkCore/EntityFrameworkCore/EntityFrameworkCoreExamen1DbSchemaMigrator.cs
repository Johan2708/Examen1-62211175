using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Examen1.Data;
using Volo.Abp.DependencyInjection;

namespace Examen1.EntityFrameworkCore;

public class EntityFrameworkCoreExamen1DbSchemaMigrator
    : IExamen1DbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreExamen1DbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the Examen1DbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<Examen1DbContext>()
            .Database
            .MigrateAsync();
    }
}
