
namespace GuidoApi.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;

    [ApiController]
    [Route("[controller]")]
    public class GuidoController : ControllerBase
    {
        
        private readonly ILogger<GuidoController> _logger;

        public GuidoController(ILogger<GuidoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Guid Get() => Guid.NewGuid();
    }
}
