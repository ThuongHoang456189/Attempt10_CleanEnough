using System;
using System.Collections.Generic;
using System.Text;
using Fpt.Sras.Localization;
using Volo.Abp.Application.Services;

namespace Fpt.Sras;

/* Inherit your application services from this class.
 */
public abstract class SrasAppService : ApplicationService
{
    protected SrasAppService()
    {
        LocalizationResource = typeof(SrasResource);
    }
}
