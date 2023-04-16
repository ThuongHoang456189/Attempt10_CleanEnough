using Fpt.Sras.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Fpt.Sras.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(SrasEntityFrameworkCoreModule),
    typeof(SrasApplicationContractsModule)
    )]
public class SrasDbMigratorModule : AbpModule
{

}
