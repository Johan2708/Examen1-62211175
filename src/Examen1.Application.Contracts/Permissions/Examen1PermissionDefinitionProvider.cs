using Examen1.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Examen1.Permissions;

public class Examen1PermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(Examen1Permissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(Examen1Permissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<Examen1Resource>(name);
    }
}
