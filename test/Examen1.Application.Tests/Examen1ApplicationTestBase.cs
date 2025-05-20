using Volo.Abp.Modularity;

namespace Examen1;

public abstract class Examen1ApplicationTestBase<TStartupModule> : Examen1TestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
