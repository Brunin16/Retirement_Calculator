using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tab_retirement_calculator.Model
{
    public class UserModel
    {
        public string username { get; set; }
        public string password { get; set; }

        public string gender { get; set; }

        public UserModel(string username, string password, string gender)
        {
            this.username = username;
            this.password = password;
            this.gender = gender;
        }
        public UserModel()
        {
        }
        public override string ToString()
        {
            return $"Username: {username} Password: {password}";
        }
    }
}
