using Microsoft.AspNetCore.Mvc;
namespace REST_host.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompositeTypeController : ControllerBase
    {
        private readonly ILogger<CompositeTypeController> _logger;

        public CompositeTypeController(ILogger<CompositeTypeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<string> GetData(int value) 
        {
            return Ok($"REST - entered: {value}");
        }

        [HttpGet]
        [Route("contract")]
        public ActionResult<CompositeType> GetDataUsingDataContract(bool compositeBoolValue, string compositeStringValue) 
        {
            return Ok(new CompositeType() 
            {
                BoolValue= compositeBoolValue,
                StringValue= $"REST - {compositeStringValue}"
            });
        }

        [HttpPost]
        public ActionResult<CompositeType> Post(CompositeType composite)
        {
            return Ok(composite);
        }
    }
}
