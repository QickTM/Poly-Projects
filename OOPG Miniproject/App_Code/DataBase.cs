using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// Summary description for DataBase
/// </summary>
public class DataBase
{
    string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\School\OOPG\Labs\OOPG Miniproject\App_Data\UserDataBase.mdf;Integrated Security=True";

    SqlConnection connObj;
    SqlCommand comdObj;
    SqlDataReader dR;

    public DataBase()
    {
        connObj = new SqlConnection(connStr);
        connObj.Open();
    }

    //For "Select" statement only
    public SqlDataReader ExecuteReader(string selStr)
    {
        comdObj = new SqlCommand(selStr, connObj);
        dR = comdObj.ExecuteReader();
        return dR;
    }

    //For "Insert", "Delete", "Update" statement
    public int ExecuteNonQuery(string sqlStr)
    {
        comdObj = new SqlCommand(sqlStr, connObj);
        return comdObj.ExecuteNonQuery();
    }
}