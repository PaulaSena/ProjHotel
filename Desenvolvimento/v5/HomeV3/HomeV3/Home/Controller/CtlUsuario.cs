using System;
using System.Data;
using System.Data.SqlClient;
using Common.Cache;

namespace Controller
{

    /* Verdadeira classe de Conexao DAOUsuario*/


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
                         // adicionando os campos lidos a variavel estatica
                         while (reader.Read())
                        {
                            UserLoginCache.IdUser = reader.GetInt32(0); // () - Aqui referenciamos a coluna na tapela iniciando por 0 
                            UserLoginCache.FirstName = reader.GetString(3);
                            UserLoginCache.LastName = reader.GetString(4);
                            UserLoginCache.Position = reader.GetString(5);
                            UserLoginCache.Email = reader.GetString(6);
                         //   UserLoginCache.LastUpdate = reader.GetDateTime(7);
                         //  UserLoginCache.lembrSenha = reader.GetString(8);
                         //   UserLoginCache.estadLogin = reader.GetBoolean(9);
                         //   UserLoginCache.dataDeAceUser = reader.GetDateTime(10);
                         //   UserLoginCache.fotoPerfil = reader.GetString(11);
                        //    UserLoginCache.idPessoa = reader.GetInt32(12);
                       //     UserLoginCache.idAceite = reader.GetInt32(13);
                       //     UserLoginCache.idFunc_FK = reader.GetInt32(14);
                      //      UserLoginCache.idHosp_FK = reader.GetInt32(15);
                        }
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


