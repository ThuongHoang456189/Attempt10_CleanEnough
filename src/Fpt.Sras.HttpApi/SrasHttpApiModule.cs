using Localization.Resources.AbpUi;
using Fpt.Sras.Localization;
using Volo.Abp.Identity;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;

namespace Fpt.Sras;

[DependsOn(
    typeof(SrasApplicationContractsModule)
    )]
public class SrasHttpApiModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        ConfigureLocalization();
    }

    private void ConfigureLocalization()
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<SrasResource>()
                .AddBaseTypes(
                    typeof(AbpUiResource)
                );
        });
    }
}
