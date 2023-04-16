using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Fpt.Sras.Data;
using Volo.Abp.DependencyInjection;

namespace Fpt.Sras.EntityFrameworkCore;

public class EntityFrameworkCoreSrasDbSchemaMigrator
    : ISrasDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreSrasDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the SrasDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<SrasDbContext>()
            .Database
            .MigrateAsync();
    }
}
