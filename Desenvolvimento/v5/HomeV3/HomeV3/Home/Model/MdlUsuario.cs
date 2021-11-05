using Controller;
using System;
using Common.Cache;



namespace Model

{
    public class MdlUsuario 
    {
		CtlUsuario ctlUsuario = new CtlUsuario();
       
		public bool LoginUser(string user, string pass) => ctlUsuario.Login(user,pass); // => o mesmo que return 

		
		private int idUser { get; set; }

			private string tipoUser { get; set; }

			private string senha { get; set; }
		 
			private string email { get; set; }

			private bool estadLogin;

			private string loginUser { get; set; }

			private DateTime dataDeAceUser;

			private string LembrSenha { get; set; }
			
			private string fotoPerfil { get; set; }

			private int idPessoa;

			private int idHosp;

			private int idFunc;

			private int idAceite;
	}

	



}

