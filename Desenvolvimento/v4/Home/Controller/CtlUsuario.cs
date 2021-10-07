using System;
using System.Data;
using System.Data.SqlClient;

namespace Controller
{

    /* Verdadeira classe de Conexao */


    public class CtlUsuario : ConexaoDoSql
    {


        #region LogarUsuario



        //1.1.1.1 LogarUsuario 
        public bool Login(string user, string pass)
        {
            using (var conexao = GetSqlConnection())
            {
                conexao.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conexao;
                    command.CommandText = "SELECT * FROM Users WHERE LoginName=@user and PassWord= @pass";
                    command.Parameters.AddWithValue("@user", user); // Declarando os parametros
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                        return false;
                }
            }
        }
        #endregion

    }
}


