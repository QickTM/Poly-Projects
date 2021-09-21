using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UserClass
/// </summary>
public class UserClass
{
    private string strPassword = "";
    private string strUsername = "";

    public string Username
    {
        get { return strUsername; }
    }

    public string Password
    {
        get { return strPassword; }
    }

    public UserClass(string pUsername, string pPassword)
    {
        strUsername = pUsername;
        strPassword = pPassword;
    }
}