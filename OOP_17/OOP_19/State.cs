using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_19
{
    public interface IUserState
    {
        void UserState(Patient user);
    }

    public class RegistredUser : IUserState
    {
        public void UserState(Patient user)
        {
            Console.WriteLine("Успешная регистрация");
        }
    }

    public class SingInUser : IUserState
    {
        public void UserState(Patient user)
        {
            Console.WriteLine("Успешный вход в систему");
        }
    }

    public class SingOutUser : IUserState
    {
        public void UserState(Patient user)
        {
            Console.WriteLine("Выход из системы");
        }
    }

  
}
