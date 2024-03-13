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

        [HttpGet("showUsers")]

        public List<Employee> ShowUsers()
        {
            return login.ShowUsers();
        }

        [HttpGet("showAllUsers")]

        public HttpResponsiveModel ShowAllUsers()
        {
            return login.ShowAllUsers();
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

        [HttpGet("acceseAcount")]

        public bool AcceseAcount(string user, string password)
        {
            return login.AcceseAcount(user, password);
        }

        [HttpPost("registerUser")]
        public bool RegisterUser(ModelNewUser modelNewUser)
        {
            return login.RegisterUser(modelNewUser);
        }

        //[HttpPost("modifyPassword")]
        //public bool ModifyPassword(ModelsLogin modelsLogin)
        //{
        //    return login.ModifyPassword(modelsLogin);
        //}

        //[HttpPost("deleteUser")]
        //public bool DeleteUser(ModelsLogin modelsLogin)
        //{
        //    return login.DeleteUser(modelsLogin);
        //}
        }
}
