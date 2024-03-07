using WebApiDatabaseConnection.DataAccess;
using WebApiDatabaseConnection.Models;

namespace WebApiDatabaseConnection.Services
{
    public class LoginService
    {
        private ReciplastkContext db = new ReciplastkContext();

        public bool VerifyCredentials(string username, string password)
        {
            var result = db.Employees.Where(p => p.Username == username && p.Password == password).FirstOrDefault();
            if (result == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool Login2(LoginModel loginInfo)
        {
            var result = db.Employees.Where(p => p.Username == loginInfo.UserName && p.Password == loginInfo.Password).FirstOrDefault();
            if (result == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool CreateAccount(string name, string lastName, string username, string password)
        {
            var existsEmployee = db.Employees.Where(p => p.Username == username).FirstOrDefault();
            if (existsEmployee != null) // Dont create if the username already exists
            {
                return false;
            }
            else
            {
                var model = new Employee();
                model.Name = name;
                model.Lastname = lastName;
                model.Username = username;
                model.Password = password;
                db.Employees.Add(model);
                db.SaveChanges();
                return true;
            }
        }



        public bool CreateAccount2(Employee employee)
        {
            var existsEmployee = db.Employees.Where(p => p.Username == employee.Username).FirstOrDefault();
            if (existsEmployee != null) // Dont create if the username already exists
            {
                return false;
            }
            else
            {               
                db.Employees.Add(employee);
                db.SaveChanges();
                return true;
            }
        }
    }
}
