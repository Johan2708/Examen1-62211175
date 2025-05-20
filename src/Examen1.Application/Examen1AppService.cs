using Examen1.Localization;
using Volo.Abp.Application.Services;

namespace Examen1;

/* Inherit your application services from this class.
 */
public abstract class Examen1AppService : ApplicationService
{
    protected Examen1AppService()
    {
        LocalizationResource = typeof(Examen1Resource);
    }
}
