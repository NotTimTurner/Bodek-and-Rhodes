﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

/// <summary>
/// Summary description for DatabaseConnection
/// </summary>
public class DatabaseConnection
{
    private string sql_string;
    private string strCon;
    System.Data.SqlClient.SqlDataAdapter da_1;

    public string Sql
    {
        set { sql_string = value; }
    }

    public string connection_String
    {
        set { strCon = value; }
    }

    public System.Data.DataSet GetConnection
    {
        get { return MyDataSet(); }
    }

    private System.Data.DataSet MyDataSet()
    {
        using (System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(strCon))
        {
            con.Open();
            da_1 = new System.Data.SqlClient.SqlDataAdapter(sql_string, con);
            System.Data.DataSet dat_set = new System.Data.DataSet();
            da_1.Fill(dat_set, "Table_Data_1");
            return dat_set;
        }

    }

    public string GetPhillyConString()
    {
        // return GetTestConString();
       //  return (System.Configuration.ConfigurationManager.ConnectionStrings["WMSEntities"].ConnectionString);
        return ("Data Source=192.168.3.5;Initial Catalog=WMS;User ID=bodek;");
    }

    public string GetTestConString()
    {
        return ("Data Source=192.168.1.84;Initial Catalog=WMS;User ID=bodek;");
    }



    public DatabaseConnection()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}