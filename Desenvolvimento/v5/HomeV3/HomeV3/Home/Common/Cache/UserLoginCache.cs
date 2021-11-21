using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache

{  // Dados Estaticos Permanece na memoria aqui ficara dados de inicio de sessao do usuario e LGPD
    public static  class UserLoginCache   {

		public static int IdUser { get; set; }

		public static string FirstName { get; set; }

		public static string LastName { get; set; }

		public static string Position { get; set; }

		public static string Email { get; set; }

		public static string tipoUser { get; set; }
		
		public static string senha { get; set; }

		public static bool estadLogin;

		public static string loginUser { get; set; }

		public static DateTime dataDeAceUser;

        public static string LastUpdate;
        
		public static string lembrSenha;

        public static string fotoPerfil { get; set; }

		public static int idPessoa { get; set; }

		public static int idAceite { get; set; }

		public static int idFunc_FK { get; set; }

		public static int idHosp_FK { get; set; }


		


	}
}

namespace Common
{
    public class UserLoginCache
    {
    }

    public class FrmPrincipal
    {
    }
}