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
    public class MdlFuncionario
    {

		public int IdFunc { get; set; }

		public string NomeFunc { get; set; }

		public string Rg { get; set; }

		public string Cpf { get; set; }

		public string Acesso { get; set; }

		public string Departamento { get; set; }

		public bool Situacao { get; set; }

		public double Salario { get; set; }

		public DateTime DataAcessoFunc { get; set; }

		public string Cargo { get; set; }
	}

}
