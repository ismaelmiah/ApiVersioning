using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.WebApi.Controllers.v1
{
// DEPRECATING an API Version
    [ApiVersion("1.0", Deprecated = true)]
    [Route("api/[controller]")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Data From V1";
        }
    }
}
