using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ApiVersioning.WebApi.Controllers.v2
{
    [ApiVersion("2.0")]
    [Route("api/[controller]")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Data From V2";
        }
    }
}
