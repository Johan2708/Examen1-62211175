using Volo.Abp.Modularity;

namespace Examen1;

/* Inherit from this class for your domain layer tests. */
public abstract class Examen1DomainTestBase<TStartupModule> : Examen1TestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
