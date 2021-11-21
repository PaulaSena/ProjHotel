using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controle;

namespace Model
{
    public class MdlClientes : CtlClientes
    {
        //ATRIBUTOS 
        int _idCli;
        string _Nome;
        string _Sobrenome;
        string _Direcao;
        string _Cidade;
        string _Email;
        string _Telefone;
        string _Ocupacao;

        //PROPIEDADES GETTERS AND SETTERS
        public int idCli {
            get {
                return _idCli;
            }

            set {
                _idCli = value;
            }
        }

        public string Nome {
            get {
                return _Nome;
            }

            set {
                _Nome = value;
            }
        }

        public string Sobrenome {
            get {
                return _Sobrenome;
            }

            set {
                _Sobrenome = value;
            }
        }

        public string Direcao {
            get {
                return _Direcao;
            }

            set {
                _Direcao = value;
            }
        }

        public string Cidade {
            get {
                return _Cidade;
            }

            set {
                _Cidade = value;
            }
        }

        public string Email {
            get {
                return _Email;
            }

            set {
                _Email = value;
            }
        }

        
        public string Telefone {
            get {
                return _Telefone;
            }

            set {
                _Telefone = value;
            }
        }

        public string Ocupacao {
            get {
                return _Ocupacao;
            }

            set {
                _Ocupacao = value;
            }
        }

    }

    
}
