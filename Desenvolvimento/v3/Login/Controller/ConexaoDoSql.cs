using System.Data.SqlClient;


namespace Controller
{
    public abstract class ConexaoDoSql
    {

        private readonly string conexaoString;
        public ConexaoDoSql()
        {    //conexão para a base local de vocês (conexaoSQL  DESKTOP-9J2BVIQ)
            conexaoString = @"Data Source=DESKTOP-9J2BVIQ;Initial Catalog=MyCompany;Integrated Security=True";
        }
         protected SqlConnection GetSqlConnection()      
            {
                return new SqlConnection(conexaoString);
            }
        }

    }

