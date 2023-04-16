using Volo.Abp.Modularity;

namespace Fpt.Sras;

[DependsOn(
    typeof(SrasApplicationModule),
    typeof(SrasDomainTestModule)
    )]
public class SrasApplicationTestModule : AbpModule
{

}
