using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
    public static class RegistroClienteCache
    {

        public static int ID { get; set; }
        public static int Nombre { get; set; }
        public static int Apellido  { get; set; }
        public static int Direccion  { get; set; }
        public static int Ciudad { get; set; }
        public static int Email   { get; set; }
        public static int Telefono { get; set; }
        public static int Ocupacion { get; set; }
    }

    public class RegistoClienteCache
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Ocupacion { get; set; }
    }
}
