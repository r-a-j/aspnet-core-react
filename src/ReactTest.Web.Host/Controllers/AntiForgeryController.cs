using Microsoft.AspNetCore.Antiforgery;
using ReactTest.Controllers;

namespace ReactTest.Web.Host.Controllers
{
    public class AntiForgeryController : ReactTestControllerBase
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
