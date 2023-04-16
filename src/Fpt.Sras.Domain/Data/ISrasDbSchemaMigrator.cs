using System.Threading.Tasks;

namespace Fpt.Sras.Data;

public interface ISrasDbSchemaMigrator
{
    Task MigrateAsync();
}
