
using Common.Cache;
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

    #region Tabela Usuario

    public class MdlUsuario  : CtlUsuario
    {

       
            void populaGrid(DataTable gridUser)
            {
                // ClsFuncionario x = new ClsFuncionario();
                CtlUsuario usuario = new CtlUsuario();
                gridUser = usuario.consultarUsuario();
                // dataGridView1 tbFuncionario = new dataGridView1();
            }

            #endregion



            #region login

            CtlUsuario CtlUsuario = new CtlUsuario();

        public bool LoginUser(string user, string pass) => CtlUsuario.Login(user, pass); // => o mesmo que return 

        // Validação

        //public bool editPassword(string user, string pass)
        //{
        //    if (user == UserLoginCache.IdUser){ 
        //    }
        //        return true;
        //    }
        //}

        #endregion

        //public static object DataSource { get; set; }
        //public static string DisplayMember { get; set; }
        //public static string ValueMember { get; set; }


        #region Publics


        public int idUser { get; set; }

        public string tipoUser { get; set; }

        public string senha { get; set; }

        public string email { get; set; }

        public bool estadLogin { get; set; }

        public string loginUser { get; set; }

        public DateTime dataDeAceUser { get; set; }

        public string LembrSenha { get; set; }

        public string fotoPerfil { get; set; }

        public int idPessoa { get; set; }

        public int idHosp { get; set; }

        public int idFunc { get; set; }

        public int idAceite { get; set; }

        #endregion


      
            // Consultar usuario





            //public int IdUser { get; set; }

            //public string TipoUser { get; set; }

            //public string Senha { get; set; }

            //public bool EstadLogin { get; set; }

            //public string LoginUser { get; set; }

            //public DateTime DataDeAceUser { get; set; }

            //public string FotoPerfil { get; set; }

            //public int IdPessoa { get; set; }

            //public int IdHosp { get; set; }

            //public int IdFunc { get; set; }

            //public int IdAceite { get; set; }

            //public object ListarUsuarios()
            //{
            //    throw new NotImplementedException();
            //}





        }
    }


