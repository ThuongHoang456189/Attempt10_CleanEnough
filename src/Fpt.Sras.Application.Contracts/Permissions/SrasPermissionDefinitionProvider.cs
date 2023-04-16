using Fpt.Sras.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Fpt.Sras.Permissions;

public class SrasPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(SrasPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(SrasPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<SrasResource>(name);
    }
}
