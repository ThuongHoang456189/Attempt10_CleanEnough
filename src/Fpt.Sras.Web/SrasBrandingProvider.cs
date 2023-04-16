using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Fpt.Sras.Web;

[Dependency(ReplaceServices = true)]
public class SrasBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Sras";
}
