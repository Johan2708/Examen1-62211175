using Volo.Abp.Modularity;

namespace Examen1;

[DependsOn(
    typeof(Examen1DomainModule),
    typeof(Examen1TestBaseModule)
)]
public class Examen1DomainTestModule : AbpModule
{

}
