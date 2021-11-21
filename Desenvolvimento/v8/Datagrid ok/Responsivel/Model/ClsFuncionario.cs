using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Model
{
   public class ClsFuncionario
    {
        #region  Load || Botão Consultar Funcionario
//        public DataTable consultarFuncionario()
//        {
//            DataTable ret = new DataTable();
       
//            SqlConnection Conexao = new SqlConnection();

                 
//            String str = @"Data Source = DESKTOP-9J2BVIQ; Initial Catalog = HHOTEL; Integrated Security = True";

//            try {

//                string Query = " SELECT idUser " +
//                              " , tipoUser " + " As [Tipo de Usuario] " +
//                              " , senha " +
//                              " , estadLogin " +
//                              " , loginUser" +
//                              " , dataDeAceUser " +
//                              " , fotoPerfil " +
//                            //" , idPessoa" +
//                            //" , idAceite " +
//                            //" , idFunc_FK " +
//                            //" , idHosp_FK " +
//                              " FROM Usuario "  ;
//                            // " FROM Usuario " + ;
//                            //  " Where idUser = 3  ";



//            Conexao.ConnectionString = str;
//            SqlDataAdapter Da = new SqlDataAdapter(Query,Conexao);
//// F9
//            Da.Fill(ret);

//            }
//            catch (Exception e)
//            {
//                String err = e.Message;
//            }

//            return ret;

            #endregion

            //#region Botão inserir

            //private void BtnNomeInserir_Click(object sender, EventArgs e)
            //{
            //    string strConexao = @"Data Source=Angel01;Initial Catalog=Teste01;Integrated Security=True";
            //    string Query = "INSERT INTO tb01(Nome)VALUES('" + TxtNomeInserir.Text + "')";

            //    SqlConnection conexao = new SqlConnection(strConexao);
            //    SqlCommand comando = new SqlCommand(Query, conexao);

            //    conexao.Open();
            //    comando.ExecuteNonQuery();
            //    conexao.Close();
            //}
            //#endregion

            //#region Botão Consultar

            //private void BtnConsultar_Click(object sender, EventArgs e)
            //{
            //    string strConexao = @"Data Source=Angel01;Initial Catalog=Teste01;Integrated Security=True";
            //    string Query = "SELECT ID,Nome FROM tb01";

            //    SqlConnection conexao = new SqlConnection(strConexao);
            //    SqlDataAdapter da = new SqlDataAdapter(Query, strConexao);

            //    DataTable Tabela = new DataTable();

            //    da.Fill(Tabela);

            //    DgTb01.DataSource = Tabela;


            //    //SqlCommand comando = new SqlCommand(Query, conexao);

            //    //conexao.Open();
            //    //comando.ExecuteNonQuery();
            //    //conexao.Close();
            //}

            //#endregion

            //#region Botão Deletar
            //private void BtnNomeDelete_Click(object sender, EventArgs e)
            //{
            //    string strConexao = @"Data Source=Angel01;Initial Catalog=Teste01;Integrated Security=True";
            //    string Query = "DELETE FROM tb01 WHERE ID=" + TxtDeleteID.Text;

            //    SqlConnection conexao = new SqlConnection(strConexao);
            //    SqlCommand comando = new SqlCommand(Query, conexao);

            //    conexao.Open();
            //    comando.ExecuteNonQuery();
            //    conexao.Close();
            //}

            //#endregion

            //#region Botão Atualizar
            //private void BtnNomeUpdate_Click(object sender, EventArgs e)
            //{
            //    string strConexao = @"Data Source=Angel01;Initial Catalog=Teste01;Integrated Security=True";
            //    string Query = "UPDATE tb01 SET Nome='"
            //        + TxtNomeUpdate.Text +
            //        "' WHERE ID=" + TxtUpdateID.Text;

            //    SqlConnection conexao = new SqlConnection(strConexao);
            //    SqlCommand comando = new SqlCommand(Query, conexao);

            //    conexao.Open();
            //    comando.ExecuteNonQuery();
            //    conexao.Close();
            //}

            //#endregion



      //  }
    }
}
