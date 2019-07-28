using Microsoft.AspNetCore.Antiforgery;
using blogger.Controllers;

namespace blogger.Web.Host.Controllers
{
    public class AntiForgeryController : bloggerControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
