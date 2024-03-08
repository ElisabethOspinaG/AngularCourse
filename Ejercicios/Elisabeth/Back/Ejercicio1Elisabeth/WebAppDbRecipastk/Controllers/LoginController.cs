using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppDbRecipastk.DataAccess;
using WebAppDbRecipastk.Models;
using WebAppDbRecipastk.services;

namespace WebAppDbRecipastk.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        public LoginServices login = new LoginServices();

        [HttpGet("shorUsers")]

        public List<Employee> ShowUsers()
        {
            return login.ShowUsers();
        }

        [HttpGet("exitUsername")]
        public bool ExistUsername(string user)
        {
            return login.ExistUsername(user);
        }

        [HttpGet("getUser")]
        public Employee GetlUser(string user)
        {

            return login.GetlUser(user);
        }

        [HttpGet("verifyPassword")]

        public string VerifyPassword(string user, string password)
        {
            return login.VerifyPassword(user, password);
        }

        [HttpPost("acceseAcount")]

        public bool AcceseAcount(string user, string password)
        {
            return login.AcceseAcount(user, password);


        }

        [HttpPost("registerUser")]
        public bool RegisterUser(string name, string lastname, string user, string password)
        {

            return login.RegisterUser(name, lastname, user, password);

        }


        [HttpPost("modifyPassword")]
        public string ModifyPassword(string user, string password, string newPassword)
        {
            return login.ModifyPassword(user, password, newPassword);
        }

        [HttpPost("removeUser")]
        public bool RemoveUser(string user)
        {
            return login.RemoveUser(user);
        }
        }
}
