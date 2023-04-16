using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Linq;
using Volo.Abp.Threading;

namespace Fpt.Sras.Filters
{
    public class SwaggerFilter : IDocumentFilter
    {
        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            swaggerDoc.Paths
                .Where(x => x.Key.ToLowerInvariant().StartsWith("/api/abp") || x.Key.ToLowerInvariant().StartsWith("/api/identity"))
                .ToList()
                .ForEach(x => swaggerDoc.Paths.Remove(x.Key));
        }
    }
}
