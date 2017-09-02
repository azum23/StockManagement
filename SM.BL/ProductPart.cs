using System;
using System.Data;
using System.Data.SqlClient;
using SM.BL;

namespace SM.BL
{
    public class ProductPart
    {
        /// <summary>
        /// Добавление нового продукта в БД
        /// </summary>
        /// <param name="newProductCode"></param>
        /// <param name="newProductName"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public bool AddProduct(int newProductCode, string newProductName, ref string message)
        {
            using (SqlConnection connection = new SqlConnection(CommonPart.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                }
                catch (SqlException ex)
                {
                    message += "Зовите на помощь системного администратора !!!\n\n";
                    message += ex.Message;
                    return false;
                }

                try
                {
                    // TODO: проверить существует ли такой продукт
                    SqlCommand addCmd = connection.CreateCommand();
                    SqlParameter addCmdParam = new SqlParameter("@productCode", newProductCode);
                    addCmdParam.SqlDbType = SqlDbType.Int;
                    addCmd.Parameters.Add(addCmdParam);

                    addCmdParam = new SqlParameter("@productName", newProductName);
                    addCmdParam.SqlDbType = SqlDbType.VarChar;
                    addCmd.Parameters.Add(addCmdParam);
                    addCmd.CommandText = @"insert into Products values " +
                        @"(@productCode,@productName,1)";
                    int res = addCmd.ExecuteNonQuery();
                    if (res ==1)
                    {
                        message =$"Продукт {newProductCode} : {newProductName} добавлен.";
                        return true;
                    }
                    else
                    {
                        message = $"Продукт {newProductCode} : {newProductName} не добавлен!";
                        return false;
                    }
                         
                }
                catch
                {
                    message = $"Что-то пошло не так!";
                    return false;
                }
            }
        }
    }
}
