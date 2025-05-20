using Examen1.Samples;
using Xunit;

namespace Examen1.EntityFrameworkCore.Domains;

[Collection(Examen1TestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<Examen1EntityFrameworkCoreTestModule>
{

}
