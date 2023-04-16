using Fpt.Sras.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Fpt.Sras.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class SrasController : AbpControllerBase
{
    protected SrasController()
    {
        LocalizationResource = typeof(SrasResource);
    }
}
