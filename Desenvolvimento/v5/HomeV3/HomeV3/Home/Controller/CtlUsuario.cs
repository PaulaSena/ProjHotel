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
                            //UserLoginCache.LastUpdate = reader.GetDateTime(7);
                            //UserLoginCache.lembrSenha = reader.GetString(8);
                            //UserLoginCache.estadLogin = reader.GetBoolean(9);
                            //UserLoginCache.dataDeAceUser = reader.GetDateTime(10);
                            //UserLoginCache.fotoPerfil = reader.GetString(11);
                            //UserLoginCache.idPessoa = reader.GetInt32(12);
                            //UserLoginCache.idAceite = reader.GetInt32(13);
                            //UserLoginCache.idFunc_FK = reader.GetInt32(14);
                            //UserLoginCache.idHosp_FK = reader.GetInt32(15);

    /**
        * 

    ***07/10/2021 13:27********* Testando outro modelo no MVC e banco para realizar login 06 a 07/10/2021 13:27


            create database MyCompany
            go
            use MyCompany
            go
            create table Users(
            UserID int identity(1,1) primary key,
            LoginName nvarchar (100) unique not null,
            Password nvarchar (100) not null,
            FirstName nvarchar(100) not null,
            LastName nvarchar(100) not null,
            Position nvarchar (100) not null,
            Email nvarchar(150)not null
            ) 

            insert into Users values ('admin','admin','Jackson','Collins','Administrator','Support@SystemAll.biz')
            insert into Users values ('Ben','abc123456','Benjamin','Thompson','Receptionist','BenThompson@MyCompany.com')                                                         
            insert into Users values ('Kathy','abc123456','Kathrine','Smith','Accounting','KathySmith@MyCompany.com')


            -- Adicionando item a tabela
            Alter Table Products
            Add LastUpdate varchar(200) null

            ALTER TABLE Products ADD LastUpdate  varchar(200) NULL

            ALTER TABLE `products` ADD `LastUpdate` varchar(200) NULL AFTER `column_name`;

            select *from Users 

            --SELECT * FROM Users WHERE LoginName=@user and PassWord= @pass

            SELECT * FROM Users WHERE LoginName='admin' and PassWord= 'admin'

            declare @user nvarchar (100) = 'admin'
            declare @pass nvarchar (100) = 'admin'
            SELECT * FROM Users WHERE LoginName=@user and PassWord= @pass 


                ****07/10/2021 13:27********** Criado form Home logado com sucesso!


        * 
        * 
        *                         
        */
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


