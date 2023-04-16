using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Fpt.Sras.Data;

/* This is used if database provider does't define
 * ISrasDbSchemaMigrator implementation.
 */
public class NullSrasDbSchemaMigrator : ISrasDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
