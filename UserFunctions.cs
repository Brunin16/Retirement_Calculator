using System;
using ../UserModel

public class UserFunctions
{
    public UserModel

    public UserFunctions()
    {
    }
    public bool Login(string username, string password)
    {
        if (username == "admin" && password == "admin")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
