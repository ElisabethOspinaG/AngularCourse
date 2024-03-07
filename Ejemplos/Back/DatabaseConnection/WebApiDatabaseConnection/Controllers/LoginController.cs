using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiDatabaseConnection.DataAccess;
using WebApiDatabaseConnection.Models;
using WebApiDatabaseConnection.Services;

namespace WebApiDatabaseConnection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        LoginService service = new LoginService();
        [HttpGet("Login")]
        public bool Login(string username, string password)
        {
            return service.VerifyCredentials(username, password);
        }

        [HttpPost("Register")]
        public bool Register(string name, string lastName, string username, string password)
        {
            return service.CreateAccount(name, lastName,username,password);
        }

        [HttpPost("Register2")]
        public bool Register2([FromBody] Employee employee)
        {
            return service.CreateAccount2(employee);
        }
        [HttpPost("Login2")]
        public bool Login2(LoginModel loginInfo)
        {            
            return service.Login2(loginInfo);
        }
    }
}
