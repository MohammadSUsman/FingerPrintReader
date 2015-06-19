using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace FingerPrintReader
{
    class UserLogin
    {
        public static bool Insert( string name,string pass,byte [] finger)
        {
           SqlConnection con = new SqlConnection (@"Data Source=.\sqlexpress;Initial Catalog=FingerTest;Integrated Security=True;Pooling=False");
            SqlCommand cmd = new SqlCommand ();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO UserLogin(Name,Password,FingerData)VALUES(@Name,@Password,@Finger)";
            cmd.Parameters.AddWithValue("@Name",name);
            cmd.Parameters.AddWithValue("@Password",pass);
            cmd.Parameters.AddWithValue("@Finger",finger);
            con.Open();
            if (cmd.ExecuteNonQuery() == 1)
	            {
		            con.Close();
                    return true;
	            }
            else
	            {
                   con.Close();
                   return false;
	            }
        }
    }
}
