using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle
{
    public class CD_Reserva
    {
        private CD_Conexao conexao = new CD_Conexao();

        SqlDataReader leer;
        DataTable tabela = new DataTable();
        SqlCommand comando = new SqlCommand();


        /****
         * Reserva 
            Hospegagem ( razao social)
            estrelas
            Orcamento 
            PreReserva
           
        Servico 

            - Quarto Uh - Acomodação ( Luxo, ... ) 
    
            - Diaria (Periodo: (FNRH- Chekin, Cheout) (Valor:  Desconto)
 
            - Restaurante (Meia Pensão, Completa, Com café)

            - Manutencao / Limpeza

         * 
         * 
         * ****/




        public DataTable Mostrar()
        {
            try
            {
                comando.Connection = conexao.AbrirConexion();
                comando.CommandText = "MostrarReserva";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                tabela.Load(leer);
                conexao.CerrarConexion();
                return tabela;
            }
            catch (Exception ex)
            {
                conexao.CerrarConexion();
                //Mensagem (Tracejado do Diagrama de Sequência)
                throw new Exception("Erro ao cadastrar Reserva: " + ex.Message);
            }
            finally
            {
                conexao.CerrarConexion();
            }
        }




        public void Insertar(string Orcamento, string desc, string PreReserva, double preco, bool periodo, string servico, string Uh, string acomodacao)
        {
            //PROCEDIMNIENTO

            comando.Connection = conexao.AbrirConexion();
            comando.CommandText = "InsetarReserva";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Orcamento", Orcamento);
            comando.Parameters.AddWithValue("@descrip", desc);
            comando.Parameters.AddWithValue("@PreReserva", PreReserva);
            comando.Parameters.AddWithValue("@preco", preco);
            comando.Parameters.AddWithValue("@periodo", periodo);
            comando.Parameters.AddWithValue("@servico", servico);
            comando.Parameters.AddWithValue("@Uh", Uh);
            comando.Parameters.AddWithValue("@acomodacao", acomodacao);


            comando.ExecuteNonQuery();

            comando.Parameters.Clear();

        }

        public void Editar(string Orcamento, string desc, string PreReserva, double preco, bool periodo, string servico, string Uh, string acomodacao)
        {

            comando.Connection = conexao.AbrirConexion();
            comando.CommandText = "EditarReserva";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Orcamento", Orcamento);
            comando.Parameters.AddWithValue("@descrip", desc);
            comando.Parameters.AddWithValue("@PreReserva", PreReserva);
            comando.Parameters.AddWithValue("@preco", preco);
            comando.Parameters.AddWithValue("@periodo", periodo);
            comando.Parameters.AddWithValue("@servico", servico);
            comando.Parameters.AddWithValue("@Uh", Uh);
            comando.Parameters.AddWithValue("@acomodacao", acomodacao);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public void Eliminar(int idReserva)
        {
            comando.Connection = conexao.AbrirConexion();
            comando.CommandText = "EliminarReserva";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idReserva", idReserva);



            comando.Parameters.Clear();

        }
    }

    //public class CD_Reserva
    //{
    //}
}

