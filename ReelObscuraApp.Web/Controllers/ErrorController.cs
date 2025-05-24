using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ReelObscuraApp.Web.Controllers
{
    public class ErrorController : Controller
    {
        private readonly ILogger<ErrorController> _logger;

        public ErrorController(ILogger<ErrorController> logger)
        {
            _logger = logger;
        }

        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            var statusFeature = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();

            if (statusCode == 404)
            {
                _logger.LogWarning($"404 Error: {statusFeature?.OriginalPath}");
                return View("NotFound"); // Din befintliga 404-sida
            }

            return View("ServerError");
        }

        [Route("Error")]
        public IActionResult ServerError()
        {
            var exceptionFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            if (exceptionFeature != null)
            {
                _logger.LogError($"500 Error: {exceptionFeature.Path}\n{exceptionFeature.Error}");
                ViewBag.ErrorId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            }

            return View("ServerError");
        }
    }
}