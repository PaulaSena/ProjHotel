using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controle;

namespace Model
{
    #region Tabela Funcionario

    public class MdlFuncionario : CtlFuncionario
    {
      
        void populaGrid(DataTable gridFunc)
        {
            // ClsFuncionario x = new ClsFuncionario();
            CtlFuncionario funcionario = new CtlFuncionario();
            gridFunc = funcionario.consultarFuncionario();
           // dataGridView1 tbFuncionario = new dataGridView1();
        }

        #endregion


        //void populaGrid()
        //{
        //    // ClsFuncionario x = new ClsFuncionario();
        //    MdlFuncionario funcionario = new MdlFuncionario();
        //    // dataGridView1.DataSource = x.consultarFuncionario();
        //  //  dataGridView1.DataSource = funcionario.consultarFuncionario();


        //}

        public int idFunc { get; set; }

        public string NomeFunc { get; set; }

        public string Rg { get; set; }

        public string Cpf { get; set; }

        public string Acesso { get; set; }

        public string Departamento { get; set; }

        public bool Situacao { get; set; }

        public double Salario { get; set; }

        public DateTime DataAcessoFunc { get; set; }

        public string Cargo { get; set; }

        //public object consultarFuncionario()
        //{
        //    throw new NotImplementedException();
        //}




        #region  Load || Botão Consultar Funcionario

        // public DataTable consultarFuncionario();
        //{
        //    DataTable ret = new DataTable();

        //    SqlConnection Conexao = new SqlConnection();


        //    String str = @"Data Source = DESKTOP-9J2BVIQ; Initial Catalog = HHOTEL; Integrated Security = True";

        //    try
        //    {

        //        string Query = " SELECT idUser " +
        //                      " , tipoUser " + " As [Tipo de Usuario] " +
        //                      " , senha " +
        //                      " , estadLogin " +
        //                      " , loginUser" +
        //                      " , dataDeAceUser " +
        //                      " , fotoPerfil " +
        //                      //" , idPessoa" +
        //                      //" , idAceite " +
        //                      //" , idFunc_FK " +
        //                      //" , idHosp_FK " +
        //                      " FROM Usuario ";
        //        // " FROM Usuario " + ;
        //        //  " Where idUser = 3  ";



        //        Conexao.ConnectionString = str;
        //        SqlDataAdapter Da = new SqlDataAdapter(Query, Conexao);
        //        // F9
        //        Da.Fill(ret);

        //    }
        //    catch (Exception e)
        //    {
        //        String err = e.Message;
        //    }

        //    return ret;

        #endregion
        //  }

    }
}
