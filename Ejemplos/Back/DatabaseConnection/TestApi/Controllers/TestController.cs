using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestApi.Services;

namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("Prueba")]
        public string GetPrueba()
        {
            return "Executed GET: prueba successfully";
        }

        [HttpPost("Prueba")]
        public string PostPrueba()
        {
            return "Executed POST: prueba successfully";
        }

        [HttpPost("Older")]
        public string PostPrueba2(int age)
        {
            var testService = new TestService();
            return testService.IsOlderThan18(age);
        }
    }
}
