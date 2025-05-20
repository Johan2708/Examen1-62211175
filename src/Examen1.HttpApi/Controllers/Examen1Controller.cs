using Examen1.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Examen1.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class Examen1Controller : AbpControllerBase
{
    protected Examen1Controller()
    {
        LocalizationResource = typeof(Examen1Resource);
    }
}
