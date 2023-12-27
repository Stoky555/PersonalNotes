using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using PersonalNotesV2.Client;

namespace PersonalNotesV2
{
    public class CookieEvents : CookieAuthenticationEvents
    {
        public override Task RedirectToLogin(RedirectContext<CookieAuthenticationOptions> context)
        {
            context.RedirectUri = "/login";
            return base.RedirectToLogin(context);
        }
    }
}
