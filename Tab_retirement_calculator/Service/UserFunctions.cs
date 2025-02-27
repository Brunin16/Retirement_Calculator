using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tab_retirement_calculator.Model;

namespace Tab_retirement_calculator.Service
{
    public class UserFunctions
    {
        public List<UserModel> users = new List<UserModel> { new UserModel("Bruno", "123", "H")};

        public UserModel login(string username, string password)
        {
            foreach (UserModel user in users)
            {
                if (user.username == username && user.password == password)
                {
                    return user;
                }
            }
            return null;
        }

        public string register(string username, string password, string gender)
        {
            foreach (UserModel user in users)
            {
                if (user.username == username)
                {
                    return "Erro ao cadastrar usuario, este usuario ja existe";
                }
            }
            users.Add(new UserModel(username, password, gender));
            return "Usuario cadastrado com sucesso";
        }
        public UserModel show(int position)
        {
            return users[position];
        }

        public UserFunctions() { }
    }
}
