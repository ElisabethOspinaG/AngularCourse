using WebAppDbRecipastk.DataAccess;

namespace WebAppDbRecipastk.services
{
    public class LoginServices
    {
        public ReciplastkContext db = new ReciplastkContext();
        public List<Employee> ShowUsers() {
            var listUsers = db.Employees.ToList();
            return listUsers;
        }

        public bool ExistUsername(string user)
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

            var userFound = GetlUser(user);
            if (userFound.Username == user & userFound.Password == password)
            {        
                    return true;
            }
            else
            {
                return false;
            }
        }

        
        public bool RegisterUser(string name, string lastname, string user, string password)
        {
            var exituser = ExistUsername(user);
            if (exituser)
            {
                return false;
            }
            else
            {
                var newEmployee = new Employee();
                newEmployee.Name = name;
                newEmployee.Lastname = lastname;
                newEmployee.Username = user;
                newEmployee.Password = password;
                db.Employees.Add(newEmployee);
                db.SaveChanges();
                return true;
            }
        }

        public string ModifyPassword(string user, string password, string newPassword)
        {
            
            var validateAccount = AcceseAcount(user, password);
            if(validateAccount)
            {
                var userFound = GetlUser(user);
                userFound.Password = newPassword;
                db.SaveChanges();

                return "Contraseña Modificada";
            }
            else
            {
                return "Error. No es posible Cambiar su contraseña, verifique los datos ingresados";
            }
        }
        public bool RemoveUser(string user)
        {
            var userFound = GetlUser(user);
            if (userFound != null)
            {
                db.Employees.Remove(userFound);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false ;
            }
        }
        

        
        
    }
}
