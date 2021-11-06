using Controle;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class MdlHospede 

    {
		

        public int IdHosp { get; set; }

		public string NomeHosp { get; set; }

		public int Rg_string { get; set; }

		public string Cpf { get; set; }

		public bool situacaoHosp { get; set; }

		public DateTime DataAcessoHop { get; set; }


	}

}
