using System.Globalization;
using WebAppDbRecipastk.DataAccess;
using WebAppDbRecipastk.Models;

namespace WebAppDbRecipastk.services
{
    public class LoginServices
    {
        public ReciplastkContext db = new ReciplastkContext();
        public HttpResponsiveModel data = new HttpResponsiveModel();
        public List<Employee> ShowUsers() {
            var listUsers = db.Employees.ToList();
            return listUsers;
        }

        public HttpResponsiveModel ShowAllUsers()
        {
            data.Data = db.Employees.ToList();
            return data ;
        }

        public bool ExistUsername( string user)
        {
            var exist = GetlUser(user);
            if(exist != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Employee GetlUser(string user) { 
        
            var userFound = db.Employees.Where(p=> p.Username == user).FirstOrDefault();
            return userFound;
        }

     
        public string VerifyPassword (string user, string password) {

            var userFound = GetlUser(user);
            if (userFound.Username == user & userFound.Password == password)
            {
                    return "Contraseña Correcta";
            }
            else
            {
                return "Error. No coincide la Contraseña";
            }
                
        }
        public bool AcceseAcount(string user, string password) {

            var userFound = db.Employees.Where(p => p.Username == user).FirstOrDefault();
            if (userFound.Username == user & userFound.Password == password)
            {        
                    return true;
            }
            else
            {
                return false;
            }
        }

        public bool RegisterUser(ModelNewUser modelNewUser)
        {
            var exituser = db.Employees.Where(p => p.Username == modelNewUser.Username).FirstOrDefault();
            if (exituser != null)
            {
                return false;
            }
            else
            {
                var newEmployee = new Employee();
                newEmployee.Name = modelNewUser.Name;
                newEmployee.Lastname = modelNewUser.LastName;
                newEmployee.Username = modelNewUser.Username;
                newEmployee.Password = modelNewUser.Password;

                db.Employees.Add(newEmployee);
                db.SaveChanges();
                return true;
            }
        }

        //public bool ModifyPassword(ModelsLogin modelsLogin)
        //{

            
        //    if (validateAccount)
        //    {
        //        var userFound = GetlUser(modelsLogin);
        //        userFound.Password = modelsLogin.NewPassword;
        //        db.SaveChanges();

        //        return true;
        //    }
        //    else
        //    {
        //        // "Error. No es posible Cambiar su contraseña, verifique los datos ingresados"
        //        return false;
        //    }
        //}
        //public bool DeleteUser(ModelsLogin modelsLogin)
        //{
        //    var exituser = db.Employees.Where(p => p.Username == modelsLogin.User).FirstOrDefault();
        //    if (exituser != null)
        //    {
        //        db.Employees.Remove(exituser);
        //        db.SaveChanges();
        //        return true;
        //    }
        //    else
        //    {
        //        return false ;
        //    }
        //} 
    }
}
