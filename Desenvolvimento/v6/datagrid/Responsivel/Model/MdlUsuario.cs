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
    public class MdlUsuario

	{
        public static object DataSource { get; set; }
        public static string DisplayMember { get; set; }
        public static string ValueMember { get; set; }
        public int IdUser { get; set; }

		public string TipoUser { get; set; }

		public string Senha { get; set; }

		public bool EstadLogin { get; set; }

		public string LoginUser { get; set; }

		public DateTime DataDeAceUser { get; set; }

		public string FotoPerfil { get; set; }

		public int IdPessoa { get; set; }

		public int IdHosp { get; set; }

		public int TdFunc { get; set; }

		public int IdAceite  { get; set; }

        public object ListarUsuarios()
        {
            throw new NotImplementedException();
        }
    }

    }
