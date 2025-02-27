using System;

public class UserModel
{
    public string username { get; set; }
    public string password { get; set; }

    public UserModel(string username, string password)

    {
        this.username = username;
        this.password = password;
    }

    public UserModel()
	{
  
    }
}
