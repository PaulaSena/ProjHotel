using Controller;
using System;



namespace Model

{
    public class MdlUsuario
    {
		CtlUsuario ctlUsuario = new CtlUsuario();
        public bool LoginUser(string user, string pass) => ctlUsuario.Login(user,pass); // => o mesmo que return 

        private int idUser { get; set; }

			private string tipoUser { get; set; }

			public string senha { get; set; }

			private bool estadLogin;

			public string loginUser { get; set; }

			private DateTime dataDeAceUser;

			public string confSenha { get; set; }
			
			private string fotoPerfil { get; set; }

			private int idPessoa;

			private int idHosp;

			private int idFunc;

			private int idAceite;
	}

	
}

