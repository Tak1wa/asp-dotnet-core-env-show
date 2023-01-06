using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace asp_dotnet_core_env_show.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HogeController : ControllerBase
    {
        [HttpGet(Name = "GetEnvironmentValues")]
        public IEnumerable<string?> Get()
        {
            return new[] {
                Environment.GetEnvironmentVariable("HOGE_ENV1"), 
                Environment.GetEnvironmentVariable("HOGE_ENV2")
                };
        }
    }
}