using Examen1.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Examen1.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(Examen1EntityFrameworkCoreModule),
    typeof(Examen1ApplicationContractsModule)
)]
public class Examen1DbMigratorModule : AbpModule
{
}
