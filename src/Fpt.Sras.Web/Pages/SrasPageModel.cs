using Fpt.Sras.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Fpt.Sras.Web.Pages;

public abstract class SrasPageModel : AbpPageModel
{
    protected SrasPageModel()
    {
        LocalizationResourceType = typeof(SrasResource);
    }
}
