using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Fpt.Sras;

[DependsOn(
    typeof(SrasApplicationContractsModule),
    typeof(AbpIdentityHttpApiClientModule)
)]
public class SrasHttpApiClientModule : AbpModule
{
    public const string RemoteServiceName = "Default";


    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(SrasApplicationContractsModule).Assembly,
            RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<SrasHttpApiClientModule>();
        });
    }
}
