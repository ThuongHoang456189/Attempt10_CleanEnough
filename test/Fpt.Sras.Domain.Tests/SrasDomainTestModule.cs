using Fpt.Sras.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Fpt.Sras;

[DependsOn(
    typeof(SrasEntityFrameworkCoreTestModule)
    )]
public class SrasDomainTestModule : AbpModule
{

}
