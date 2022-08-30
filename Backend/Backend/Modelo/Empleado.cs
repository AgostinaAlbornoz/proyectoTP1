using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Modelo
{
    public class Empleado
    {
        public int Legajo { get; set; }
        public string ApellidoYNombre { get; set; }
        public string DNI { get; set; }
        public string Email { get; set; }
        public string Contrasenia { get; set; }
    }
}
