using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle
{
   public class CtlFuncionario
    {
        #region  Load || Botão Consultar Funcionario

        public DataTable consultarFuncionario()
        {
            DataTable gridFunc = new DataTable();

            SqlConnection Conexao = new SqlConnection();

            String str = @"Data Source = DESKTOP-9J2BVIQ; Initial Catalog = HHOTEL; Integrated Security = True";

            try
            {

                string Query = " SELECT idUser " +
                              " , tipoUser " + " As [Tipo de Usuario] " +
                              " , senha " +
                              " , estadLogin " +
                              " , loginUser" +
                              " , dataDeAceUser " +
                              " , fotoPerfil " +
                              //" , idPessoa" +
                              //" , idAceite " +
                              //" , idFunc_FK " +
                              //" , idHosp_FK " +
                              " FROM Usuario ";
                // " FROM Usuario " + ;
                //  " Where idUser = 3  ";



                Conexao.ConnectionString = str;
                SqlDataAdapter Da = new SqlDataAdapter(Query, Conexao);
                // F9
                Da.Fill(gridFunc);

            }
            catch (Exception e)
            {
                String err = e.Message;
            }

            return gridFunc;

        #endregion
       
        }
    }
}
