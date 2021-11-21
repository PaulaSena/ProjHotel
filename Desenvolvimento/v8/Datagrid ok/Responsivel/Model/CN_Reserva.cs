using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controle;

namespace Model
{
  public class CN_Reserva
    {
        private CD_Reserva objetoCD = new CD_Reserva();

        public DataTable MostrarProd()
        {

            DataTable tabela = new DataTable();
            tabela = objetoCD.Mostrar();
            return tabela;
        }
        public void InsertarReser(string Orcamento, string desc, string PreReserva, double preco, bool periodo, string servico, string Uh, string acomodacao)
        {

            objetoCD.Insertar(Orcamento, desc, PreReserva, Convert.ToDouble(preco), periodo,  servico,   acomodacao, Convert.ToString(Uh));
        }

        public void EditarReser(string Orcamento, string desc, string PreReserva, double preco, bool periodo, string servico, string Uh, string acomodacao)
        {
            objetoCD.Editar(Orcamento, desc, PreReserva, Convert.ToDouble(preco), periodo, servico, acomodacao, Convert.ToString(Uh));

        }

        public void EliminarReser(string idReserva)
        {

            objetoCD.Eliminar(Convert.ToInt32(idReserva));
        }
    }
}
