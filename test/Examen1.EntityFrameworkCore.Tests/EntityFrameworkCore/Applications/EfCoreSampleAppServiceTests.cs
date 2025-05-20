using Examen1.Samples;
using Xunit;

namespace Examen1.EntityFrameworkCore.Applications;

[Collection(Examen1TestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<Examen1EntityFrameworkCoreTestModule>
{

}
