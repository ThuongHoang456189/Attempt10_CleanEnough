using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Fpt.Sras.Web.Pages;

public class IndexModel : SrasPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
