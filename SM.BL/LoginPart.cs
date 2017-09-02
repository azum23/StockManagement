using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SM.BL
{
    public class LoginPart
    {
        //  Проверка логин/пасс и возврат true/false c сообщение о типе ошибки
        public static bool Check(string userLogin, string userPass, ref string message)
        {
            using (SqlConnection connection = new SqlConnection(CommonPart.GetConnectionString()))
            {
                string actualPass = string.Empty;

                try
                {
                    connection.Open();
                }
                catch (SqlException ex)
                {
                    message += ex.Message;
                    return false;
                }

                try
                {
                    SqlCommand cmdCheck = connection.CreateCommand();
                    cmdCheck.CommandText = @"Select [UserPassword] from [Stock].[dbo].[Users] where [UserName] = @userName";
                    SqlParameter nameParam = new SqlParameter("@userName", userLogin);
                    nameParam.SqlDbType = SqlDbType.VarChar;
                    nameParam.Direction = ParameterDirection.Input;
                    cmdCheck.Parameters.Add(nameParam);
                    actualPass = cmdCheck.ExecuteScalar().ToString();

                    if (userPass.Equals(actualPass))
                        return true;
                    else
                    {
                        message = "Неверно введен логин или пароль";
                        return false;
                    }
                }
                //  возникает в случае когда параметр не принимается
                catch
                {
                    message = "Неверно введен логин или пароль";
                    return false;
                }
            }

        }
    }
}

