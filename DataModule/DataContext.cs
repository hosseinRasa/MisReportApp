using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace DataModule
{
    public class DataContext
    {
        public static string? ConnectionString { get; set; } = string.Empty;
        public static bool Connect()
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        con.Close();
                    }
                    con.Open();
                    return true;
                }
                catch (Exception)
                {
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        con.Close();
                    }
                    return false;
                }

            }
        }
        public static bool Execute(string Command, List<SqlParameter> sqlParemeters)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                if (Connect())
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand(Command, con);
                    foreach (var parameter in sqlParemeters)
                    {
                        sqlCommand.Parameters.Add(parameter);

                    }
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if (!sqlDataReader.Read())
                    {
                        return false;
                    }


                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static IEnumerable<SignOwner> GetSignOwners()
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                if (Connect())
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand($"Select Id, cast(Id as varchar)+ '_' + Dscp From AccSignOwner", con);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        yield return new SignOwner
                        {
                            Id = Convert.ToInt32( sqlDataReader[0] ),
                            Dscp = sqlDataReader[1].ToString(),
                        };
                    }


                    
                }
         
            }
        }
       public static string GetCompanyName()
        {
            string companyName = "";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                if (Connect())
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand($"Select NAME from COM_COMPANY_INFO", con);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if (sqlDataReader.Read())
                    {

                        companyName = sqlDataReader[0].ToString();
                         
                    }


                    
                }
                return companyName;
            }
        }
    }
}
