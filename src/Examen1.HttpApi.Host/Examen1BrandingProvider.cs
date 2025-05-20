using Microsoft.Extensions.Localization;
using Examen1.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Examen1;

[Dependency(ReplaceServices = true)]
public class Examen1BrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<Examen1Resource> _localizer;

    public Examen1BrandingProvider(IStringLocalizer<Examen1Resource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
