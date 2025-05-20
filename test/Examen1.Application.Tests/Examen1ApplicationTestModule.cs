using Volo.Abp.Modularity;

namespace Examen1;

[DependsOn(
    typeof(Examen1ApplicationModule),
    typeof(Examen1DomainTestModule)
)]
public class Examen1ApplicationTestModule : AbpModule
{

}
